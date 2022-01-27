using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objects/Car", fileName = "car")]
public class Car : ObjectData
{
   [SerializeField] private string classAuto;

   [SerializeField] private string colour;
   
   [SerializeField] private string driveUnit;
   
   [SerializeField] private float valueEngine;
    
    public string ClassAuto{
       get{return classAuto;}
       set{classAuto = value;}
    }
    public string Colour{
       get{return colour;}
       set{colour = value;}
   }
   public string DriveUnit{
       get{return driveUnit;}
       set{driveUnit = value;}
   }
   public float Value{
       get{return valueEngine;}
       set{valueEngine = value;}
   }
   public string PrintFieldInfoCar(){
       return PrintFieldInfo() + $"\nОбъем ДВС: {valueEngine} л\nКласс: {classAuto}\nЦвет: {colour}\nПривод: {driveUnit}";
   }

}
