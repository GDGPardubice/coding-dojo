package dojo;

import org.junit.Test;

import java.util.Arrays;
import java.util.regex.Pattern;
import java.util.stream.IntStream;
import java.util.stream.Stream;

import static org.junit.Assert.assertEquals;

public class Dojo {

    private static final String DEFAULT_DELIMITER = "," ;
    public static final String DELIMITER_PREFIX = "//";

    private int add(String input) {
        return parseNumbers(input).sum();
    }

    private IntStream parseNumbers(String input) {
        if (input.isEmpty()) return IntStream.empty();

        String delimiter = detectDelimiter(input);
        String normalizedInput = prepareInput(input, delimiter);
        Stream<String> stringCollection = Arrays.stream(normalizedInput.split(delimiter));
        return stringCollection.mapToInt(Integer::parseInt);
    }

    private String prepareInput(String input, String delimiter) {
        if(input.startsWith(DELIMITER_PREFIX)){
            input = input.substring(4);
        }

        return input.replaceAll("\\n", delimiter);
    }

    private String detectDelimiter(String input) {
        String delimiter = DEFAULT_DELIMITER;
        if(input.startsWith(DELIMITER_PREFIX)){
            delimiter = input.substring(2, 3);
            delimiter = Pattern.quote(delimiter);
        }
        return delimiter;
    }

    private static int sum(int a, int b) {
        return a + b;
    }

    @Test
    public void forEmptyStringReturnsZero() {
        assertEquals(0, add(""));
    }

    @Test
    public void forStringOneReturnsOne() {
        assertEquals(1, add("1"));
    }

    @Test
    public void forStringTwoReturnsTwo() {
        assertEquals(2, add("2"));
    }

    @Test
      public void forStringOfNumbersReturnSum() {
        assertEquals(6, add("1,2,3"));
    }

    @Test
    public void forNewLineAsDelimiterReturnSum() {
        assertEquals(6, add("1\n2,3"));
    }

    @Test(expected = IllegalArgumentException.class)
    public void forInvalidDelimiterThrowsException() {
        assertEquals(1, add("1,\\n"));
    }

    @Test
    public void forDelimiterSemicolonReturnSum() {
        assertEquals(3, add("//;\n1;2"));
    }

    @Test
    public void forDelimiterAtReturnSum() {
        assertEquals(3, add("//@\n1@2"));
    }

    @Test
    public void supportsBackslashAsDelimiter(){
        assertEquals(3, add("//\\\n1\\2"));
    }
}
