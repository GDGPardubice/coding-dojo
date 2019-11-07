namespace session_20191105



module mars_rover =
    type Position = int * int
    type Direction =
        | North
        | South
        | East
        | West
    type State = Position * Direction

    let leftRotation (direction : Direction) =
        match direction with
        | North -> West
        | South -> East
        | East -> North
        | West -> South

    let rightRotation (direction : Direction) =
        match direction with
        | North -> East
        | South -> West
        | East -> South
        | West -> North

    let rotate (direction : Direction) (command : string) =
        match command with
        | "l" -> leftRotation direction
        | "r" -> rightRotation direction
        | _ -> direction

    let moveRover (start : State) (path : string Option) : State = 
        match path with
        | Some path -> fst start, rotate (snd start) path
        | None -> start    
    
