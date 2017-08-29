Laser Shooter
=============

Table of contents
=================
  * [Notes](#notes)
  * [Unity methods used](#all-methods-used)
  * [New Mechanics](#new-mechanics)
   
   
Notes
=====

- In our playerController script, it updates the players movement by adding a vector3 to the position in the Update method.
We multiple the speed float by Time.deltaTime which is the time between frame updates.  This will scale the movement to be 
dependent on the time instead of the framerate.  We don't want 60fps to make the ship move twice the speed of the ship in 
30fps, since Time.deltaTime for 60fps is 0.5x that of 30fps, it will scale the movement such that it is independent on framerate.

- In order to dynamically calculate what bounds to clamp our player position to, we use Camera.main.ViewportToWorldPoint()  method.
This method takes in a vector 3 where a values of 1f represents the maximum WorldPoint and 0f the minimum. 
e.g. (1f,0f,0f) would be the bottom right worldpoint

- To account for the size of the sprite itself, we can use (float)renderer.bounds.size

