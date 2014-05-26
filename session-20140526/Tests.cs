using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace LangtonsAnt
{
    public class Tests
    {

        private readonly Position _defaultPosition = new Position(0, 0);

        [Fact]
        public void CellOnDefaultPositionIsWhite()
        {
            var board = new Board();
            Assert.True(board.IsWhite(_defaultPosition));
        }

        [Fact]
        public void WhiteCellIsBlackAfterChange()
        {
            var board = new Board();
            board.ChangeColor(_defaultPosition);
            Assert.True(board.IsBlack(_defaultPosition));
        }

        [Fact]
        public void DefaultPositionIsntBlack()
        {
            var board = new Board();
            Assert.False(board.IsBlack(_defaultPosition));
        }

        [Fact]
        public void CellOnSomeChangedPositionIsBlack()
        {
            var board = new Board();
            board.ChangeColor(_defaultPosition);
            var somePosition = new Position(0, 1);
            board.ChangeColor(somePosition);
            Assert.True(board.IsBlack(somePosition));
        }

        [Fact]
        public void TwiceChangedCellHasOriginalColor()
        {
            var board = new Board();
            var somePosition = new Position(0, 1);
            var samePosition = new Position(0, 1);
            board.ChangeColor(somePosition);
            board.ChangeColor(samePosition);
            Assert.True(board.IsWhite(somePosition));
        }

        [Fact]
        public void DefaultPositionOfAntIsNorth()
        {
            var ant = AntFactory.CreateAntOnDefaultPosition();
            Assert.True(ant.IsOrientedToNorth());
        }

        [Fact]
        public void AfterTurnRightOrientedToEast()
        {
            var ant = AntFactory.CreateAntOnDefaultPosition();
            ant.TurnRight();
            Assert.True(ant.IsOrientedToEast());
        }

        [Fact]
        public void AfterTurnRightIsntOrientedToNorth()
        {
            var ant = AntFactory.CreateAntOnDefaultPosition();
            ant.TurnRight();
            Assert.False(ant.IsOrientedToNorth());
        }

        [Fact]
        public void AfterTurnLeftIsOrientedToWest()
        {
            var ant = AntFactory.CreateAntOnDefaultPosition();
            ant.TurnLeft();
            Assert.True(ant.IsOrientedToWest());
        }

        [Fact]
        public void AfterTurnLeftIsNotOrientedToNorth()
        {
            var ant = AntFactory.CreateAntOnDefaultPosition();
            ant.TurnLeft();
            Assert.False(ant.IsOrientedToNorth());
        }

        [Fact]
        public void AfterTwoLeftTurnsIsOrientedToSouth()
        {
            var ant = AntFactory.CreateAntOnDefaultPosition();
            ant.TurnLeft();
            ant.TurnLeft();
            Assert.True(ant.IsOrientedToSouth());
        }

        [Fact]
        public void AfterThreeRightTurnsIsOrientedToWest()
        {
            var ant = AntFactory.CreateAntOnDefaultPosition();
            ant.TurnRight();
            ant.TurnRight();
            ant.TurnRight();
            Assert.True(ant.IsOrientedToWest());
        }

        [Fact]
        public void NewAntIsOnDefaultPosition()
        {
            var ant = AntFactory.CreateAntOnDefaultPosition();
            Assert.Equal(_defaultPosition, ant.GetPosition());
        }

        [Fact]
        public void NewAntIsOnCustomPosition()
        {
            var somePosition = new Position(0, 1);
            var ant = new Ant(somePosition);
            Assert.Equal(somePosition, ant.GetPosition());
        }
    }

    public class AntFactory
    {
        private static readonly Position DefaultPosition = new Position(0, 0);

        public static Ant CreateAntOnPosition(Position positon)
        {
            return new Ant(positon);
        }

        public static Ant CreateAntOnDefaultPosition()
        {
            return new Ant(DefaultPosition);
        }

    }
}
