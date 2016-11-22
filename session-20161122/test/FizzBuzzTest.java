import org.junit.Test;

import static org.junit.Assert.*;

public class FizzBuzzTest {
    @Test
    public void returnsStringOneForNumberOne() {
        FizzBuzz fizzBuzz = new FizzBuzz();
        assertEquals("1", fizzBuzz.computeFizzBuzz(1));
    }

    @Test
    public void returnsStringTwoForNumberTwo() {
        FizzBuzz fizzBuzz = new FizzBuzz();
        assertEquals("2", fizzBuzz.computeFizzBuzz(2));
    }

    @Test
    public void returnsStringFizzForNumberThree() {
        FizzBuzz fizzBuzz = new FizzBuzz();
        assertEquals("Fizz", fizzBuzz.computeFizzBuzz(3));
    }

    @Test
    public void returnsStringBuzzForNumberFive() {
        FizzBuzz fizzBuzz = new FizzBuzz();
        assertEquals("Buzz", fizzBuzz.computeFizzBuzz(5));
    }

    @Test
    public void returnsStringFizzBuzzForNumberFifteen() {
        FizzBuzz fizzBuzz = new FizzBuzz();
        assertEquals("FizzBuzz", fizzBuzz.computeFizzBuzz(15));
    }

    @Test
    public void returnsStringFizzForNumberNine() {
        FizzBuzz fizzBuzz = new FizzBuzz();
        assertEquals("Fizz", fizzBuzz.computeFizzBuzz(9));
    }

    @Test
    public void returnsStringBuzzForNumberFifty() {
        FizzBuzz fizzBuzz = new FizzBuzz();
        assertEquals("Buzz", fizzBuzz.computeFizzBuzz(50));
    }

    @Test
    public void returnsStringFizzBuzzForNumberThirty() {
        FizzBuzz fizzBuzz = new FizzBuzz();
        assertEquals("FizzBuzz", fizzBuzz.computeFizzBuzz(30));
    }
}
