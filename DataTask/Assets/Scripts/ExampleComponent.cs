using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleComponent : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private ListView listView;
    [SerializeField] private GameObject prefabElement;
    [SerializeField] private List<Sprite> imageElement;
    [SerializeField] private DataBase dataBase;

    private static int currentCountCar;
    private static int currentCountShip;
    private static int currentCountPlane;
    [SerializeField] private List<GameObject> listObjectCar;
    [SerializeField] private List<GameObject> listObjectShip;
    [SerializeField] private List<GameObject> listObjectPlane;
    
    private void Awake(){
       
       currentCountCar  = dataBase.GetCarsCount();
       for(int i= 0; i< dataBase.GetCarsCount();i++){

            GameObject element = this.listView.Add(this.prefabElement);
            ListElement elementMeta = element.GetComponent<ListElement>();
    
            elementMeta.SetTitle(dataBase.GetCar(i).Mark);
            elementMeta.SetImage(this.imageElement[0]);
            elementMeta.SetDescription(dataBase.PrintCar(i));  

            listObjectCar.Add(element);
       }
       
       currentCountShip  = dataBase.GetShipsCount();
       for(int i= 0; i<dataBase.GetShipsCount();i++){
     
            GameObject element = this.listView.Add(this.prefabElement);
            ListElement elementMeta = element.GetComponent<ListElement>();
    
            elementMeta.SetTitle(dataBase.GetShip(i).Mark);
            elementMeta.SetImage(this.imageElement[2]);
            elementMeta.SetDescription(dataBase.PrintShip(i));  

            listObjectShip.Add(element);  
       }

       currentCountPlane  = dataBase.GetPlanesCount();
       for(int i= 0; i<dataBase.GetPlanesCount();i++){
           
            GameObject element = this.listView.Add(this.prefabElement);
            ListElement elementMeta = element.GetComponent<ListElement>();
    
            elementMeta.SetTitle(dataBase.GetPlane(i).Mark);
            elementMeta.SetImage(this.imageElement[1]);
            elementMeta.SetDescription(dataBase.PrintPlane(i));     

            listObjectPlane.Add(element); 
       }   
    }

     private void Update() {
          if(currentCountCar < dataBase.GetCarsCount()){
               AddVisionCar();
          }
          if(currentCountShip < dataBase.GetShipsCount()){
               AddVisionShip();
          }
          if(currentCountPlane < dataBase.GetPlanesCount()){
               AddVisionPlane();
          }
     }
     public void AddVisionCar(){    
          GameObject element = this.listView.Add(this.prefabElement);

          ListElement elementMeta = element.GetComponent<ListElement>();
    
          elementMeta.SetTitle(dataBase.GetCar(currentCountCar).Mark);
          elementMeta.SetImage(this.imageElement[0]);
          elementMeta.SetDescription(dataBase.PrintCar(currentCountCar));
          currentCountCar++;
          listObjectCar.Add(element);  
     }
     public void AddVisionShip(){    
          GameObject element = this.listView.Add(this.prefabElement);

          ListElement elementMeta = element.GetComponent<ListElement>();
    
          elementMeta.SetTitle(dataBase.GetShip(currentCountShip).Mark);
          elementMeta.SetImage(this.imageElement[2]);
          elementMeta.SetDescription(dataBase.PrintShip(currentCountShip));
          currentCountShip++;
          listObjectShip.Add(element);  
     }
     public void AddVisionPlane(){    
          GameObject element = this.listView.Add(this.prefabElement);

          ListElement elementMeta = element.GetComponent<ListElement>();
    
          elementMeta.SetTitle(dataBase.GetPlane(currentCountPlane).Mark);
          elementMeta.SetImage(this.imageElement[1]);
          elementMeta.SetDescription(dataBase.PrintPlane(currentCountPlane));
          currentCountPlane++;
          listObjectPlane.Add(element);  
     }

     public void UpdateDatabase(){
          
          DeleteAllElement();
          currentCountCar = 0;
          currentCountShip = 0;
          currentCountPlane = 0;
          
          for(int i= 0; i<dataBase.GetCarsCount();i++){
           
            GameObject element = this.listView.Add(this.prefabElement);

            ListElement elementMeta = element.GetComponent<ListElement>();
    
            elementMeta.SetTitle(dataBase.GetCar(i).Mark);
            elementMeta.SetImage(this.imageElement[0]);
            elementMeta.SetDescription(dataBase.PrintCar(i));
            listObjectCar.Add(element);
            currentCountCar++;
          }
          for(int i= 0; i<dataBase.GetShipsCount();i++){
           
            GameObject element = this.listView.Add(this.prefabElement);

            ListElement elementMeta = element.GetComponent<ListElement>();
    
            elementMeta.SetTitle(dataBase.GetShip(i).Mark);
            elementMeta.SetImage(this.imageElement[2]);
            elementMeta.SetDescription(dataBase.PrintShip(i));
            listObjectShip.Add(element);
            currentCountShip++;
          }
          for(int i= 0; i<dataBase.GetPlanesCount();i++){
           
            GameObject element = this.listView.Add(this.prefabElement);

            ListElement elementMeta = element.GetComponent<ListElement>();
    
            elementMeta.SetTitle(dataBase.GetPlane(i).Mark);
            elementMeta.SetImage(this.imageElement[1]);
            elementMeta.SetDescription(dataBase.PrintPlane(i));
            listObjectPlane.Add(element);
            currentCountPlane++;
          }
     }

     public void DeleteAllElement(){
          for(int i= 0; i<listObjectCar.Count;i++){
            Destroy(listObjectCar[i]);
          }
          for(int i= 0; i<listObjectShip.Count;i++){
            Destroy(listObjectShip[i]);
          }
          for(int i= 0; i<listObjectPlane.Count;i++){
            Destroy(listObjectPlane[i]);
          }
          listObjectCar.Clear();
          listObjectShip.Clear();
          listObjectPlane.Clear();
          
          currentCountCar = 0;
          currentCountShip = 0;
          currentCountPlane = 0;

          listView.ClearView();
     }

    /* public void DeleteCurrentElement(int index){
          Destroy(listObject[index]);
          listObject.RemoveAt(index);
          listView.RemoveCurrentElements(index);
          currentCountCar--;
     } */
}
