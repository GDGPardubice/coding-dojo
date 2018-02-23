import org.junit.jupiter.api.Assertions.assertEquals
import org.junit.jupiter.api.Test

class ConverterToRomanTest {

    @Test
    fun converts1ToI() {
        assertEquals("I", convertToRoman(1))
    }

    @Test
    fun converts2ToII() {
        assertEquals("II", convertToRoman(2))
    }

    @Test
    fun converts3ToIII() {
        assertEquals("III", convertToRoman(3))
    }

    @Test
    fun converts4ToIV() {
        assertEquals("IV", convertToRoman(4))
    }

    @Test
    fun converts5ToV() {
        assertEquals("V", convertToRoman(5))
    }

    @Test
    fun converts6ToVI() {
        assertEquals("VI", convertToRoman(6))
    }

    @Test
    fun converts7ToVII() {
        assertEquals("VII", convertToRoman(7))
    }

    @Test
    fun converts8ToVIII() {
        assertEquals("VIII", convertToRoman(8))
    }

    @Test
    fun converts9ToIX() {
        assertEquals("IX", convertToRoman(9))
    }

    @Test
    fun converts10ToX() {
        assertEquals("X", convertToRoman(10))
    }

    @Test
    fun converts11ToXI() {
        assertEquals("XI", convertToRoman(11))
    }

    @Test
    fun converts12ToXII() {
        assertEquals("XII", convertToRoman(12))
    }

    @Test
    fun converts13ToXIII() {
        assertEquals("XIII", convertToRoman(13))
    }

    @Test
    fun converts14ToXIV() {
        assertEquals("XIV", convertToRoman(14))
    }

    @Test
    fun converts15ToXV() {
        assertEquals("XV", convertToRoman(15))
    }

    @Test
    fun converts18ToXVIII() {
        assertEquals("XVIII", convertToRoman(18))
    }

    @Test
    fun converts25ToXXV() {
        assertEquals("XXV", convertToRoman(25))
    }

    @Test
    fun converts39ToXXXIX() {
        assertEquals("XXXIX", convertToRoman(39))
    }

    @Test
    fun converts40ToXL() {
        assertEquals("XL", convertToRoman(40))
    }

    @Test
    fun converts49ToXLIX() {
        assertEquals("XLIX", convertToRoman(49))
    }

    @Test
    fun converts50ToL() {
        assertEquals("L", convertToRoman(50))
    }

    @Test
    fun converts51ToLI() {
        assertEquals("LI", convertToRoman(51))
    }

    @Test
    fun converts99ToXCIX() {
        assertEquals("XCIX", convertToRoman(99))
    }

    @Test
    fun converts400ToCD() {
        assertEquals("CD", convertToRoman(400))
    }

    @Test
    fun converts500ToD() {
        assertEquals("D", convertToRoman(500))
    }


    @Test
    fun converts901ToCMI() {
        assertEquals("CMI", convertToRoman(901))
    }

    @Test
    fun converts1257ToMCCLVII() {
        assertEquals("MCCLVII", convertToRoman(1257))
    }

    @Test
    fun convertsITo1() {
        assertEquals(1, convertFromRoman("I"))
    }

    @Test
    fun convertsIITo2() {
        assertEquals(2, convertFromRoman("II"))
    }

    @Test
    fun convertsIIITo3() {
        assertEquals(3, convertFromRoman("III"))
    }

    @Test
    fun convertsIVTo4() {
        assertEquals(4, convertFromRoman("IV"))
    }

    @Test
    fun convertsVTo5() {
        assertEquals(5, convertFromRoman("V"))
    }
}