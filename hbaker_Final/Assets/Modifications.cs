/*

- Made the obstacle constantly rotate
- Redesigned the particle effect to be a swirling blue effect which fades and shrinks over time while orbiting around the Y axis
- Created a red directional light
- Change texture scrolling speed from 0.5 to 10
- Changed floor texture to wood planks
- Added white fog with 0.05 density
- Changed sky to Cloud Mat as a Skybox/Panoramic shader
- Changed sky exposure to 1.05

- Replaced obstacle with pyramid obstacle
    - Created a dark red non-emissive material for the base
    - Created a dark red emissive material for the middle
    - created a red emissive material for the top

- added particle system to obstacle:
    - Set start lifetime to 1
    - Set Start Color to red
    - Enabled Color over lifetime to increase alpha over lifetime which makes it transparent over time
    - Enabled Size over lifetime to shrink linearly over time

- modified power up light to have a range of 5 and an intensity of 2

- Created a Wall Variant prefab
- Created a new material for the yelow wall / wall variant

 */