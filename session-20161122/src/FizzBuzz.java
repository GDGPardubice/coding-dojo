public class FizzBuzz {
    private final int BUZZ = 5;
    private final int FIZZ = 3;
    private final int FIZZBUZZ = 15;

    public String computeFizzBuzz(int number) {
        if (number % FIZZBUZZ == 0) {
            return "FizzBuzz";
        }

        if (number % BUZZ == 0) {
            return "Buzz";
        }

        if (number % FIZZ == 0) {
            return "Fizz";
        }

        return String.valueOf(number);
    }
}
