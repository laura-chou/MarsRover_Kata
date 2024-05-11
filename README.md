# MarsRover_Kata
### About this kata
- [codurance](https://www.codurance.com/katas/simple-mars-rover)
- [Coding Dojo](https://codingdojo.org/kata/mars-rover/)
- [TDD BUDDY](https://www.tddbuddy.com/katas/mars-rover.html)

### Test case
#### Go Straight
| commands | position |
| :----: | :----: |
| M | 0:1:N |
| MMM | 0:3:N |

#### Turn Right
| commands | position |
| :----: | :----: |
| R | 0:0:E |
| RR | 0:0:S |
| RRR | 0:0:W |
| RRRR | 0:0:N |
| MMMRM | 1:3:E |
| MMMMRMMM | 3:4:E |

#### Turn Left
| commands | position |
| :----: | :----: |
| L | 0:0:W |
| LL | 0:0:S |
| LLL | 0:0:E |
| LLLL | 0:0:N |
| RMMMLM | 3:1:N |
| MRMMMMLMMMML | 4:5:W |

### End Of The Grid
| commands | position |
| :----: | :----: |
| MMMMMMMMRM | 1:9:E |
| RMMMMMMMMMLM | 9:1:N |