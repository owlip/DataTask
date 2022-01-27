using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListView : MonoBehaviour
{
   [Header("Component")]
   [SerializeField] private Transform contentTransform;
   [SerializeField] private RectTransform contentRectTransform;

   [Header("Settings")]
   [SerializeField] private List<GameObject> elements;
   [SerializeField] private float offset;

   
   public GameObject Add(GameObject element){
       
       GameObject createdElement = Instantiate(element, this.contentTransform);
   
        if(this.elements.Count == 0){
            this.elements.Add(createdElement);
            return createdElement;
        }
   

        ListElement elementMeta = createdElement.GetComponent<ListElement>();
        GameObject lastElement = this.elements[elements.Count-1];

        Vector3 lastElementPosition = lastElement.transform.localPosition;

        Vector3 newElementPosition = new Vector3{
            x = lastElementPosition.x,
            y = lastElementPosition.y - elementMeta.Height() - this.offset,
            z = lastElementPosition.z
        };

        createdElement.transform.localPosition = newElementPosition;

        this.elements.Add(createdElement);

        float contentHeight = this.contentRectTransform.rect.height;

        contentHeight += this.offset + elementMeta.Height();

        this.contentRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, contentHeight);

        
        return createdElement;
    }

    public void ClearView(){
        elements.Clear();
    }
    public void RemoveCurrentElements(int index){
        elements.RemoveAt(index);
    }
}
