using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
 
    //For Character Stats
    public static int wpnatk = 0;
    public static int armdef = 0;
    public static int wpnatkp1;
    public static int wpnatkp2;
    public static int armdefp1;
    public static int armdefp2;

    //For Item Stats
    public Text disName;
    public Text disType;
    public Text disAtk;
    public Text disDef;
    public Text disAttr1;
    public Text disAttr2;
    public Text disAttr3;
    public Text disDesc;




    //Variables for the shinies
    public Sprite BrokenSwordImg;
    public bool BrokenSwordEquip;
    public Sprite TrainingSwordImg;
    public bool TrainingSwordEquip;
    public Sprite BasicSwordImg;
    public bool BasicSwordEquip;

    //Inventory System
    public Button weaponTabButton;
    public Button armorTabButton;
    public Button miscTabButton;
    public Button keyTabButton;
    public static bool weapTab;
    public static bool armTab;
    public static bool miscTab;
    public static bool keyTab;
    public Sprite noSprite;
    public Sprite player1Indicator;
    public Sprite player2Indicator;
    public Sprite player3Indicator;



    private int allSlots;
    private int enabledSlots;
    private GameObject[] slot;
    public GameObject slotHolder;

    // Start is called before the first frame update
    void Start()
    {
        allSlots = 10;
        slot = new GameObject[allSlots];
        for (int i = 0; i < allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;

            if(slot[i].GetComponent<Slot>().item == null)
            {
                slot[i].GetComponent<Slot>().empty = true;
            }
        }
        Debug.Log(allSlots);
    }

    // Update is called once per frame
    void Update()
    {
       // ObjectIndicator();
       // ObjectImages();
       // InventoryDisplay();
       
    }

    //Inventory Pages
    public void ObjectIndicator()
    {
        //Disable Indicators if none are there
/*      
        if(slot1Indicator == 0)
        {
            slot1.SetActive(false);
        }
        if(slot2Indicator == 0)
        {
            slot2.SetActive(false);
        }
        if(slot3Indicator == 0)
        {
            slot3.SetActive(false);
        }
        if(slot4Indicator == 0)
        {
            slot4.SetActive(false);
        }
        if(slot5Indicator == 0)
        {
            slot5.SetActive(false);
        }
        if(slot6Indicator == 0)
        {
            slot6.SetActive(false);
        }
        if(slot7Indicator == 0)
        {
            slot7.SetActive(false);
        }
        if(slot8Indicator == 0)
        {
            slot8.SetActive(false);
        }
        if(slot9Indicator == 0)
        {
            slot9.SetActive(false);
        }
        if(slot10Indicator == 0)
        {
            slot10.SetActive(false);
        }

        //Enable Player 1 Indicator
        if(slot1Indicator == 1)
        {
           this.slot1.GetComponent<Image>().overrideSprite = player1Indicator;
           slot1.SetActive(true);
        }
        if(slot2Indicator == 1)
        {
           this.slot2.GetComponent<Image>().overrideSprite = player1Indicator;
           slot2.SetActive(true);
        }
        if(slot3Indicator == 1)
        {
           this.slot3.GetComponent<Image>().overrideSprite = player1Indicator;
           slot3.SetActive(true);
        }
        if(slot4Indicator == 1)
        {
           this.slot4.GetComponent<Image>().overrideSprite = player1Indicator;
           slot4.SetActive(true);
        }
        if(slot5Indicator == 1)
        {
           this.slot5.GetComponent<Image>().overrideSprite = player1Indicator;
           slot5.SetActive(true);
        } 
        if(slot6Indicator == 1)
        {
           this.slot6.GetComponent<Image>().overrideSprite = player1Indicator;
           slot6.SetActive(true);
        }
        if(slot7Indicator == 1)
        {
           this.slot7.GetComponent<Image>().overrideSprite = player1Indicator;
           slot7.SetActive(true);
        }
        if(slot8Indicator == 1)
        {
           this.slot8.GetComponent<Image>().overrideSprite = player1Indicator;
           slot8.SetActive(true);
        }
        if(slot9Indicator == 1)
        {
           this.slot9.GetComponent<Image>().overrideSprite = player1Indicator;
           slot9.SetActive(true);
        }
        if(slot10Indicator == 1)
        {
           this.slot10.GetComponent<Image>().overrideSprite = player1Indicator;
           slot10.SetActive(true);
        }
   
        //Enable Player 2 Indicator
        if(slot1Indicator == 2)
        {
           this.slot1.GetComponent<Image>().overrideSprite = player2Indicator;
           slot1.SetActive(true);
        }
        if(slot2Indicator == 2)
        {
           this.slot2.GetComponent<Image>().overrideSprite = player2Indicator;
           slot2.SetActive(true);
        }
        if(slot3Indicator == 2)
        {
           this.slot3.GetComponent<Image>().overrideSprite = player2Indicator;
           slot3.SetActive(true);
        }
        if(slot4Indicator == 2)
        {
           this.slot4.GetComponent<Image>().overrideSprite = player2Indicator;
           slot4.SetActive(true);
        }
        if(slot5Indicator == 2)
        {
           this.slot5.GetComponent<Image>().overrideSprite = player2Indicator;
           slot5.SetActive(true);
        }
        if(slot6Indicator == 2)
        {
           this.slot6.GetComponent<Image>().overrideSprite = player2Indicator;
           slot6.SetActive(true);
        }
        if(slot7Indicator == 2)
        {
           this.slot7.GetComponent<Image>().overrideSprite = player2Indicator;
           slot7.SetActive(true);
        }
        if(slot8Indicator == 2)
        {
           this.slot8.GetComponent<Image>().overrideSprite = player2Indicator;
           slot8.SetActive(true);
        }
        if(slot9Indicator == 2)
        {
           this.slot9.GetComponent<Image>().overrideSprite = player2Indicator;
           slot9.SetActive(true);
        }
        if(slot10Indicator == 2)
        {
           this.slot10.GetComponent<Image>().overrideSprite = player2Indicator;
           slot10.SetActive(true);
        }

        //Enable Player 3 Indicator
        if(slot1Indicator == 3)
        {
           this.slot1.GetComponent<Image>().overrideSprite = player3Indicator;
           slot1.SetActive(true);
        }
        if(slot2Indicator == 3)
        {
           this.slot2.GetComponent<Image>().overrideSprite = player3Indicator;
           slot2.SetActive(true);
        }
        if(slot3Indicator == 3)
        {
           this.slot3.GetComponent<Image>().overrideSprite = player3Indicator;
           slot3.SetActive(true);
        }
        if(slot4Indicator == 3)
        {
           this.slot4.GetComponent<Image>().overrideSprite = player3Indicator;
           slot4.SetActive(true);
        }
        if(slot5Indicator == 3)
        {
           this.slot5.GetComponent<Image>().overrideSprite = player3Indicator;
           slot5.SetActive(true);
        }
        if(slot6Indicator == 3)
        {
           this.slot6.GetComponent<Image>().overrideSprite = player3Indicator;
           slot6.SetActive(true);
        }
        if(slot7Indicator == 3)
        {
           this.slot7.GetComponent<Image>().overrideSprite = player3Indicator;
           slot7.SetActive(true);
        }
        if(slot8Indicator == 3)
        {
           this.slot8.GetComponent<Image>().overrideSprite = player3Indicator;
           slot8.SetActive(true);
        }
        if(slot9Indicator == 3)
        {
           this.slot9.GetComponent<Image>().overrideSprite = player3Indicator;
           slot9.SetActive(true);
        }
        if(slot10Indicator == 3) 
        {
           this.slot10.GetComponent<Image>().overrideSprite = player3Indicator;
           slot10.SetActive(true);
        }
        */
   
   
   
    }

    public void ObjectImages()
    {
/*
        if(weapTab == true)
        {
            //Need to put in place something that hides these until weapon has been acquired
            this.slot1Img.GetComponent<Image>().overrideSprite = BrokenSwordImg;
            slot1Img.SetActive(true);
            this.slot2Img.GetComponent<Image>().overrideSprite = TrainingSwordImg;
            this.slot3Img.GetComponent<Image>().overrideSprite = BasicSwordImg;
            this.slot4Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot5Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot6Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot7Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot8Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot9Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot10Img.GetComponent<Image>().overrideSprite = noSprite;
        }
        if(armTab == true)
        {
            this.slot1Img.GetComponent<Image>().overrideSprite = noSprite;
            slot1Img.SetActive(true);
            this.slot2Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot3Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot3Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot4Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot5Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot6Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot7Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot8Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot9Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot10Img.GetComponent<Image>().overrideSprite = noSprite;
        }
        if(miscTab == true)
        {
            this.slot1Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot2Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot3Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot4Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot5Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot6Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot7Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot8Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot9Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot10Img.GetComponent<Image>().overrideSprite = noSprite;
        }
        if(keyTab == true)
        {
            this.slot1Img.GetComponent<Image>().overrideSprite = noSprite;
            slot1Img.SetActive(false);
            this.slot2Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot3Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot4Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot5Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot6Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot7Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot8Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot9Img.GetComponent<Image>().overrideSprite = noSprite;
            this.slot10Img.GetComponent<Image>().overrideSprite = noSprite;
        }
*/

    }


    
    //Items List
    public void EquippedWeapons()
    {

    }

    public void EquippedArmor()
    {
        
    }


    //WEAPONS LIST STARTS HERE
    



    //ARMOR LIST STARTS HERE







    //MISC/CONSUMABLES START HERE





    //KEY ITEMS START HERE





    //Inventory System

        public void WeaponTab()
    {
        ItemManager.weapTab = true;
        ItemManager.armTab = false;
        ItemManager.miscTab = false;
        ItemManager.keyTab = false;
        weaponTabButton.interactable = false;
        armorTabButton.interactable = true;
        miscTabButton.interactable = true;
        keyTabButton.interactable = true;
    }
    
    public void ArmorTab()
    {
        ItemManager.weapTab = false;
        ItemManager.armTab = true;
        ItemManager.miscTab = false;
        ItemManager.keyTab = false;
        weaponTabButton.interactable = true;
        armorTabButton.interactable = false;
        miscTabButton.interactable = true;
        keyTabButton.interactable = true;

    }

    public void MiscTab()
    {
        ItemManager.weapTab = false;
        ItemManager.armTab = false;
        ItemManager.miscTab = true;
        ItemManager.keyTab = false;
        weaponTabButton.interactable = true;
        armorTabButton.interactable = true;
        miscTabButton.interactable = false;
        keyTabButton.interactable = true;
    }

    public void KeyTab()
    {
        ItemManager.weapTab = false;
        ItemManager.armTab = false;
        ItemManager.miscTab = false;
        ItemManager.keyTab = true;
        weaponTabButton.interactable = true;
        armorTabButton.interactable = true;
        miscTabButton.interactable = true;
        keyTabButton.interactable = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Item")
        {
            Debug.Log("Collison");
            GameObject itemPickedUp = other.gameObject;
            Item item = itemPickedUp.GetComponent<Item>();
            
            AddItem(itemPickedUp, item.ID, item.type, item.desc, item.itemImg);
        }
    }
    void AddItem(GameObject itemObj, int itemID, string itemType, string itemDesc, Sprite itemImg)
    {
        for (int i = 0; i < allSlots; i++)
        {
            Debug.Log("For Loop");
            if(slot[i].GetComponent<Slot>().empty)
            {
                Debug.Log("For-If Loop");
                //add item
                itemObj.GetComponent<Item>().pickedUp = true;
                slot[i].GetComponent<Slot>().item = itemObj;
                slot[i].GetComponent<Slot>().icon = itemImg;
                slot[i].GetComponent<Slot>().ID = itemID;
                slot[i].GetComponent<Slot>().typeID = itemType;
                slot[i].GetComponent<Slot>().desc = itemDesc;

                itemObj.transform.parent = slot[i].transform;
                itemObj.SetActive(false);

                slot[i].GetComponent<Slot>().UpdateSlot();
                slot[i].GetComponent<Slot>().empty = false;
                

            }
              
        }
                   
            
    }


    //Display Manager
    public void InventoryDisplay()
    {
/*      
        disName.text = name;
        disType.text = "Type: " + ItemList.type;
        disAtk.text = "Atk: " + ItemList.atk;
        disDef.text = "Def: " + ItemList.def;
        disAttr1.text = "Attr: " + ItemList.attr1;
        disAttr2.text = "Attr: " + ItemList.attr2;
        disAttr3.text = "Attr: " + ItemList.attr3;
        disDesc.text = "Desc: " + ItemList.desc; 
*/
    }
}
