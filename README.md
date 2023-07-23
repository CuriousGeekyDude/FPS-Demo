# FPS-Demo

## About
This is a simple demo of an FPS game inspired by the Doom game.

### Implementation
#### AI enemies
There are 2 AI enemies that are moving randomly about. As you can see in the following 2 images, one of them is moving above the ground and the other is on the ground: 


![First](https://github.com/CuriousGeekyDude/FPS-Game/assets/130616138/f4523bfb-03ef-48e4-9ed6-caee5db0db50)


![Second](https://github.com/CuriousGeekyDude/FPS-Game/assets/130616138/014d0f4d-4687-42d9-a499-07a10a43bbb8)


The one that is on the ground is using sphere ray-casting as a way to avoid collision with walls. The one above the ground is limited by the perimeter of a circle that is defined in such a way so that the AI stays within the limits of our view and of course the area of the scene. We can shoot spheres at these enemies. The moment one of them is shot with a sphere, they are destroyed and a new one is respawned. 

#### UI
Instead of using the immediate mode for our GUI, we are using Unity UI. On the top right corner you can see the 'gear' symbol which represents our setting. On the top left corner you can see a cube image with a number next to it. That is used to tell us how many enemies are still in the scene. On the bottom right corner you can see text that says "score: ". That is used to indicate how many enemies we have destroyed since the start of the game.

When one does click on the setting, a pop up window appears on the screen. There is a close button, which is used to make the pop up disappear. There is a text field which you can use to enter your name. Finally, there is the slider that is used to adjust the speed of the AI enemies in the scene. The following image shows the UI elements in the game: 

![Third](https://github.com/CuriousGeekyDude/FPS-Game/assets/130616138/7a6c2c3a-ed42-4dc5-8770-acd6fb4c69e6)

