using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_20170214
{


    public class Range
    {
        private readonly bool _closedFromLeft;
        private readonly bool _closedFromRight;
        private readonly int _start;
        private readonly int _end;
        private bool _isValid;

        public Range(String range)
        {
            ValidateInterval(range);
            if (!_isValid)
            {
                return;
            }
            _closedFromLeft = range.StartsWith("[");
            _closedFromRight = range.EndsWith("]");

            int indexOfSeparator = range.IndexOf(",", StringComparison.Ordinal);
            if (indexOfSeparator == -1)
            {
                _isValid = false;
                return;
            }
            _start = Convert.ToInt32(range.Substring(1, indexOfSeparator - 1));
            _end = Convert.ToInt32(range.Substring(indexOfSeparator + 1, range.Length - 1 - (indexOfSeparator + 1)));
        }

        public bool IsValid()
        {
            return _isValid;
        }

        private void ValidateInterval(String range)
        {
            _isValid = "([".Contains(range.ElementAt(0)) &&
                       "])".Contains(range.ElementAt(range.Length - 1)) &&
                       IsBodyValid(range);
        }

        private bool IsBodyValid(String range)
        {
            bool separateMarkWas = false;
            char last = ' ';
            for (int i = 1; i < range.Length - 1; i++)
            {
                char current = range.ElementAt(i);
                if (current == ',' && !separateMarkWas)
                {
                    separateMarkWas = true;
                    continue;
                }
                if ((!Char.IsDigit(current) && current != ',' && current != ' ')
                        || (current == ',' && separateMarkWas))
                {
                    return false;
                }
                last = current;
            }
            return separateMarkWas;
        }
    }
}
