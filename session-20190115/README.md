# Tennis

## About this Kata
This Kata is about implementing a simple tennis game. I came up with it while thinking about Wii tennis, where they have simplified tennis, so each set is one game.

The scoring system is rather simple:

- Each player can have either of these points in one game 0 15 30 40

- If you have 40 and you win the ball you win the game, however there are special rules.

- If both have 40 the players are deuce. a. If the game is in deuce, the winner of a ball will have advantage and game ball. b. If the player with advantage wins the ball he wins the game c. If the player without advantage wins they are back at deuce.

## Alternate description of the rules per Wikipedia ( http://en.wikipedia.org/wiki/Tennis#Scoring ):

- A game is won by the first player to have won at least four points in total and at least two points more than the opponent.

- The running score of each game is described in a manner peculiar to tennis: scores from zero to three points are described as “love”, “fifteen”, “thirty”, and “forty” respectively.

- If at least three points have been scored by each player, and the scores are equal, the score is “deuce”.

- If at least three points have been scored by each side and a player has one more point than his opponent, the score of the game is “advantage” for the player in the lead.

##Example solutions

- http://github.com/follesoe/TennisKataJava Example solution in Java from Trondheim Coding Dojo
- http://github.com/goeran/Katas/tree/master/Tennis/csharp/2ndTry/ Example solution in .NET
- https://github.com/lroal/Roald/tree/master/src/Roald.Katas Example solution in .NET with state transition tree
- https://github.com/keithn/vsvimguide/blob/master/Examples/Kata.Tennis/TennisScoring.cs Simple one file example in C# .NET Core


## References

- [codingdojo.org](http://codingdojo.org/kata/Tennis/)

## Session

- **Date**: 15. 1. 2019
- **Place**: Univerzita Pardubice - Fakulta Elektrotechniky a Informatiky
- **Participants**: Václav Pavlíček, Emil Řezanina, Jan Voráček, Petr Filip, Tomáš Kalina, Jan Jaroš
- **IDE/Language**: Visual Studio Code/Clojure