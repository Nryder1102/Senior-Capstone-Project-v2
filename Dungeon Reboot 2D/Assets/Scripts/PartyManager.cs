using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartyManager : MonoBehaviour
{
 
//Stat Manager Variables | Variable Count: Way too many
    public static int attrp1 = 0;
    public static int attrp2 = 3;
    public static int attrp1Flag = 0;
    public static int attrp2Flag = 3;
    public static int strp1;
    public static int strp2;
    public static int strp1Flag;
    public static int strp2Flag;
    public static int vitp1;
    public static int vitp2;
    public static int vitp1Flag;
    public static int vitp2Flag;
    public static int dexp1;
    public static int dexp2;
    public static int dexp1Flag;
    public static int dexp2Flag;
    public static int intelp1;
    public static int intelp2;
    public static int intp1Flag;
    public static int intp2Flag;
    public static int chap1;
    public static int chap2;
    public static int chap1Flag;
    public static int chap2Flag;
    public static int lukp1;
    public static int lukp2;
    public static int lukp1Flag;
    public static int lukp2Flag;
    public static int healthp1;
    public static int healthp2;
    public static int healthMaxp1;
    public static int healthMaxp2;
    public static int healthMaxp1Flag;
    public static int healthMaxp2Flag;
    public static int manap1;
    public static int manap2;
    public static int manaMaxp1;
    public static int manaMaxp2;
    public static int manaMaxp1Flag;
    public static int manaMaxp2Flag;
    public static int expMaxp1;
    public static int expMaxp2;
    public static string statNamep1 = "Char 2";
    public static string statNamep2 = "Char 3";
    public static string classNamep1 = "Char Class 2";
    public static string classNamep2 = "Char Class 3";
    public static string levelNump1;
    public static string levelNump2;
    public static int levelp1;
    public static int levelp2;
    public static int atkp1;
    public static int atkp2;
    public static int defp1;
    public static int defp2;
    public static int characterSlot1 = 1;
    public static int characterSlot2 = 1;










    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterStatUpdater();
    }

 
    public void CharacterStatUpdater()
    {
        if(characterSlot1 == 1)
        {
            attrp1 = 0;
            strp1 = 0;
            vitp1 = 0;
            dexp1 = 0;
            intelp1 = 0;
            chap1 = 0;
            lukp1 = 0;
        } 
    }
    public void CharacterSwitch()
    {
        
    }

    public void CSwitchSlot1()
    {

    }

    public void CSwitchSlot2()
    {

    }
}
