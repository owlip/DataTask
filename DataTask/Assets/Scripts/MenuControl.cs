using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public GameObject panelHome;
    public GameObject panelMenu;
    public GameObject panelListChoseType;
    public GameObject panelCreateCar;
    public GameObject panelCreateShip;
    public GameObject panelCreatePlane;
    [SerializeField] private ExampleComponent ex;
    
    public DataBase dataBase;

    
    public void OpenData(){   
        panelMenu.SetActive(true);
        panelHome.SetActive(false);
    }
    public void OpenHome(){
        panelHome.SetActive(true);
        panelMenu.SetActive(false);
    }
    public void DeleteObject(){
        dataBase.ClearDatabase();
    }

   public void AddObject(){
        if(panelListChoseType.activeInHierarchy==false){
            panelListChoseType.SetActive(true);
        }
        else{
            panelListChoseType.SetActive(false);
        }
    }

    public void AddCar(){
        panelCreateCar.SetActive(true);
        panelListChoseType.SetActive(false);
    }
    public void AddShip(){
        panelCreateShip.SetActive(true);
        panelListChoseType.SetActive(false);
    }
    public void AddPlane(){
        panelCreatePlane.SetActive(true);
        panelListChoseType.SetActive(false);
    }
    public void UpdateDatabase(){
        ex.UpdateDatabase();
    }
}
