using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Extensions;

namespace CodingDojo
{
    public struct Position
    {
        public readonly int X;
        public readonly int Y;

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Position other)
        {
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Position && Equals((Position)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }

        public static Position GetDown(Position position)
        {

            return new Position(position.X, position.Y + 1);
        }

        public static Position GetUp(Position position)
        {

            return new Position(position.X, position.Y - 1);
        }

        public static Position GetLeft(Position position)
        {

            return new Position(position.X - 1, position.Y);
        }

        public static Position GetRight(Position position)
        {

            return new Position(position.X + 1, position.Y);
        }
    }

    public class Grid
    {
        private bool _isPacManAtGrid;
        private Position? _pacManPosition;
        public const string FilledCell = ".";
        public const string EmptyCell = " ";
        public const string PacMan = "O";

        private readonly int _height;
        private readonly int _width;
        private readonly HashSet<Position> _visitedCells = new HashSet<Position>();
        private readonly HashSet<Position> _wallsPositions = new HashSet<Position>();

        public Grid(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public Position? PacmanPosition { get { return _pacManPosition; } }

        public string At(Position position)
        {
            if (position.Equals(_pacManPosition)) return PacMan;
            if (_visitedCells.Contains(position))
                return EmptyCell;
            return FilledCell;
        }

        public void PlacePacManAt(Position position)
        {
            _isPacManAtGrid = true;
            MovePacManTo(position);
        }

        public void MovePacManTo(Position position)
        {
            if (!IsValidMove(position))
            {
                throw new InvalidMoveException();
            }
            _pacManPosition = position;
            _visitedCells.Add(position);
        }

        private bool IsValidMove(Position position)
        {
            if (!_isPacManAtGrid) return false;
            if (_wallsPositions.Contains(position)) return false;
            return position.X >= 0
                && position.X < _width
                && position.Y >= 0
                && position.Y < _height;
        }

        public void PlaceWall(Position wallPosition)
        {
            _wallsPositions.Add(wallPosition);
        }
    }

    public class Game
    {
        public Direction PacmanDirection = Direction.Right;
        private readonly Grid _grid;

        public Game(Grid grid)
        {
            _grid = grid;
        }

        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        public void Tick()
        {
            Position newPosition = default(Position);
            switch (PacmanDirection)
            {
                case Direction.Down:
                    newPosition = Position.GetDown(_grid.PacmanPosition.Value);
                    break;
                case Direction.Up:
                    newPosition = Position.GetUp(_grid.PacmanPosition.Value);
                    break;
                case Direction.Right:
                    newPosition = Position.GetRight(_grid.PacmanPosition.Value);
                    break;
                case Direction.Left:
                    newPosition = Position.GetLeft(_grid.PacmanPosition.Value);
                    break;
            }
            _grid.MovePacManTo(newPosition);
        }
    }

    public class Dojo
    {
        [Fact]
        public void GridIsFilledWithDots()
        {
            const int width = 4;
            const int height = 8;
            var grid = new Grid(width, height);

            AssertFilledWithDots(grid, width, height);
        }

        private static void AssertFilledWithDots(Grid grid, int width, int height)
        {
            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                {
                    var position = new Position(x, y);
                    Assert.Equal(Grid.FilledCell, grid.At(position));
                }
            }
        }

        [Fact]
        public void CellWithPacmanIsNotFilledWithDot()
        {
            var grid = new Grid(4, 8);
            var originPosition = new Position(0, 0);
            grid.PlacePacManAt(originPosition);
            Assert.NotEqual(Grid.FilledCell, grid.At(originPosition));
        }

        [Fact]
        public void CellNearPacmanIsFilledWithDot()
        {
            var grid = new Grid(4, 8);
            var originPosition = new Position(0, 0);
            var positionNextToActual = new Position(1, 0);

            grid.PlacePacManAt(originPosition);
            Assert.Equal(Grid.FilledCell, grid.At(positionNextToActual));
        }

        [Fact]
        public void CellVisitedByPacManIsNotFilledWithDot()
        {
            var grid = new Grid(4, 8);
            var originPosition = new Position(0, 0);
            var positionNextToActual = new Position(1, 0);

            grid.PlacePacManAt(originPosition);
            grid.MovePacManTo(positionNextToActual);
            Assert.NotEqual(Grid.FilledCell, grid.At(positionNextToActual));
        }

        [Fact]
        public void AllCellsVisitedByPacManAreNotFilledWithDots()
        {
            var grid = new Grid(4, 8);
            var originPosition = new Position(0, 0);
            var positionNextToActual = new Position(1, 0);

            grid.PlacePacManAt(originPosition);
            grid.MovePacManTo(positionNextToActual);
            Assert.NotEqual(Grid.FilledCell, grid.At(originPosition));
        }

        [Fact]
        public void WithPacmansHeadYouDontBreakThrough()
        {
            var grid = new Grid(4, 8);
            var originPosition = new Position(0, 0);
            var positionNextToActual = new Position(-1, 0);

            grid.PlacePacManAt(originPosition);
            Assert.Throws<InvalidMoveException>(() => grid.MovePacManTo(positionNextToActual));
        }

        [Fact]
        public void PacManCantMoveToWall()
        {
            var grid = new Grid(4, 8);
            var positionWall = new Position(2, 0);
            grid.PlaceWall(positionWall);
            var originPosition = new Position(0, 0);
            var positionNextToActual = new Position(2, 0);

            grid.PlacePacManAt(originPosition);
            Assert.Throws<InvalidMoveException>(() => grid.MovePacManTo(positionNextToActual));
        }

        [Fact]
        public void PacManCantMoveIfItDoesNotExist()
        {
            var grid = new Grid(4, 8);
            var somePosition = new Position(2, 1);

            Assert.Throws<InvalidMoveException>(() => grid.MovePacManTo(somePosition));
        }

        [Fact]
        public void NewPacmanIsLookingToTheRight()
        {
            var grid = new Grid(4, 8);
            var game = new Game(grid);
            Assert.Equal(Game.Direction.Right, game.PacmanDirection);
        }

        [Theory]
        [InlineData(Game.Direction.Right, 1, 0)]
        [InlineData(Game.Direction.Down, 0, 1)]
        public void PacmanMovesAfterTick(Game.Direction direction, int nextX, int nextY)
        {
            var grid = new Grid(4, 8);
            var originPosition = new Position(0, 0);
            var positionNextToActual = new Position(nextX, nextY);

            grid.PlacePacManAt(originPosition);
            var game = new Game(grid);
            game.PacmanDirection = direction;
            game.Tick();
            Assert.Equal(Grid.PacMan, grid.At(positionNextToActual));
        }
    }



    public class InvalidMoveException : Exception
    {
    }
}
