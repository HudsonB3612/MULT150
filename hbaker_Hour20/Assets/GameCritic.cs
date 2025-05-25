/*
 
1. Is the game too easy or hard? Give 2 unique reasons why it is easy or hard.
- 1: The game is too easy because the spawn pattern is predictable because of it always alternating between a power up and a obstacle.
- 2: The penalty for mistakes is very low. Hitting an obstacle only slows the world by 50% for 1 second, which is a small inconvenience.

2. What 2 changes would you do to make it easier or harder?
- 1: I would randomize the spawning logic to make it less predictable
- 2: I would increase the 'phaseCooldown' variable in the Player script from 2 seconds to 4 seconds to make phasing more time consuming.

3. List 2 things that would give it a "wow" factor.
- 1: The stretching of the power up particle effects
- 2: The automatic scrolling of the ground texture that simulate it moving, even though you are not actually moving at all.

4. What 2 parts of the game are fun?
- 1: The main gameplay loop of strafing left and right to dodge obstacles is simple but nice
- 2: Using the 'phase' ability at the last possible second to pass a obstacle.

5. What 2 parts of the game are tedious?
- 1: Manually linking all the object references in the Inspector
- 2: The gameplay becomes repetitive after a short time

Changes:
- I make the obstacle constantly rotate which makes it harder for the player to dodge due to the spinning corners.
- I redesigned the particle effect to be a swirling blue effect which fades and shrinks over time while orbiting around the Y axis.

*/