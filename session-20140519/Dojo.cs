using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Extensions;

namespace CodingDojo
{
    public class Dojo
    {
        private static readonly Dictionary<int, string> RomanNumbers = new Dictionary<int, string>()
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" }, 
            { 90, "XC" }, 
            { 50, "L" }, 
            { 10, "X" }, 
            { 9, "IX" }, 
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };

        public static string ArabicToRoman(int inputNumber)
        {
            var romanNumberBuilder = new StringBuilder();

            foreach (var romanDigit in RomanNumbers)
            {
                while (inputNumber >= romanDigit.Key)
                {
                    romanNumberBuilder.Append(romanDigit.Value);
                    inputNumber -= romanDigit.Key;
                }
            }
            return romanNumberBuilder.ToString();
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("XII", 12)]
        [InlineData("LX", 60)]
        [InlineData("XX", 20)]
        [InlineData("IV", 4)]
        [InlineData("MCMXCIX", 1999)]
        [InlineData("DCLXVI", 666)]
        [InlineData("CDLIX", 459)]
        [InlineData("", 0)]
        public void ForArabicNumberReturnRomanRepresentation(string romanNumber, int arabicNumber)
        {
            Assert.Equal(romanNumber, ArabicToRoman(arabicNumber));
        }
    }
}
