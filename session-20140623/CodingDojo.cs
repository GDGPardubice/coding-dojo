using System.Linq;
using Moq;
using Xunit;
using Xunit.Extensions;

namespace CodingDojo
{
    public class Game
    {
        private readonly IBoard _board;
        private readonly int _playerCount;

        public Game(IBoard board, int playerCount)
        {
            _board = board;
            _playerCount = playerCount;
        }

        public int PlayerOnMove { get; set; }

        public void Move(IPosition position)
        {
            if (!_board.IsEmptyAt(position)) return;
            _board.PlaceMark(position, 0);
            PlayerOnMove = IsLastPlayerOnMove() ? 0 : PlayerOnMove + 1;
        }

        private bool IsLastPlayerOnMove()
        {
            return PlayerOnMove + 1 == _playerCount;
        }

        public bool IsOver()
        {
            const int winningMarksCount = 5;
            return Enumerable.Range(0, _playerCount)
                .Any(player => _board.CountMarksInLine(player) == winningMarksCount);
        }
    }

    public interface IPosition
    {
    }

    public interface IBoard
    {
        void PlaceMark(IPosition position, int player);
        bool IsEmptyAt(IPosition position);
        int CountMarksInLine(int playerIndex);
    }

    public class Dojo
    {
        [Fact]
        public void PlayerCanPlaceAMark()
        {
            var board = new Mock<IBoard>();
            var position = new Mock<IPosition>();
            var game = new Game(board.Object, 2);
            const int playerNumber = 0;

            board.Setup(b => b.IsEmptyAt(position.Object)).Returns(true);
            board.Setup(b => b.PlaceMark(position.Object, playerNumber));
            game.Move(position.Object);
            board.Verify(b => b.PlaceMark(position.Object, playerNumber));
        }

        [Fact]
        public void PlayerCanPlaceAMarkOnlyOnAnEmptyPlace()
        {
            var board = new Mock<IBoard>();
            var position = new Mock<IPosition>();
            var game = new Game(board.Object, 2);
            const int playerNumber = 0;

            board.Setup(b => b.PlaceMark(position.Object, playerNumber));
            board.Setup(b => b.IsEmptyAt(position.Object)).Returns(false);
            game.Move(position.Object);
            
            board.Verify(b => b.PlaceMark(position.Object, playerNumber), Times.Never);
        }

        [Theory]
        [InlineData(3, 2, 2)]
        [InlineData(4, 3, 3)]
        [InlineData(4, 4, 0)]
        public void PlayersAreSwitchingBetweenMoves(int playerCount, int movesCount, int lastPlayerIndex)
        {
            var board = new Mock<IBoard>();
            board.Setup(b => b.IsEmptyAt(It.IsAny<IPosition>())).Returns(true);

            var game = new Game(board.Object, playerCount);
            var position = new Mock<IPosition>();
            while (movesCount-- > 0)
            {
                game.Move(position.Object);
            }
            Assert.Equal(lastPlayerIndex, game.PlayerOnMove);
        }

        [Fact]
        public void WhenNoMovesWasDoneTheGameIsNotOver()
        {
            var board = new Mock<IBoard>();
            var game = new Game(board.Object, 2);
            Assert.False(game.IsOver());
        }

        [Fact]
        public void WhenOnBoardIsFiveSameMarksInLineTheGameIsOver()
        {
            var board = new Mock<IBoard>();
            var game = new Game(board.Object, 2);
            board.Setup(b => b.CountMarksInLine(0)).Returns(5);
            Assert.True(game.IsOver());
            board.Verify(b => b.CountMarksInLine(0));
        }
    }
}
