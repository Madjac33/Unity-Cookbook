# Chapter 2: ScriptableObjects
The goal of this chapter is to provide users with use cases for ScriptableObjects. It also aims to familiarize users with their creation and management. At the end of this chapter, users will have built a demo using a ScriptableObject. 

## Why ScriptableObjects?
A ScriptableObject is a data container that exists independently from game objects. This means that you can edit its properties without it being tied to a game object in your working scene. You can think of a ScriptableObject as a template. You can use this template to create individual instances that have their own specific objects. For example, consider a Vehicle ScriptableObject. You can make different instances of it that represent specific types of vehicles: Truck, Car, Boat, Plane, etc. This is useful for large projects or if you have plans to expand your game in the future. 

## Potential Use Cases
Below are some features and scenarios that would benefit from the use of ScriptableObjects. Note that this is not a cumulative list. Rather, it is intended to give readers a solid foundation for using ScriptableObjects in their own projects. Hopefully, it will inspire ideas for new mechanics as well. Credit to @leo23230 for the following ideas: 
* Inventory systems
* Weapons systems
* Character management
* Crafting recipes
* Card games

## Tutorial
### Creating the ScriptableObject
1. Create a C# script in your Assets folder. For this tutorial, I will name the script "Vehicle". 
2. Edit the script so it inherits from the ScriptableObject class instead of MonoBehavior.
`public class Vehicle : ScriptableObject`
3. Before the class definition, add a CreateAssetMenu attribute. This will allow you to create a new instance of your ScriptableObject from the Assets menu. The fileName attribute 
```
[CreateAssetMenu(fileName = "Vehicle", menuName = "New Vehicle")]
public class Vehicle : ScriptableObject {}
```

## Resources
[ScriptableObject Unity Documentation](https://docs.unity3d.com/ScriptReference/ScriptableObject.html)