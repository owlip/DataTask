using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowCreatePlane : MonoBehaviour
{
    [SerializeField] private InputField markInput;
    [SerializeField] private InputField massInput;
    [SerializeField] private InputField maxSpeedInput;
    [SerializeField] private InputField brandInput;
    [SerializeField] private InputField countryInput;
    [SerializeField] private InputField capacityInput;
    [SerializeField] private InputField loadCapacityInput;
    [SerializeField] private InputField typePlaneInput;
    [SerializeField] private InputField maxDistancePlaneInput;
    [SerializeField] private GameObject panel;
    [SerializeField] private DataBase database;
    

    public void SetFieldShip(){
        panel.SetActive(false);

        string mark = markInput.text;
        int mass;
        if(this.massInput.text != ""){
            mass = int.Parse(this.massInput.text);
        }
        else{
            mass = 0;
        }
        int maxSpeed;
        if(this.maxSpeedInput.text != ""){
            maxSpeed = int.Parse(this.maxSpeedInput.text);
        }
        else{
            maxSpeed = 0;
        }
        string brand = brandInput.text;
        string country = countryInput.text;
        int loadCapacity;
        if(this.loadCapacityInput.text != ""){ 
            loadCapacity = int.Parse(this.loadCapacityInput.text);
        }
        else{
            loadCapacity = 0;
        }
        int capacity;
        if(this.capacityInput.text != ""){ 
            capacity = int.Parse(this.capacityInput.text);
        }
        else{
            capacity = 0;
        }
        int maxDistance;
        if(this.maxDistancePlaneInput.text != ""){ 
            maxDistance = int.Parse(this.maxDistancePlaneInput.text);
        }
        else{
            maxDistance = 0;
        }
        string typePlane = typePlaneInput.text;
        
        database.CreateOnInputPlane(mark, mass, maxSpeed, brand, country,typePlane, capacity, loadCapacity, maxDistance);

        markInput.text="";
        massInput.text="";
        maxSpeedInput.text="";
        brandInput.text="";
        capacityInput.text="";
        countryInput.text="";
        loadCapacityInput.text="";
        maxDistancePlaneInput.text="";
        typePlaneInput.text="";
    }

    public void CancleAddPlane(){
        panel.SetActive(false);
    }
}
