using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objects/Plane", fileName = "plane")]
public class Plane : ObjectData
{
   [SerializeField] private string typePlane;
   [SerializeField] private int loadCapacity;
   [SerializeField] private int capacity;
   [SerializeField] private int maxDistance;

   public int Capacity{
       get{return capacity;}
       set{capacity = value;}
   }
   public string TypePlane{
       get{return typePlane;}
       set{typePlane = value;}
   }
   public int LoadCapacity{
       get{return loadCapacity;}
       set{loadCapacity = value;}
   }
   public int MaxDistance{
       get{return maxDistance;}
       set{maxDistance = value;}
   }

   public string PrintFieldInfoPlane(){
       return PrintFieldInfo() + $"\nВместимость: {capacity} человек\nГрузоподъемность: {loadCapacity}\nТип самолета: {typePlane}\nМаксимальная дистанция полета: {maxDistance} км";
   } 
}