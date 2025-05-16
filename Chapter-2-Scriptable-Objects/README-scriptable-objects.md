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
1. Create a C# script in your Assets folder. For this tutorial, we will name the script "Vehicle". 
2. Edit the script so it inherits from the ScriptableObject class instead of MonoBehavior.<br>
`public class Vehicle : ScriptableObject`
3. Before the class definition, add a CreateAssetMenu attribute. This will allow you to create a new instance of your ScriptableObject from the Assets menu. The menuName attribute is how the option will appear on the creation menu. The fileName attribute is the default name of the Asset you create.
    ```
    [CreateAssetMenu(fileName = "Vehicle", menuName = "New Vehicle")]
    public class Vehicle : ScriptableObject {}
    ```
### Creating MetaData for the Vehicle ScriptableObject
4. For this tutorial, we want to store information about each vehicle's speed, name, and color. On the Vehicle ScriptableObject, create 3 variables to represent these attributes. 
    ```
    [SerializeField] int speed;
    [SerializeField] string vehicleName;
    [SerializeField] Color color;
    ```
### Creating Individual Vehicles
5. Create an instance of the Vehicle ScriptableObject. Navigate to Assets > Create > New Vehicle. We will call this asset "Car".
6. Select a speed, name, and color for the new Vehicle. 
7. In the scene, add a game object to represent a vehicle.
8. Add two text mesh pro objects as children of the Vehicle game object. Name one "NameText" and the other "SpeedText". These two objects will represent the name of the vehicle and the speed of the vehicle, respectively. 
9. Create a new C# script. We will call it "VehicleManager". Attach this script to the car game object.
10. In the VehicleManager script, we want to have multiple references. Ensure that you have the TMPro library linked.
    * A reference to NameText
    * A reference to SpeedText
    * A reference to a Vehicle ScriptableObject
    ```
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text speedText;
    [SerializeField] Vehicle vehicleType;
    ```
11. In the Start method of the VehicleManager script, set nameText.text to vehicleType.vehicleName, set speedText.text to vehicleType.speed.ToString(), and set the color of the game object's material to vehicleType.Color.
    ```
    void Start()
    {
        nameText.text = vehicleType.vehicleName;
        speedText.text = vehicleType.speed.ToString();
        GetComponent<MeshRenderer>().material.color = vehicleType.color;
    }
    ```
12. In the editor, with the Vehicle game object selected, drag the NameText and SpeedText objects into their respective fields.
13. Then, convert the Vehicle into a prefab by dragging it into the Assets folder. 
14. Drag the Car ScriptableObject you created earlier into the vehicleType slot on the Vehicle prefab in the scene. Now, when you press play, the prefab will reflect the information you entered for the Car ScriptableObject. Great job!
15. Create another Vehicle ScriptableObject. This time, call it "Truck". Enter its name, speed, and color.
16. Add another Vehicle prefab to the scene. This time, drag the Truck ScriptableObject into the vehicleType slot. Now, you have created 2 different vehicles without having to make different scripts!
17. Repeat steps 15 and 16 to make any vehicle you want. Have fun!

## Resources
[ScriptableObject Unity Documentation](https://docs.unity3d.com/ScriptReference/ScriptableObject.html)
[Better Data with Scriptable Objects in Unity! (Tutorial)](https://www.youtube.com/watch?v=PVOVIxNxxeQ)