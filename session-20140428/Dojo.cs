using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Extensions;

namespace CodingDojo.Tests
{
    public class Dojo
    {
        private int Add(string input)
        {
            if (String.IsNullOrEmpty(input))
                return 0;

            var separator = ParseSeparator(input);
            var cleanInput = PrepareInput(separator, input);
            var numbers = ParseNumbers(separator, cleanInput);
            return numbers.Sum();
        }

        private string PrepareInput(char separator, string input)
        {
            var p = input.StartsWith("//") ? input.Substring(4) : input;
            return p.Replace('\n', separator);
        }

        private IEnumerable<int> ParseNumbers(char separator, string input)
        {
            try
            {
                return input.Split(separator)
                    .Select(number => Convert.ToInt32(number)).ToList();
            }
            catch (Exception exception)
            {
                throw new ArgumentException("Invalid input", "input", exception);
            }
        }

        private char ParseSeparator(string input)
        {
            return input.StartsWith("//") ?
                Convert.ToChar(input.Substring(2, 1)) : ',';
        }

        [Theory]
        [InlineData(0, "")]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "1,2")]
        [InlineData(4, "1,3")]
        [InlineData(6, "1\n2,3")]
        [InlineData(3, "//;\n1;2")]
        [InlineData(3, "//@\n1@2")]
        public void GivenNumberStringShouldReturnNumber(int expected, string input)
        {
            var result = Add(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ThrowsExceptionWhenIncorrectInput()
        {
            const string input = "1,\n";
            Assert.Throws<ArgumentException>(() => Add(input));
        }
    }
}