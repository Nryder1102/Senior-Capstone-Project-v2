using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Class Select
    public Button roguebttn;
    public Button magebttn;
    public Button paladinbttn;
    public Button rangerbttn;
    public Button fighterbttn;
    public Button beastbttn;
    public Button cconfirm;
    public static int classnum = 0;
    public static int cconfirm2 = 0;

    //Individual UI Groups
    public GameObject classSelectUI;
    public GameObject barsUI;
    public GameObject statusUI;
    public GameObject skillUI;
    public GameObject menuUI;
    public GameObject invUI;
    public GameObject saveUI;
    public GameObject loadUI;
    public GameObject uiBG;
    public static GameObject dialogueUI;
    public static GameObject allUI;
    

    //Wait Function variables
    public static float waitVal;
    public static int waitFlag;

    //Default state and opening and closing of menu
    public GameObject list;

    //Well, confirm quitting the game
    public GameObject confirmQuit;

    //Status Screen
    public static int selectedChar = 0;
    public static string statPlayerName = "Name";
    public GameObject charPic1;
    public GameObject charPic2;
    public GameObject charPic3;

    //Character Creation
    public bool playerCreated = false;
    public static int playerPronounSelected = 0;
    public static int playerRaceSelected = 0;
    public static int playerClassSelected = 0;
    public static int playerNameSelected = 0;
    public static int playerComment = 0;
    public bool pDone;
    public bool rDone;
    public bool cDone;
    public bool nDone;
    public bool commentDone;
    public InputField playerName;
    public GameObject playerNameEntry;
    public Button playerNameConfirm;
    public static string playerRace;
    public GameObject playerRaceSelect;
    public GameObject playerCreation;
    public GameObject playerGenderSelect;
    public static string playerGender;
    public Button playerPronounConfirm;
    public GameObject playerCommentBox;
    public Button rButton1;
    public Button rButton2;
    public Button rButton3;
    public Button rButton4;
    public Button rButton5;
    public Button rButton6;
    public Button cButton1;
    public Button cButton2;
    public Button cButton3;
    public Button cButton4;
    public Button cButton5;
    public Button cButton6;
    public Sprite egg1;
    public Sprite egg2;
    public Sprite egg3;
    public Sprite egg4;
    public Sprite egg5;




    //Intro
    public GameObject introScene;







    
    
    // Start is called before the first frame update
    void Start()
    {
        allUI = GameObject.FindWithTag("Canvas");
        dialogueUI = GameObject.FindWithTag("Dialogue");
        cconfirm.interactable = false;
        classSelectUI.SetActive(false);
        barsUI.SetActive(false);
        skillUI.SetActive(false);
        statusUI.SetActive(false);
        menuUI.SetActive(false);
        invUI.SetActive(false);
        loadUI.SetActive(false);
        saveUI.SetActive(false);
        playerCreation.SetActive(true);
        playerNameEntry.SetActive(false);
        playerRaceSelect.SetActive(false);
        playerNameConfirm.interactable = false;
        playerPronounConfirm.interactable = false;
//        objectLeft.interactable = false;
        introScene.SetActive(true);
        playerGenderSelect.SetActive(false);
        ItemManager.weapTab = true;
        DialogueManager.diaTreePos = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (waitFlag == 1)
        {
            barsUI.SetActive(true);
            waitFlag = 0;
        }
        if (cconfirm2 == 1)
        {
            cconfirm.interactable = true;
        }

        if(Input.GetKeyDown(KeyCode.Escape) && classnum != 0)
        {
            bool isActive = menuUI.activeSelf;
            menuUI.SetActive(!isActive);
            allUI.SetActive(!isActive);
            confirmQuit.SetActive(false);
            StatsBack();
            InvBack();
            //objectPage = 1;
        }
/*
        if(objectPage == 3)
        {
            objectRight.interactable = false;
        }
        if(objectPage != 3)
        {
            objectRight.interactable = true;
        }
        if(objectPage == 1)
        {
            objectLeft.interactable = false;
        }
        if(objectPage != 1)
        {
            objectLeft.interactable = true;
        }
*/
        if(!string.IsNullOrWhiteSpace(playerName.text) && Input.GetKeyDown(KeyCode.Return))
        {
            NameConfirm();
            Dialogue.QueueDialogue();
        }
        if(playerCreated == false)
        {
            PlayerCreation();
        }
    }

    //Functions to start different system trees
    public void PlayerCreation()
    {
        if(playerPronounSelected == 1)
        {
            playerGenderSelect.SetActive(true);
        }
        if(playerPronounSelected == 2 && pDone != true)
        {
            playerGenderSelect.SetActive(false);
            DialogueManager.diaTreePos = 2;
            pDone = true;
        }
        if(playerRaceSelected == 1)
        {
            playerRaceSelect.SetActive(true);
        }
        if(playerRaceSelected == 2 && rDone != true)
        {
            playerRaceSelect.SetActive(false);
            DialogueManager.diaTreePos = 3;
            rDone = true;
        }
        if(playerClassSelected == 1)
        {
            classSelectUI.SetActive(true);
        }
        if(playerClassSelected == 2 && cDone != true)
        {
            classSelectUI.SetActive(false);
            DialogueManager.diaTreePos = 4;
            cDone = true;
        }
        if(playerNameSelected == 1)
        {
            playerNameEntry.SetActive(true);
        }
        if(playerNameSelected == 2 && nDone != true)
        {
            playerNameEntry.SetActive(false);
            DialogueManager.diaTreePos = 5;
            nDone = true;
        }
        if(playerComment == 1)
        {
            playerCommentBox.SetActive(true);
            DialogueManager.diaTreePos = 6;
        }
        if(playerComment == 2 && commentDone != true)
        {
            playerCommentBox.SetActive(false);
            commentDone = true;
        }
        
    }

    //Chooses which class you select
    public void ClassSelect1()
    {
        classnum = 1;
        if (cconfirm2 == 0)
        {
            cconfirm2 = 1;
        }
        cButton1.interactable = false;
        cButton2.interactable = true;
        cButton3.interactable = true;
        cButton4.interactable = true;
        cButton5.interactable = true;
        cButton6.interactable = true;
    }
    public void ClassSelect2()
    {
        classnum = 2;
        if (cconfirm2 == 0)
        {
            cconfirm2 = 1;
        }
        cButton1.interactable = true;
        cButton2.interactable = false;
        cButton3.interactable = true;
        cButton4.interactable = true;
        cButton5.interactable = true;
        cButton6.interactable = true;
    }
    public void ClassSelect3()
    {
        classnum = 3;
        if (cconfirm2 == 0)
        {
            cconfirm2 = 1;
        }
        cButton1.interactable = true;
        cButton2.interactable = true;
        cButton3.interactable = false;
        cButton4.interactable = true;
        cButton5.interactable = true;
        cButton6.interactable = true;
    }
    public void ClassSelect4()
    {
        classnum = 4;
        if (cconfirm2 == 0)
        {
            cconfirm2 = 1;
        }
        cButton1.interactable = true;
        cButton2.interactable = true;
        cButton3.interactable = true;
        cButton4.interactable = false;
        cButton5.interactable = true;
        cButton6.interactable = true;
    }
    public void ClassSelect5()
    {
        classnum = 5;
        if (cconfirm2 == 0)
        {
            cconfirm2 = 1;
        }
        cButton1.interactable = true;
        cButton2.interactable = true;
        cButton3.interactable = true;
        cButton4.interactable = true;
        cButton5.interactable = false;
        cButton6.interactable = true;
    }
    public void ClassSelect6()
    {
        classnum = 6;
        if (cconfirm2 == 0)
        {
            cconfirm2 = 1;
        }
        cButton1.interactable = true;
        cButton2.interactable = true;
        cButton3.interactable = true;
        cButton4.interactable = true;
        cButton5.interactable = true;
        cButton6.interactable = false;
    }

    //Disables class confirm button, starts wait for class select to disappear
    public void ConfirmClass()
    {
        cconfirm.interactable = false;
        classSelectUI.SetActive(false);
        //For testing purposes
        playerClassSelected = 2;
        cconfirm2 = 2;
    }
    


    //Wait function, for variable waitVal
    IEnumerator WaitRoutine()
    {
        yield return new WaitForSeconds(waitVal);
        waitFlag = 1;
    }

    public void OpenStats()
    {
        list.SetActive(false);
        statusUI.SetActive(true);

    }
    public void OpenInventory()
    {
        list.SetActive(false);
        invUI.SetActive(true);

    }
    public void QuitConfirmation()
    {
        confirmQuit.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void QuitStop()
    {
        confirmQuit.SetActive(false);
    }

    //Sets the party menu to the default state on exiting menu
    public void StatsBack()
    {
            statusUI.SetActive(false);
            list.SetActive(true);
            ClassManager.str = ClassManager.strFlag;
            ClassManager.vit = ClassManager.vitFlag;
            ClassManager.dex = ClassManager.dexFlag;
            ClassManager.intel = ClassManager.intFlag;
            ClassManager.cha = ClassManager.chaFlag;
            ClassManager.luk = ClassManager.lukFlag;
            ClassManager.healthMax = ClassManager.healthMaxFlag;
            ClassManager.manaMax = ClassManager.manaMaxFlag;
            ClassManager.attr = ClassManager.attrFlag;
            ClassManager.attrConfirm = 0;
            PartyManager.strp1 = PartyManager.strp1Flag;
            PartyManager.vitp1 = PartyManager.vitp1Flag;
            PartyManager.dexp1 = PartyManager.dexp1Flag;
            PartyManager.intelp1 = PartyManager.intp1Flag;
            PartyManager.chap1 = PartyManager.chap1Flag;
            PartyManager.lukp1 = PartyManager.lukp1Flag;
            PartyManager.healthMaxp1 = PartyManager.healthMaxp1Flag;
            PartyManager.manaMaxp1 = PartyManager.manaMaxp1Flag;
            PartyManager.attrp1 = PartyManager.attrp1Flag;
            PartyManager.strp2 = PartyManager.strp2Flag;
            PartyManager.vitp2 = PartyManager.vitp2Flag;
            PartyManager.dexp2 = PartyManager.dexp2Flag;
            PartyManager.intelp2 = PartyManager.intp2Flag;
            PartyManager.chap2 = PartyManager.chap2Flag;
            PartyManager.lukp2 = PartyManager.lukp2Flag;
            PartyManager.healthMaxp2 = PartyManager.healthMaxp2Flag;
            PartyManager.manaMaxp2 = PartyManager.manaMaxp2Flag;
            PartyManager.attrp2 = PartyManager.attrp2Flag;
            selectedChar = 1;
    }
    public void InvBack()
    {
        invUI.SetActive(false);
        list.SetActive(true);  
        ItemManager.weapTab = true;
    }

//These deal with the player name
    public void NameButton()
    {
        playerNameConfirm.interactable = !string.IsNullOrWhiteSpace(playerName.text);
    }
    public void NameConfirm()
    {
        playerNameConfirm.interactable = false;
        statPlayerName = playerName.text.ToString();
        playerNameEntry.SetActive(false);
        EggCheck();
        //waitVal = 2;
        //StartCoroutine(WaitRoutine());
        playerNameSelected = 2;

    }

//Here should handle player pronoun choice
    public void PronounChoice1()
    {
        playerGender = "male";
        playerPronounConfirm.interactable = true;
    }
    public void PronounChoice2()
    {
        playerGender = "female";
        playerPronounConfirm.interactable = true;
    }
    public void PronounChoice3()
    {
        playerGender = "non-binary";
        playerPronounConfirm.interactable = true;
    }
    public void PronounConfirm()
    {
        playerPronounConfirm.interactable = false;
        playerGenderSelect.SetActive(false);
        playerPronounSelected = 2;

        //For testing purposes

    }

    public void SelectRace1()
    {
        playerRace = "human";
        rButton1.interactable = false;
        rButton2.interactable = true;
        rButton3.interactable = true;
        rButton4.interactable = true;
        rButton5.interactable = true;
        rButton6.interactable = true;

    }
    public void SelectRace2()
    {
        playerRace = "orc";
        rButton1.interactable = true;
        rButton2.interactable = false;
        rButton3.interactable = true;
        rButton4.interactable = true;
        rButton5.interactable = true;
        rButton6.interactable = true;
    }
    public void SelectRace3()
    {
        playerRace = "dwarf";
        rButton1.interactable = true;
        rButton2.interactable = true;
        rButton3.interactable = false;
        rButton4.interactable = true;
        rButton5.interactable = true;
        rButton6.interactable = true;
    }
    public void SelectRace4()
    {
        playerRace = "elf";
        rButton1.interactable = true;
        rButton2.interactable = true;
        rButton3.interactable = true;
        rButton4.interactable = false;
        rButton5.interactable = true;
        rButton6.interactable = true;
    }
    public void SelectRace5()
    {
        playerRace = "dragonkin";
        rButton1.interactable = true;
        rButton2.interactable = true;
        rButton3.interactable = true;
        rButton4.interactable = true;
        rButton5.interactable = false;
        rButton6.interactable = true;
    }
    public void SelectRace6()
    {
        playerRace = "imp";
        rButton1.interactable = true;
        rButton2.interactable = true;
        rButton3.interactable = true;
        rButton4.interactable = true;
        rButton5.interactable = true;
        rButton6.interactable = false;
    }
    public void SaveRace()
    {

        playerRaceSelected = 2;

    }



//Changes which character slot is selected on the party menu
    public void CharSelect1()
    {
        selectedChar = 1;
        ClassManager.str = ClassManager.strFlag;
        ClassManager.vit = ClassManager.vitFlag;
        ClassManager.dex = ClassManager.dexFlag;
        ClassManager.intel = ClassManager.intFlag;
        ClassManager.cha = ClassManager.chaFlag;
        ClassManager.luk = ClassManager.lukFlag;
        ClassManager.healthMax = ClassManager.healthMaxFlag;
        ClassManager.manaMax = ClassManager.manaMaxFlag;
        ClassManager.attr = ClassManager.attrFlag;
        ClassManager.attrConfirm = 0;
        
    }
    public void CharSelect2()
    {
        selectedChar = 2;
        PartyManager.strp1 = PartyManager.strp1Flag;
        PartyManager.vitp1 = PartyManager.vitp1Flag;
        PartyManager.dexp1 = PartyManager.dexp1Flag;
        PartyManager.intelp1 = PartyManager.intp1Flag;
        PartyManager.chap1 = PartyManager.chap1Flag;
        PartyManager.lukp1 = PartyManager.lukp1Flag;
        PartyManager.healthMaxp1 = PartyManager.healthMaxp1Flag;
        PartyManager.manaMaxp1 = PartyManager.manaMaxp1Flag;
        PartyManager.attrp1 = PartyManager.attrp1Flag;
        ClassManager.attrConfirm = 0;
    }
    public void CharSelect3()
    {
        selectedChar = 3;
        PartyManager.strp2 = PartyManager.strp2Flag;
        PartyManager.vitp2 = PartyManager.vitp2Flag;
        PartyManager.dexp2 = PartyManager.dexp2Flag;
        PartyManager.intelp2 = PartyManager.intp2Flag;
        PartyManager.chap2 = PartyManager.chap2Flag;
        PartyManager.lukp2 = PartyManager.lukp2Flag;
        PartyManager.healthMaxp2 = PartyManager.healthMaxp2Flag;
        PartyManager.manaMaxp2 = PartyManager.manaMaxp2Flag;
        PartyManager.attrp2 = PartyManager.attrp2Flag;
        ClassManager.attrConfirm = 0;
    }



    //Space to start making inventory management, using the items from item manager

/*
    public void InvLeftArrow()
    {

        if(objectPage != 1)
        {
            objectLeft.interactable = true;
            objectPage -= 1;
        }
    }

    public void InvRightArrow()
    {
        if(objectPage != 3)
        {
            objectRight.interactable = true;
            objectPage += 1;
        }
    }
*/
  /*   public void invSlot1()
    {
        
    }
    public void invSlot2()
    {
        
    }
    public void invSlot3()
    {
        
    }
    public void invSlot4()
    {
        
    }
    public void invSlot5()
    {
        
    }
    public void invSlot6()
    {
        
    }
    public void invSlot7()
    {
        
    }
    public void invSlot8()
    {
        
    }
    public void invSlot9()
    {
        
    }
    public void invSlot10()
    {
        
    } */





    public void EggCheck()
    {
        if(statPlayerName == "James " && classnum == 6 && playerGender == "male" && playerRace == "human")
        {
            this.charPic1.GetComponent<Image>().overrideSprite = egg1;
            ClassManager.Egg1 = true;
            statPlayerName = "James";
            ClassManager.className = "Trainer";
        }
        if(statPlayerName == "Mcp " && classnum == 2 && (playerGender == "male" || playerGender == "nb") && (playerRace == "human" || playerRace == "dwarf" || playerRace == "elf"))
        {
            this.charPic1.GetComponent<Image>().overrideSprite = egg2;
            ClassManager.Egg2 = true;
            statPlayerName = "MSTRCTRL";
            ClassManager.className = "System Admin";
        }
        if(statPlayerName == "Omegax" && classnum == 5 && playerGender == "male")
        {
            this.charPic1.GetComponent<Image>().overrideSprite = egg3;
            ClassManager.Egg3 = true;
            statPlayerName = "Omega-Xis";
            ClassManager.className = "Wizard";
        }
    }
}
