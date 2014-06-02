using System;
using Xunit;
using Xunit.Extensions;

namespace CodingDojo
{
    public class Dojo
    {
        const char PacmanDirectionNone = 'O';
        public class Grid
        {
            private readonly int _rowCount;
            private readonly int _columnCount;
            private char[,] _gridContent;
            private Tuple<int, int> _lastPacmanPosition;

            public Grid(int rowCount, int columnCount)
            {
                _rowCount = rowCount;
                _columnCount = columnCount;
                _gridContent = new char[rowCount, columnCount];
                for (int row = 0; row < rowCount; row++)
                    for (int col = 0; col < columnCount; col++)
                    {
                        _gridContent[row, col] = '.';
                    }
            }

            public int GetRowCount()
            {
                return _rowCount;
            }

            public int GetCollCount()
            {
                return _columnCount;
            }

            public char At(int row, int col)
            {
                return _gridContent[row,col];
            }

            public void PlacePacmanAt(int row, int col)
            {
                _lastPacmanPosition = Tuple.Create(row, col);
                _gridContent[row, col] = PacmanDirectionNone;
            }

            public void MovePacmanTo(int row, int col)
            {
                _gridContent[_lastPacmanPosition.Item1, _lastPacmanPosition.Item2] = ' ';
                PlacePacmanAt(row, col);
            }
        }

        public class Pacman
        {
            private Direction _direction;


            public enum Direction
            {
                Right,
                Left
            }

            public Direction GetDirection()
            {
                return _direction;
            }

            public void Turn(Direction direction)
            {
                _direction = direction;
            }
        }

        [Theory]
        [InlineData(3, 5)]
        [InlineData(2, 1)]
        public void GridHasDefinedCountOfRows(int rowCount, int columnCount)
        {
            var grid = new Grid(rowCount, columnCount);
            Assert.Equal(rowCount, grid.GetRowCount());
            Assert.Equal(columnCount, grid.GetCollCount());
        }

        [Fact]
        public void GridIsFilledByDots()
        {
            var grid = new Grid(3, 3);
            Assert.Equal('.', grid.At(0, 0));
        }

        [Fact]
        public void PacmanIsOnDefinedPosition()
        {
            var grid = new Grid(3, 3);
            grid.PlacePacmanAt(0, 0);
            Assert.Equal(PacmanDirectionNone, grid.At(0, 0));
        } 
        
        [Theory]
        [InlineData(Pacman.Direction.Right)]
        [InlineData(Pacman.Direction.Left)]

        public void PacmanHasInitialDirection(Pacman.Direction testDirection)
        {
            var pacman = new Pacman();
            pacman.Turn(testDirection);
            Assert.Equal(testDirection, pacman.GetDirection());
        }
               
        [Fact]
        public void PacmanIsOnDefinedPositionAndGridIsStillFilledByDots()
        {
            var grid = new Grid(3, 3);
            grid.PlacePacmanAt(0, 0);
            Assert.Equal('.', grid.At(1, 1));
        }

        [Fact]
        public void PacmanAfterMovedIsEmpty()
        {
            var grid = new Grid(3, 3);
            grid.PlacePacmanAt(0, 0);
            grid.MovePacmanTo(1, 0);
            Assert.Equal(' ', grid.At(0, 0));
        }


    }
}
