using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   
public class ObjectData : ScriptableObject{

   [SerializeField] protected string mark;

   [SerializeField] protected int mass;

   [SerializeField] protected int maxSpeed;

   [SerializeField] protected string type;

   [SerializeField] protected string brand;

   [SerializeField] protected string country;

   public string Mark{
       get{return mark;}
       set{mark = value;}
   }
   public int Mass{
       get{return mass;}
       set{mass = value;}
   }
   public int MaxSpeed{
       get{return maxSpeed;}
       set{maxSpeed = value;}
   }
   public string Brand{
       get{return brand;}
       set{brand = value;}
   }
   public string Country{
       get{return country;}
       set{country = value;}
   }

   protected string PrintFieldInfo(){
       return $"Масса: {mass} кг\nMаксимальная скорость: {maxSpeed} км/ч\nМарка: {brand}\nСтрана: {country}";
   }
   
}