
Brick Breaker
=============
Section 5 of "Learn To Code By Making Games" Unity course. In the case I forget everything, here are some notes on what I thought
were the key takeaways in this section.  I may also build on top of project with some new stuff just for fun.

Table of contents
=================
  * [Notes](#notes)
    * [Statics](#statics)
    * [Game units](#game-units)
    * [Level build order](#level-build-order)
    * [Collider table](#collider-table)
    * [Tags](#tags)
    * [Physics Settings](#physics-settings)
    * [this vs gameObject](#this-vs-gameobject)
    * [Instantiating GameObjects](#instantiating-gameobjects)
  * [Unity methods used](#all-methods-used)
  * [New Mechanics](#new-mechanics)
   
   
Notes
=====

### Statics
Statics are variables that are not specific to an instance of a class, they are shared throughout the whole class.
Methods do not need the static keyword in order to modify them.  

Statics can be accessed in other classes simply by calling <class_name>.<static_name>

In this project we used statics in order to detect the win condition of our game and also for the singleton pattern that 
was necessary for our music player.

### Game Units
Game Units or World units is what the x and y units are measured in the inspector.

For our brick breaker game, we wanted the play space to be a total of 16 game units wide.
Knowing this we took the width in pixels of our background image (800px) and divided it by 16 to get 50 pixels per unit.
By checking the transform of the background image using our cameras position as reference, we saw that our bg was 16 units wide.

### Level Build Order
File -> Build Settings allows you to drag different scenes to the project.
If you don't build the project with these scenes you won't be able to access those scenes in the level manager.
The order of the levels matter, it will always start at the first level.  Furthermore if you are planning to use
Application.LoadLevel(index) you can just set index to Application.loadedLevel + 1 to go to the next level in the build settings.

### Collider Table
There are different types of colliders and an interaction between two of these will result in nothing, collision or a trigger.

What do the colliders types mean?

Static Collider: It has a collider but no rigidbody. They are stationary since other rigidbodies will not move it. The physics engine
can also make optimizations based on the assumption that they never move.

Rigidbody Collider: A GameObject with collider and normal rigidbody attached. Fully simulated by physics engine and can react to collisions
and forces applied from a script.

Kinematic Rigidbody Collider: Collider with rigidbody attached and kinematic checked. Can only be moved from script, dont behave as physics objects.

[Colliders Documentation](https://docs.unity3d.com/Manual/CollidersOverview.html)

Collider table:
![Image](collider_table.png? = 800x300)

### Tags
We assigned tags to certain bricks to be breakable or unbreakable. The tag is a property of this (this.tag) and has a string value.

### Physics Settings
Edit -> Project Settings -> Physics 2D is where you can change the behavior of the physics in the game instead of having to apply
certain physics settings to every object in the game

### this vs gameObject
Firstly, MonoBehaviour is the base class from which every Unity script derives. this means the current script where gameObject is 
a field in the MonoBehaviour class.  gameObject means the GameObject where the script it attached and multiple scripts can be attached to 
the same GameObject.  

Ex: Destroy(this) will destroy the attached script while Destroy(gameObject) makes the whole object disappear from the hierarchy.

### Instantiating GameObjects
To instantiate a GameObject we used the method Instantiate(GameObject, transform, Quaternion.identity) as GameObject

Unity Methods Used
==================

New Mechanics
=============
