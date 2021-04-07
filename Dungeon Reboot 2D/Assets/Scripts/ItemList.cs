using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int ID;
    public string name;
    public string type;
    public string atk;
    public string def;
    public string attr1;
    public string attr2;
    public string attr3;
    public string desc;
    public Sprite itemImg;
    public bool pickedUp;



    public void BrokenSword()
    {
        if(ItemManager.weapTab == true)
        {
        name = "Broken Sword";
        type = "Sword";
        atk = "2";
        def = "N/A";
        attr1 = "None";
        attr2 = "None";
        attr3 = "None";
        desc = "More of a rusty metal shard, really, but what can you do?";
        }
        
    }

    public void TrainingSword()
    {
        if(ItemManager.weapTab == true)
        {
        name = "Training Sword";
        type = "Sword";
        atk = "5";
        def = "N/A";
        attr1 = "None";
        attr2 = "None";
        attr3 = "None";
        desc = "A training sword, a little dull, but works well enough";
        }
    }

    public void BasicSword()
    {
        if(ItemManager.weapTab == true)
        {
        name = "Basic Sword";
        type = "Sword";
        atk = "7";
        def = "N/A";
        attr1 = "None";
        attr2 = "None";
        attr3 = "None";
        desc = "A trusty iron sword, a little chipped, but still stabs quite well";

        }
    }
}
