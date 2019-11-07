# Mars Rover

You’re part of the team that explores Mars by sending remotely controlled vehicles to the surface of the planet. Develop an API that translates the commands sent from earth to instructions that are understood by the rover.

## Requirements

- You are given the initial starting point (x,y) of a rover and the direction (N,S,E,W) it is facing.
- The rover receives a character array of commands.
- Implement commands that move the rover forward/backward (f,b).
- Implement commands that turn the rover left/right (l,r).
- Implement wrapping from one edge of the grid to another. (planets are spheres after all)
- Implement obstacle detection before each move to a new square. If a given sequence of commands encounters an obstacle, the rover moves up to the last possible point, aborts the - sequence and reports the obstacle.

## References

- https://kata-log.rocks/mars-rover-kata

## Session

- **Date**: 5. 11. 2019
- **Place**: Univerzita Pardubice - Fakulta Elektrotechniky a Informatiky
- **Participants**: Emil Řezanina, Martin Lepeška, Tomáš Procházka, Jan Jaroš
- **IDE/Language**: Visual Studio 2019/F# + NUnit