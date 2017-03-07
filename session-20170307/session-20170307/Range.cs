using System.Text.RegularExpressions;

namespace session_20170307
{
    public class Range
    {
        private readonly string _pattern = @"^([<\[])([ ]*[-]?[0-9]+[ ]*)([;])([ ]*[-]?[0-9]+[ ]*)([>\]])$";
        private readonly bool _isValid;

        public bool IsOpenFromLeft { get; set; }
        public bool IsOpenFromRight { get; set; }
        public int LeftBoundary { get; set; }
        public int RightBoundary { get; set; }

        public Range(string range)
        {
            _isValid = Regex.IsMatch(range, _pattern);
            
            if (_isValid)
            {
                var matchs = Regex.Match(range, _pattern);
                IsOpenFromLeft = matchs.Groups[1].Value.Equals("<");
                IsOpenFromRight = matchs.Groups[5].Value.Equals(">");
                LeftBoundary = int.Parse(matchs.Groups[2].Value.Trim());
                RightBoundary= int.Parse(matchs.Groups[4].Value.Trim());
            }
        }


        public bool IsValidRange()
        {
            return _isValid;
        }

    }
}
