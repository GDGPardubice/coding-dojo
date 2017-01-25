using NUnit.Framework;
using session_20170124;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_20170124.Tests
{
    [TestFixture]
    public class MinesweeperTests
    {
        [Test]
        public void ThereIsNoBombInEmptyField()
        {
            var minesweeper = new Minesweeper(new bool[0, 0]);
            Assert.IsFalse(minesweeper.IsBomb(0, 0));
        }

        [Test]
        public void ThereIsABombAtFieldWithBomb()
        {
            var minesweeper = new Minesweeper(new[,] { { true } });
            Assert.IsTrue(minesweeper.IsBomb(0, 0));
        }

        [Test]
        public void CellWithoutBombsInNeighborhoodHasScoreZero()
        {
            var minesweeper = new Minesweeper(new[,] { { false, false }, { false, false } });
            Assert.AreEqual(0, minesweeper.GetCellScore(0, 0));
        }

        [Test]
        public void CellWithOneBombInNeighborhoodHasScoreOne()
        {
            var minesweeper = new Minesweeper(new[,] { { false, true }, { false, false } });
            Assert.AreEqual(1, minesweeper.GetCellScore(0, 0));
        }

        [Test]
        public void CellWithThreeBombsInNeighborhoodHasScoreThree()
        {
            var minesweeper = new Minesweeper(new[,] { { true, true }, { false, true } });
            Assert.AreEqual(3, minesweeper.GetCellScore(1, 0));
        }

        [Test]
        public void CellWithEightBombsInNeighborhoodHasScoreEight()
        {
            var minesweeper = new Minesweeper(new[,] { { true, true, true }, { true, false, true }, { true, true, true } });
            Assert.AreEqual(8, minesweeper.GetCellScore(1, 1));
        }

        [Test]
        public void CellWithTwoBombsInNeighborhoodHasScoreTwo()
        {
            var minesweeper = new Minesweeper(new[,] { { false, true, true }, { false, false, false }, { false, false, false } });
            Assert.AreEqual(2, minesweeper.GetCellScore(1, 2));
        }

        [Test]
        public void CellWithTwoBombsAtFieldAndZeroInNeighborhoodHasScoreZero()
        {
            var minesweeper = new Minesweeper(new[,] { { false, true, true }, { false, false, false }, { false, false, false } });
            Assert.AreEqual(0, minesweeper.GetCellScore(2, 0));
        }

        [Test]
        public void CellWithThreeBombsAtFieldAndZeroInNeighborhoodHasScoreZero()
        {
            var minesweeper = new Minesweeper(new[,] { { false, false, false }, { false, false, false }, { true, true, true } });
            Assert.AreEqual(0, minesweeper.GetCellScore(0, 0));
        }
    }
}