using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_20170328
{
    public class WordPuzzle
    {
        private char[,] matrix;
        public WordPuzzle(char[,] matrix)
        {
            this.matrix = matrix;
        }

        public Vector? SearchWord(string word)
        {
            var horizontally = SearchWordHorizontally(word);
            if (horizontally.HasValue)
                return horizontally;

            var vertically = SearchWordVertically(word);
            if (vertically.HasValue)
                return vertically;

            return null;
        }

        private Vector? SearchWordHorizontally(string word)
        {
            for (var y = 0; y < matrix.GetLength(0); y++)
            {
                var builder = new StringBuilder();

                for (var x = 0; x < matrix.GetLength(1); x++)
                {
                    builder.Append(matrix[y, x]);
                }

                var line = builder.ToString();
                var vector = SearchWordInLine(word, line, y);

                if (vector.HasValue)
                {
                    return vector.Value;
                }
            }

            return null;
        }

        private Vector? SearchWordVertically(string word)
        {
            for (var x = 0; x < matrix.GetLength(1); x++)
            {
                var builder = new StringBuilder();

                for (var y = 0; y < matrix.GetLength(0); y++)
                {
                    builder.Append(matrix[y, x]);
                }

                var line = builder.ToString();
                var vector = SearchWordInColumn(word, line, x);

                if (vector.HasValue)
                {
                    return vector.Value;
                }
            }

            return null;
        }

        private static Vector? SearchWordInLine(string word, string line, int y)
        {
            var firstX = line.IndexOf(word, StringComparison.Ordinal);
            if (firstX >= 0)
            {
                return new Vector
                {
                    First = new Point { X = firstX, Y = y },
                    Last = new Point { X = firstX + word.Length - 1, Y = y }
                };
            }
            return null;
        }

        private static Vector? SearchWordInColumn(string word, string colunn, int x)
        {
            var firstY = colunn.IndexOf(word, StringComparison.Ordinal);
            if (firstY >= 0)
            {
                return new Vector
                {
                    First = new Point { X = x, Y = firstY },
                    Last = new Point { X = x, Y = firstY + word.Length - 1 }
                };
            }
            return null;
        }
    }
}
