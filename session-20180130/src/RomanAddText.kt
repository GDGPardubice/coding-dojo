import org.junit.jupiter.api.Assertions.*
import org.junit.jupiter.api.Test

class RomanAddTest {
    @Test
    fun oneAddOneIsTwo() {
        assertEquals("II", add("I", "I"))
    }

    @Test
    fun oneAddTwoIsThree() {
        assertEquals("III", add("II", "I"))
    }

    @Test
    fun oneAddThreeIsFour() {
        assertEquals("IV", add("I", "III"))
    }

    @Test
    fun twoAddTwoIsFour() {
        assertEquals("IV", add("II", "II"))
    }

    @Test
    fun threeAndOneIsFour() {
        assertEquals("IV", add("III", "I"))
    }

    @Test
    fun threeAndTwoIsFive() {
        assertEquals("V", add("III", "II"))
    }

    @Test
    fun twoAndThreeIsFive() {
        assertEquals("V", add("II", "III"))
    }

    @Test
    fun fiveAndOneIsSix() {
        assertEquals("VI", add("V", "I"))
    }

    @Test
    fun oneAndFiveIsSix() {
        assertEquals("VI", add("I", "V"))
    }

    @Test
    fun twoAndFourIsSix() {
        assertEquals("VI", add("II", "IV"))
    }

    @Test
    fun fourAndThreeIsSix() {
        assertEquals("VI", add("IV", "II"))
    }

}