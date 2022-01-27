using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListElement : MonoBehaviour
{
   [Header("Components")]
   [SerializeField] private RectTransform border;
   [Space]
   [SerializeField] private Text title;
   [SerializeField] private Text description;
   [SerializeField] private Image image;


   public void SetTitle(string title){
       this.title.text = title;
   }
   public void SetDescription(string description){
       this.description.text = description;
   }
   
   public void SetImage(Sprite image){
       this.image.sprite = image;
   }



   public float Width(){
       return border.rect.width;
   }
    public float Height(){
       return border.rect.height;
   }
}