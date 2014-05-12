using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace CodingDojo
{
    public class Dojo
    {
        private readonly Dictionary<string, int> _romanArabicMap = new Dictionary<string, int>
                                 {
                                     {"I", 1},
                                     {"V", 5},
                                     {"X", 10},
                                     {"L", 50},
                                     {"C", 100},
                                     {"D", 500},
                                     {"M", 1000},
                                     // special cases
                                     {"IV", 4},
                                     {"IX", 9},
                                     {"XL", 40},
                                     {"XC", 90},
                                     {"CD", 400},
                                     {"CM", 900}
                                 };

        private const int SpecialCaseLength = 2;
        private int ToArabic(string romanNumber)
        {
            var result = 0;
            var index = 0;
            while (index < romanNumber.Length)
            {
                if (index < (romanNumber.Length - 1) && _romanArabicMap.ContainsKey(romanNumber.Substring(index, SpecialCaseLength)))
                {
                    result += _romanArabicMap[romanNumber.Substring(index, SpecialCaseLength)];
                    index += SpecialCaseLength;
                }
                else
                {
                    CheckIncorectFormat(romanNumber, index);
                    result += _romanArabicMap[GetStringAt(romanNumber, index++)];
                }
            }
            return result;
        }

        private void CheckIncorectFormat(string romanNumber, int index)
        {
            if (!_romanArabicMap.ContainsKey(GetStringAt(romanNumber, index))) throw new ArgumentException();
            if (index > 0 && _romanArabicMap[GetStringAt(romanNumber, index-1)] <
                _romanArabicMap[GetStringAt(romanNumber, index)])
                throw new ArgumentException();
        }

        private static string GetStringAt(string romanNumber, int index)
        {
            return romanNumber[index].ToString();
        }

        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(1000, "M")]
        [InlineData(4, "IV")]
        [InlineData(80, "LXXX")]
        [InlineData(9, "IX")]
        [InlineData(90, "XC")]
        [InlineData(666, "DCLXVI")]
        [InlineData(1999, "MCMXCIX")]
        [InlineData(3000, "MMM")]
        [InlineData(1988, "MCMLXXXVIII")]
        [InlineData(0, "")]
        public void ReturnsArabicNumberForRomanRepresentation(int arabic, String roman)
        {
            Assert.Equal(arabic, ToArabic(roman));
        }

        [Theory]
        [InlineData("P")]
        [InlineData("PM")]
        [InlineData("MCPM")]
        [InlineData("MPM")]
        [InlineData("IM")]
        [InlineData("MIM")]

        public void ReturnsExceptionForIncorrectInput(string inputString)
        {
            Assert.Throws<ArgumentException>(() => ToArabic(inputString));
        }
    }
}
