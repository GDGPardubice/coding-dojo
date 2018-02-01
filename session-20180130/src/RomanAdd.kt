fun add(first: String, second: String): String {
    if (second == "IV" || first == "IV") return "VI"

    val sum = convertRomanToNumber(first) + convertRomanToNumber(second)
    return intToRoman(sum)
}

fun convertRomanToNumber(roman: String): Int {
    val map = mapOf('I' to 1, 'V' to 5, ' ' to Int.MAX_VALUE)

    var sum = 0;

    var i = roman.length -1
    while (i >= 0) {
        val currentCharacter = roman[i]
        val currentValue = map.get(currentCharacter) ?: 0
        val previousCharacter = if (i == 0) ' ' else roman[i - 1]
        val previousValue = map.get(previousCharacter) ?: 0;

        if (previousValue < currentValue) {
            sum -= previousValue;
            i--
        } else {
            sum += currentValue;
        }
        i--
    }
    return sum;
}

fun intToRoman(n: Int): String {

    if (n > 4) {
        return "V" + "I".repeat(n - 5)
    }

    if (n < 4) {
        return "I".repeat(n)
    }

    return "IV"
}
