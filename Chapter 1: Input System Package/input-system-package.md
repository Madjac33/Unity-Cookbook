# Chapter 1: Unity's Input System Package
<p>The goal of this chapter is to familiarize users with Unity's new input system, the Input System package. By the end of this chapter, readers will have built a game prototype using the Input System package.</p>

## Installation
<p>Unlike the old Input Manager, you need to install the new Input System package. On your Unity project, navigate to Window > Package Manager > Set Packages to Unity Registry > Search for Input System > <b>NOTE:</b> Installing the Input System package will disable the Input Manager > Install.</p>

![Installation](Installation.gif | width=50)

## The Player Input Component
<p>The Player Input component enables flexible input handling. In the editor, you can define actions and map them to methods in C# scripts. Navigate to the player game object > Add Component > Search for Player Input > Select Create Actions. This will create an Input Actions Editor in your project's Assets folder.</p>

![InputActions](InputActions.png)
<p>On the Input Actions Editor, you will see 3 columns. On the leftmost column is the Action Maps. An Action Map is a collection of actions that are related to each other. For example, on this pre-populated Input Actions Editor, you will see 2 Action Maps: One that handles player movement and one that handles UI navigation.</p>

## C# Scripts
<p>Ensure that the proper library is linked</p>

`using UnityEngine.Input`

## Resources
[Quickstart Guide](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.13/manual/QuickStartGuide.html)<br>
[How to use Unity's New INPUT System EASILY](https://www.youtube.com/watch?v=HmXU4dZbaMw)
