# MarsRover_Kata
### About this kata
- [codurance](https://www.codurance.com/katas/simple-mars-rover)
- [Coding Dojo](https://codingdojo.org/kata/mars-rover/)
- [TDD BUDDY](https://www.tddbuddy.com/katas/mars-rover.html)

### Test case
#### Rover Forward
| commands | position |
| :----: | :----: |
| M | 0:1:N |
| MMM | 0:3:N |
| MMMMMMMMMM | 0:9:N |

#### Rover Turn Right And Forward
| commands | position |
| :----: | :----: |
| R | 0:0:E |
| RR | 0:0:S |
| RRR | 0:0:W |
| RRRR | 0:0:N |
| MMMRM | 1:3:E |
| RMMMMMMMMMM | 9:0:E |

#### Rover Turn Left And Forward
| commands | position |
| :----: | :----: |
| L | 0:0:W |
| LL | 0:0:S |
| LLL | 0:0:E |
| LLLL | 0:0:N |
| MMLM | 0:2:W |

#### Rover Backward
| commands | position |
| :----: | :----: |
| MRRM | 0:0:S |
| MRRMM | 0:0:S |
| MMMRMLLLM | 1:2:S |