using NUnit.Framework;
using session_20170328;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_20170328.Tests
{
    [TestFixture]
    public class WordPuzzleTests
    {
        [Test]
        public void FindsPositionOfAWordInOneLetterMatrixWithACharacter()
        {
            WordPuzzle wordPuzzle = new WordPuzzle(new char[,] { { 'a' } });
            Assert.AreEqual(new Vector() { First = new Point() { X = 0, Y = 0 }, Last = new Point() { X = 0, Y = 0 }, }
        , wordPuzzle.SearchWord("a"));
        }

        [Test]
        public void NotFindsPositionOfBWordInOneLetterMatrixWithACharacter()
        {
            WordPuzzle wordPuzzle = new WordPuzzle(new char[,] { { 'a' } });
            Assert.AreEqual(null, wordPuzzle.SearchWord("b"));
        }

        [Test]
        public void FindsPositionOfHojWordInMatrixWithSingleLine()
        {
            var wordPuzzle = new WordPuzzle(new[,] { { 'a', 'h', 'o', 'j' } });
            Assert.AreEqual(new Vector { First = new Point { X = 1, Y = 0 }, Last = new Point { X = 3, Y = 0 } }, wordPuzzle.SearchWord("hoj"));
        }

        [Test]
        public void FindsPositionOfHojWordInMatrixWithMultipleLines()
        {
            var wordPuzzle = new WordPuzzle(new[,] { { 'a', 'h', 'o', 's' }, { 'a', 'h', 'o', 'j' } });
            Assert.AreEqual(new Vector { First = new Point { X = 1, Y = 1 }, Last = new Point { X = 3, Y = 1 } }, wordPuzzle.SearchWord("hoj"));
        }

        [Test]
        public void FindsPositionOfHojInFirstColumn()
        {
            var wordPuzzle = new WordPuzzle(new[,] { { 'a' }, { 'h' }, { 'o' }, { 'j' } });
            Assert.AreEqual(new Vector { First = new Point { X = 0, Y = 1 }, Last = new Point { X = 0, Y = 3 } }, wordPuzzle.SearchWord("hoj"));
        }
    }
}