package cz.upce.fei.codingdojo;

import org.junit.Assert;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;

import java.util.Arrays;
import java.util.Collection;

@RunWith(Parameterized.class)
public class WrapperTest {
    String testName;
    String inputText;
    int columnNumber;
    String expectedResult;

    public WrapperTest(String testName, String inputText, int columnNumber, String expectedResult) {
        this.testName = testName;
        this.inputText = inputText;
        this.columnNumber = columnNumber;
        this.expectedResult = expectedResult;
    }

    @Parameterized.Parameters(name= "{index}: {0}")
    public static Collection data() {
        return Arrays.asList(new Object[][]{
                {"SingleLine", "hello", 100, "hello"},
                {"TwoLine", "hello world", 6, "hello \nworld"},
                {"ThreeLine", "hello world hello again", 6, "hello \nworld \nhello \nagain"},
                }
        );
    }

    @Test
    public void parametrizedTestWrapper() {
        Assert.assertEquals(this.expectedResult, Wrapper.wrapText(this.inputText, this.columnNumber));

    }


}
