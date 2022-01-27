using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objects/Ship", fileName = "ship")]
public class Ship : ObjectData
{
   [SerializeField] private int capacity;
   [SerializeField] private int displacement;
   [SerializeField] private int lenght;

   public int Capacity{
       get{return capacity;}
       set{capacity = value;}
   }
   public int Displacement{
       get{return displacement;}
       set{displacement = value;}
   }
   public int Lenght{
       get{return lenght;}
       set{lenght = value;}
   }
   
   public string PrintFieldInfoShip(){
       return PrintFieldInfo() + $"\nВместимость: {capacity} человек\nВодоизмещение: {displacement} тонн\nДлина: {lenght} м";
   }
 
}