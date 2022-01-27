using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowCreateShip : MonoBehaviour
{
    [SerializeField] private InputField markInput;
    [SerializeField] private InputField massInput;
    [SerializeField] private InputField maxSpeedInput;
    [SerializeField] private InputField brandInput;
    [SerializeField] private InputField countryInput;
    [SerializeField] private InputField capacityInput;
    [SerializeField] private InputField displacementInput;
    [SerializeField] private InputField lenghtInput;
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
        int displacement;
        if(this.displacementInput.text != ""){ 
            displacement = int.Parse(this.displacementInput.text);
        }
        else{
            displacement = 0;
        }
        int capacity;
        if(this.capacityInput.text != ""){ 
            capacity = int.Parse(this.capacityInput.text);
        }
        else{
            capacity = 0;
        }
        int lenght;
        if(this.lenghtInput.text != ""){ 
            lenght = int.Parse(this.lenghtInput.text);
        }
        else{
            lenght = 0;
        }
        
        database.CreateOnInputShip(mark, mass, maxSpeed, brand, country, capacity, displacement, lenght);

        markInput.text="";
        massInput.text="";
        maxSpeedInput.text="";
        brandInput.text="";
        capacityInput.text="";
        countryInput.text="";
        lenghtInput.text="";
        displacementInput.text="";
    }

    public void CancleAddShip(){
        panel.SetActive(false);
    }
}
