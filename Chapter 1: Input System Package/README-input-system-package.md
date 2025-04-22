# Chapter 1: Unity's Input System Package
<p>The goal of this chapter is to familiarize users with Unity's input system, the Input System package. By the end of this chapter, readers will have built a game prototype using the Input System package.</p>

## Installation
<p>Unlike the old Input Manager, you need to install the Input System package. On your Unity project, navigate to Window > Package Manager > Set Packages to Unity Registry > Search for Input System > <b>NOTE:</b> Installing the Input System package will disable the Input Manager > Install.</p>
<img src="Images/Installation.gif" alt="Installation" width="60%">

## The Player Input Component
<p><b>NOTE:</b> You do not need to follow along with this section in order to complete the example project. The Player Input component enables flexible input handling. In the editor, you can define actions and map them to methods in C# scripts. Navigate to the player game object > Add Component > Search for Player Input > Select Create Actions. This will create an Input Actions Editor in your project's Assets folder.</p>
<img src="Images/InputActions.png" alt="InputAction" width="60%">
<p>On the Input Actions Editor, you will see 3 columns.</p>

1. On the leftmost column is the Action Maps. An Action Map is a collection of actions that are related to each other. For example, in this pre-populated Input Actions Editor, you will see 2 Action Maps: One that handles player movement and one that handles UI navigation.

2. On the middle column is the Actions. An Action represents an event (i.e. walk, run, jump, attack) that can be triggered by an input. Here, you can change the input (i.e. button, key, joystick) that is bound to an Action. The bindings of an Action depends on the type of input device used. For example, in the above image, the Fire action is bound both to the left button on a mouse and a tap on a touchscreen.

3. On the rightmost column is the Action Properties. In this panel, there are 3 sections.
    * Action: Here, you can select the Action's Action Type and Control Type. 
        * There are 3 possible Action Types: Value, Button, and PassThrough. 
            * A Value is used to pass continuous input. This is useful for things like player movement. 
            * A Button is used for discrete input. For example, the player has to press 'E' to interact with an object. 
            * A PassThrough is used to trigger a callback whenever a value is changed. This is useful when you want to process input from multiple devices without identifying a primary input device. 
        * The Control Type of an Action refers to the specific source through which the user can provide input. Unity offers a variety of Control Types included touch, integer, Vector2, Vector3, DPad, and more.
    * Interactions: An Interaction defines a specific input pattern for an Action. There are 4 types of Interactions.
        * Hold: The control must be held for a certain amount of time in order to trigger the Action
        * Press: The Action is triggered when the control is pressed and released within a specified amount of time
        * Slow Tap: The control must be held for a certain amount of time in order to trigger the Action (for touch input devices)
        * Tap: The Action is triggered as soon as the control is pressed and released within a specified amount of time (for touch input devices)
    * Processors: A Processor receives an input value and returns a modified result. There are 4 types of Processors.
        * Invert Vector 2: The received Vector2 input's X and/or Y values will be multiplied by -1
        * Normalize Vector 2: The received Vector2 input will be modified to have a magnitude of 1
        * Scale Vector 2: The received Vector2 input's components will be multiplied by a specified value
        * Stick Deadzone: Unwanted Vector2 input will be filtered out according to a designated threshold


## Tutorial
<p>I am following along with BMo's introduction to Unity's Input System package on YouTube found here (<https://www.youtube.com/watch?v=HmXU4dZbaMw>). 

First, create a new 2D Unity project. Add a game object to represent the player. 2D Object > Sprites > Square. Add a 2D Rigidbody to the player object. Make sure that gravity scale is set to 0. Add a box collider to the player object.

Create a script to handle player movement. We will call it "Movement". Then, attach the script to the game object that represents the player. In the Movement script, make sure you have the proper library linked.</p>

`using UnityEngine.InputSystem;`
<p>Then, create an InputAction object.</p>

`public InputAction playerControls;`
<p>Navigate back to the Editor. Now, you'll notice a new variable called Player Controls. Press the plus sign and select "Add Up/Down/Left/Right Composite". I will call the new set of controls "WASD" to represent keyboard controls.
<br><img src="Images/PlayerControls.png" alt="PlayerControls" width="60%"><br>
For each direction, look up and select the desired key.<br>
<img src="Images/Binding.png" alt="Binding" width="60%"><br>
In the Movement script, create a Vector2 variable to represent the movement direction. I will call it moveDirection.</p>

`Vector2 moveDirection = Vector2.zero;`
<p>The Input System package requires that the InputAction be enabled and disabled using the OnEnable and OnDisable functions. Include the following in your script.</p>

```
private void OnEnable() {
    playerControls.Enable();
}

private void OnDisable() {
    playerControls.Disable();
}
```
<p>Next, in your Update function, set the value of moveDirection from playerControls.</p>

`moveDirection = playerControls.ReadValue<Vector2>();`
<p>Finally, in FixedUpdate, calculate the Rigidbody's velocity using moveDirection and speed.</p>

`rb.velocity = new Vector2(moveDirection.x * speed * Time.deltaTime, moveDirection.y * speed * Time.deltaTime);`
<p>Now, when you navigate to the Editor and press play, you can move your character using the WASD keys! 

What if you wanted to give the player the option of using the arrow keys to move as well? What about a joystick on a controller?

Go back to the Movement script in the editor and press the plus sign next to Player Controls. Add another Up/Down/Left/Right Composite control. Follow the same steps you used to bind the WASD keys to the different directions. This time, look up and select the arrow keys to map them to the directions. Great! Now the player can move using the arrow keys.

Add another Up/Down/Left/Right Composite control. We want to allow the player to move using a controller. For each direction, select Left Stick/Direction [GamePad]. You can now move the player with the left joystick on your controller! Your Player Controls variable should look like this.
<br><img src="Images/FullPlayerControls.png" alt="FullPlayerControls" width="60%"></p>

## Resources
[Completed Movement Script](Movement.cs)<br>
[Quickstart Guide](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.13/manual/QuickStartGuide.html)<br>
[How to use Unity's New INPUT System EASILY](https://www.youtube.com/watch?v=HmXU4dZbaMw)
