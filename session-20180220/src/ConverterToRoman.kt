val numbers = linkedMapOf(
        1000 to "M",
        900 to "CM",
        500 to "D",
        400 to "CD",
        100 to "C",
        90 to "XC",
        50 to "L",
        40 to "XL",
        10 to "X",
        9 to "IX",
        5 to "V",
        4 to "IV",
        1 to "I"
)

fun convertToRoman(decimal: Int): String {
    var rest = decimal
    var roman = ""
    while (rest > 0) {
        val n = numbers.keys.first { it <= rest }
        rest -= n
        roman += numbers[n]
    }
    return roman
}

fun convertFromRoman(roman: String): Int {
    return if (numbers.containsValue(roman)) numbers.entries.first { it.value == roman }.key else roman.length
}