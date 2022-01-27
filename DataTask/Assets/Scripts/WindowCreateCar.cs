using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WindowCreateCar : MonoBehaviour
{
    [SerializeField] private InputField markInput;
    [SerializeField] private InputField massInput;
    [SerializeField] private InputField maxSpeedInput;
    [SerializeField] private InputField brandInput;
    [SerializeField] private InputField countryInput;
    [SerializeField] private InputField colourInput;
    [SerializeField] private InputField classAutoInput;
    [SerializeField] private InputField driveUnitInput;
    [SerializeField] private InputField valueInput;
    [SerializeField] private GameObject panel;
    [SerializeField] private DataBase database;
    

    public void SetFieldCar(){
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
        string colour = colourInput.text;
        string classAuto = classAutoInput.text;
        string driveUnit = driveUnitInput.text;
        float value;
        if(this.valueInput.text != ""){ 
            value = float.Parse(this.valueInput.text);
        }
        else{
            value = 0;
        }
        database.CreateOnInputCar(mark, mass, maxSpeed, brand, country, colour, classAuto, driveUnit, value);

        markInput.text="";
        massInput.text="";
        maxSpeedInput.text="";
        brandInput.text="";
        colourInput.text="";
        countryInput.text="";
        classAutoInput.text="";
        driveUnitInput.text="";
        valueInput.text="";
    }

    public void CancleAddCar(){
        panel.SetActive(false);
    }
}
