using System.Runtime.Remoting.Messaging;
using System.Text;

namespace session_20171114
{
    public class FizzBuzzSolution
    {
        public const string FIZZ = "Fizz";
        public const string BUZZ = "Buzz";

        public static string FizzBuzz(int number)
        {
            StringBuilder result = new StringBuilder();

            if (number % 3 == 0)
                result.Append(FIZZ);
            if (number % 5 == 0)
                result.Append(BUZZ);
            if (result.Length == 0)
                result.Append(number);

            return result.ToString();
        }
    }
}
