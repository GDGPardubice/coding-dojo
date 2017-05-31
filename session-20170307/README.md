# Range

## Problem Description
We have a integer range which is declared by string. We want find out lower and upper boundery and if they are opened or closed.

## Range Rules
Correct record:
```
<3;6>
(4; 8)
(2, 12>
< 3; 5>
< -3; 5)
```

## Extensions
Create range functions:

- ```[2,6)``` contains ```{2,4}```
- ```[2,6)``` doesn’t contain ```{-1,1,6,10}```
- getAllPoints 
```[2,6)``` allPoints = ```{2,3,4,5}```
- ContainsRange
```[2,5)``` doesn’t contain ```[7,10)```
- ```[2,5)``` doesn’t contain ```[3,10)```
- ```[3,5)``` doesn’t contain ```[2,10)```
- ```[2,10)``` contains ```[3,5]```
- ```[3,5]``` contains ```[3,5)```
- endPoints
```[2,6)``` allPoints = ```{2,3,4,5}```
- ```[2,6]``` allPoints = ```{2,3,4,5,6}``
- ```(2,6)``` allPoints = ```{3,4,5}```
- ```(2,6]``` allPoints = ```{3,4,5,6}```
- overlapsRange
```[2,5)``` doesn’t overlap with ```[7,10)```
- ```[2,10)``` overlaps with ```[3,5)```
- ```[3,5)``` overlaps with ```[3,5)```
- ```[2,5)``` overlaps with ```[3,10)```
- ```[3,5)``` overlaps with ```[2,10)```
- Equals
```[3,5)``` equals ```[3,5)```
- ```[2,10)``` neq ```[3,5)```
- ```[2,5)``` neq ```[3,10)```
- ```[3,5)``` neq ```[2,10)```

## References

- [codingdojo.org](http://codingdojo.org/kata/Range/)

## Session

- **Date**: 07. 03. 2017
- **Place**: Univerzita Pardubice - Fakulta Elektrotechniky a Informatiky
- **Participants**: Emil Řezanina, Vojtěch Müller, David Boucník, Tomáš Kalina
- **IDE/Language**: Visual Studio 2015/C#