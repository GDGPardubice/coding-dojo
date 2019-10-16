namespace Tests

open NUnit.Framework
open new_year.LeapYear

type TestClass () =

    [<Test>]
    member this.CheckNoLeapYearReturnFalse () =
        Assert.IsFalse (checkLeapYear 1997)

    [<Test>]
    member this.Check1996IsLeapYear () =
        Assert.IsTrue (checkLeapYear 1996)

    [<Test>]
    member this.Check1600IsLeapYear () =
        Assert.IsTrue (checkLeapYear 1600)

    [<Test>]
    member this.Check2000IsLeapYear () =
        Assert.IsTrue (checkLeapYear 2000)

    [<Test>]
    member this.Check2100IsNotLeapYear () =
        Assert.IsFalse (checkLeapYear 2100)
    
    [<Test>]
    member this.Check1800IsNotLeapYear () =
        Assert.IsFalse (checkLeapYear 1800)

    [<Test>]
    member this.Check2200IsNotLeapYear () =
        Assert.IsFalse (checkLeapYear 2200)

    [<Test>]
    member this.Check2600IsNotLeapYear () =
        Assert.IsFalse (checkLeapYear 2600)