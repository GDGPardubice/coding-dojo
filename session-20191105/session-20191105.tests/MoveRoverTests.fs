module session_20191105.tests

open NUnit.Framework
open session_20191105.mars_rover

[<Test>]
let ``Rover without path stays.`` () =
    let start = State ((0, 0), North)
    let result = moveRover start Option.None
    Assert.AreEqual(start, result)

[<Test>]
let ``North facing rover faces to West after left rotation.`` () =
    let start = State ((0, 0), North)
    let expected = State ((0, 0), West)
    let result = moveRover start (Option.Some "l")
    Assert.AreEqual(expected, result)

[<Test>]
let ``North facing rover faces to East after right rotation.`` () =
    let start = State ((0, 0), North)
    let expected = State ((0, 0), East)
    let result = moveRover start (Option.Some "r")
    Assert.AreEqual(expected, result)

[<Test>]
let ``South facing rover faces to West after right rotation.`` () =
    let start = State ((0, 0), South)
    let expected = State ((0, 0), West)
    let result = moveRover start (Option.Some "r")
    Assert.AreEqual(expected, result)