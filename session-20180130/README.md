# Roman calculator

## Problem Description
“As a Roman Bookkeeper I want to add Roman numbers because doing it manually is too tedious.” Given the Roman numerals, (IVXLCDM which means one, five, ten, fifty, hundred, fivehundred and a thousand respectively), create two numbers and add them. As we are in Rome there is no such thing as decimals or int, we need to do this with the strings. An example would be “XIV” + “LX” = “LXXIV”

## Rules description
- Numerals can be concatenated to form a larger numeral (“XX” + “II” = “XXII”)
- If a lesser numeral is put before a bigger it means subtraction of the lesser from the bigger (“IV” means four, “CM” means ninehundred)
- If the numeral is I, X or C you can’t have more than three (“II” + “II” = “IV”)
- If the numeral is V, L or D you can’t have more than one (“D” + “D” = “M”)- **High Card**: Hands which do not fit any higher category are ranked by the value of their highest card. If the highest cards have the same value, the hands are ranked by the next highest, and so on.

## References

- [CodingDojo.org](http://codingdojo.org/kata/RomanCalculator/)

## Session

- **Date**: 30. 1. 2018
- **Place**: Univerzita Pardubice - Fakulta Elektrotechniky a Informatiky
- **Participants**: Václav Pavlíček, Emil Řezanina, Vojtěch Müller, Jan Voráček, Petr Filip, Martin Lepeška
- **IDE/Language**: IntelliJ IDEA 2017/JUnit/Kotlin