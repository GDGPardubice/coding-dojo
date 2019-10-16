namespace new_year

module LeapYear =
    let checkLeapYear = function
        | x when x % 400 = 0 -> true
        | x when x % 100 = 0 -> false
        | x -> x % 4 = 0