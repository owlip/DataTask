using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName = "Objects/DB", fileName = "DB")]
public class DataBase : ScriptableObject
{
    [SerializeField] private List<Car> listCar;
    [SerializeField] private List<Ship> listShip;
    [SerializeField] private List<Plane> listPlane;
    public Car GetCar(int index){
        return listCar[index];
    }
    public Plane GetPlane(int index){
        return listPlane[index];
    }
    public Ship GetShip(int index){
        return listShip[index];
    }
    public int GetCarsCount(){
        return listCar.Count;
    }
    public int GetShipsCount(){
        return listShip.Count;
    }
    public int GetPlanesCount(){
        return listPlane.Count;
    }
    public string PrintCar(int index){
        return listCar[index].PrintFieldInfoCar();
    }
    public string PrintShip(int index){
        return listShip[index].PrintFieldInfoShip();
    }
    public string PrintPlane(int index){
        return listPlane[index].PrintFieldInfoPlane();
    }
    public void CreateCar() {
       Car newCar = ScriptableObject.CreateInstance<Car>();
       string path = "Assets/Objects/Car/car" + listCar.Count;
       AssetDatabase.CreateAsset(newCar, path + ".asset");
       AssetDatabase.SaveAssets();
       listCar.Add(newCar);
   }
   public void CreateShip() {
       Ship newShip = ScriptableObject.CreateInstance<Ship>();
       string path = "Assets/Objects/Ship/ship" + listShip.Count;
       AssetDatabase.CreateAsset(newShip, path + ".asset");
       AssetDatabase.SaveAssets();
       listShip.Add(newShip);
   }
   public void CreatePlane() {
       Plane newPlane = ScriptableObject.CreateInstance<Plane>();
       string path = "Assets/Objects/Plane/plane" + listPlane.Count;
       AssetDatabase.CreateAsset(newPlane, path + ".asset");
       AssetDatabase.SaveAssets();
       listPlane.Add(newPlane);
   }
   public void ClearDatabase(){
       for(int i=0; i < listCar.Count;i++){
           AssetDatabase.DeleteAsset("Assets/Objects/Car/car" + i + ".asset");
       }
       for(int i=0; i < listShip.Count;i++){
           AssetDatabase.DeleteAsset("Assets/Objects/Ship/ship" + i + ".asset");
       }
       for(int i=0; i < listPlane.Count;i++){
           AssetDatabase.DeleteAsset("Assets/Objects/Plane/plane" + i + ".asset");
       }
       listCar.Clear();
       listShip.Clear();
       listPlane.Clear();
   }

    public void CreateOnInputCar(string mark, int mass, int maxSpeed, string brand, string country,
        string classAuto, string colour, string driveUnit, float valueEngine) {
       
       Car newCar = ScriptableObject.CreateInstance<Car>();

       newCar.Mark = mark;
       newCar.Mass = mass;
       newCar.MaxSpeed = maxSpeed;
       newCar.Brand =  brand;
       newCar.Country = country;
       newCar.ClassAuto = classAuto;
       newCar.Colour = colour;
       newCar.DriveUnit = driveUnit;
       newCar.Value = valueEngine;

       string path = "Assets/Objects/Car/car" + listCar.Count;
       AssetDatabase.CreateAsset(newCar, path + ".asset");
       AssetDatabase.SaveAssets();
       listCar.Add(newCar);
   }

   public void CreateOnInputShip(string mark, int mass, int maxSpeed, string brand, string country,
        int capacity, int displacement, int lenght) {
       
       Ship newShip = ScriptableObject.CreateInstance<Ship>();

       newShip.Mark = mark;
       newShip.Mass = mass;
       newShip.MaxSpeed = maxSpeed;
       newShip.Brand =  brand;
       newShip.Country = country;
       newShip.Capacity = capacity;
       newShip.Displacement = displacement;
       newShip.Lenght = lenght;

       string path = "Assets/Objects/Ship/ship" + listShip.Count;
       AssetDatabase.CreateAsset(newShip, path + ".asset");
       AssetDatabase.SaveAssets();
       listShip.Add(newShip);
   }

   public void CreateOnInputPlane(string mark, int mass, int maxSpeed, string brand, string country,
        string typePlane, int capacity, int loadCapacity, int maxDistance) {
       
       Plane newPlane = ScriptableObject.CreateInstance<Plane>();

       newPlane.Mark = mark;
       newPlane.Mass = mass;
       newPlane.MaxSpeed = maxSpeed;
       newPlane.Brand =  brand;
       newPlane.Country = country;
       newPlane.TypePlane = typePlane;
       newPlane.Capacity = capacity;
       newPlane.LoadCapacity = loadCapacity;
       newPlane.MaxDistance = maxDistance;

       string path = "Assets/Objects/Plane/plane" + listPlane.Count;
       AssetDatabase.CreateAsset(newPlane, path + ".asset");
       AssetDatabase.SaveAssets();
       listPlane.Add(newPlane);
   }
}
