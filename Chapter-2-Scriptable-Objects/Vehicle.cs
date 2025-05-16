using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Vehicle", menuName = "New Vehicle")]
public class Vehicle : ScriptableObject
{
    [SerializeField] public int speed;
    [SerializeField] public string vehicleName;
    [SerializeField] public Color color;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
