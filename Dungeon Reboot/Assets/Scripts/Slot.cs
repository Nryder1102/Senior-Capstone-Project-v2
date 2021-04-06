using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public GameObject item;
    public int ID;
    public string typeID;
     public string desc;
    public Sprite icon;
    public bool empty;


    public void UpdateSlot()
    {
        this.GetComponent<Image>().sprite = icon;
    }

}
