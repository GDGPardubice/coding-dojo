using GameOfLife;
using Xunit;

namespace GameOfLifeTests
{
    public class GameOfLifeTests
    {
        [Fact]
        public void NextGenerationOfEmptyGenerationIsEmpty()
        {
            Generation empty = new Generation();
            Game game = new Game(empty);
            Generation newGeneration = game.nextGeneration();
            Assert.True(newGeneration.Empty);
        }

        [Fact]
        public void NextGenerationOfGenerationWithOneCellIsNotEmpty()
        {
            Generation generationWithOneCell = new Generation(new Cell[] { new Cell(0, 0) });
            Game game = new Game(generationWithOneCell);
            Generation newGeneration = game.nextGeneration();
            Assert.False(newGeneration.Empty);
        }

        [Fact]
        public void NextGenerationOfGenerationWithOneAliveCellHasOneDeadCell()
        {
            Generation generationWithOneCell = new Generation(new Cell[] { new Cell(0, 0) });
            Game game = new Game(generationWithOneCell);
            Generation newGeneration = game.nextGeneration();
            Assert.Single(newGeneration.DeadCells);
        }

        [Fact]
        public void NextGenerationOfThreeAliveCellsHasNotDeadCells()
        {
            Generation generationWithThreeAliveCells = new Generation(new Cell[]{ new Cell(0, 0), new Cell(0, 1), new Cell(1, 0) });
            Game game = new Game(generationWithThreeAliveCells);
            Generation newGeneration = game.nextGeneration();
            Assert.Empty(newGeneration.DeadCells);
        }

        [Fact]
        public void NextGenerationOfTwoAliveCellsHasTwoDeadCells()
        {
            Generation generationWithTwoAliveCells = new Generation(new Cell[] { new Cell(0, 0), new Cell(0, 1)});
            Game game = new Game(generationWithTwoAliveCells);
            Generation newGeneration = game.nextGeneration();
            Assert.Equal(2, newGeneration.DeadCells.Count);
        }
    }
}
