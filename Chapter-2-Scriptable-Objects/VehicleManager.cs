using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VehicleManager : MonoBehaviour
{
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text speedText;
    [SerializeField] Vehicle vehicleType;
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = vehicleType.vehicleName;
        speedText.text = vehicleType.speed.ToString();
        GetComponent<MeshRenderer>().material.color = vehicleType.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
