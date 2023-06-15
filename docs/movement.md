# Player Movement
Video game demo built in 2023 in the Unity Engine

## Classes
* PlayerMovement.cs
1. Contains public parameters to adjust movement speed, jump height, etc. X and Z inputs {-1,0,1} are multiplied by time since last frame. Position is altered by normalized speed vector on Update(). 
2. Y-velocity, grounded check and jumping still WIP.