
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DataBase))]
public class DatabaseEditor : Editor
{
    
    private DataBase dataBase;

    private void Awake() {
        dataBase = (DataBase)target;
    }

    public override void OnInspectorGUI(){
        GUILayout.BeginVertical();

        if(GUILayout.Button("Clear database")){
            dataBase.ClearDatabase();
        }
        if(GUILayout.Button("Add car")){
            dataBase.CreateCar();
        }
        if(GUILayout.Button("Add ship")){
            dataBase.CreateShip();
        }
        if(GUILayout.Button("Add plane")){
            dataBase.CreatePlane();
        }

        GUILayout.EndVertical();
        base.OnInspectorGUI();
    }
}