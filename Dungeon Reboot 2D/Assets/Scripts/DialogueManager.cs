using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    //Variables that will be used in most scenes
    public static string currentSpeaker;
    public static bool characterKnown;
    public GameObject dialogueBox;
    public Text dialogueText;
    public Text commentText;
    public Text speakerName;
    public GameObject left1;
    public GameObject left2;
    public GameObject right1;
    public GameObject right2;
    public GameObject center;
    public int dialogueFlag = 0;
    public static int lineFlag = 0;
    public static int diaTreePos = 0;

 
    //The meaty stuff

    public Queue<string> history;
    public Queue<string> introText;
    public GameObject dialogueUI;   


    // Start is called before the first frame update
    void Start()
    {
        history = new Queue<string>();
    }

    // Update is called once per frame
    void Update()
    {
        if(diaTreePos == 0)
        {
            dialogueUI.SetActive(false);
        }
        if (diaTreePos == 1)
        {
            IntroScene();        
        }
        if (diaTreePos == 2)
        {
            PronounScene();
        }
        if ( diaTreePos == 3)
        {
            RaceScene();
        }
        if (diaTreePos == 4)
        {
            ClassScene();
        }
        if (diaTreePos == 5)
        {
            NameScene();
        }
        if (diaTreePos == 6)
        {
            CommentScene();
        }
    }

    //Dialogue boxes start here
    public void IntroScene()
    {
        dialogueUI.SetActive(true);
        speakerName.text = "???";
        if (dialogueFlag == 0)
        {
            dialogueText.text = "Welcome, to the lands of (TBD), little one, a world of might and magic, wonder and weaponry, heroes and monsters.";
        }
            if(Input.GetMouseButtonDown(0) && lineFlag != Dialogue.lineNum)
            {
                dialogueText.text = Dialogue.introText.Dequeue();
                lineFlag++;
                Debug.Log(lineFlag + "" + Dialogue.lineNum);
                dialogueFlag = 1;
            }
            if(lineFlag == Dialogue.lineNum)
            {
                diaTreePos = 0;
                lineFlag = 0;
                GameManager.playerPronounSelected = 1;
                dialogueUI.SetActive(false);
                dialogueFlag = 0;
            }
    }

    //Ask player to choose pronouns
    public void PronounScene()
    {
        
        dialogueUI.SetActive(true);
        speakerName.text = "???";
        if (dialogueFlag == 0)
        {
            //Sets first text box to work with Queue, and queues the linesw
            Dialogue.PronounScene();
            dialogueText.text = "Ah, so you're " + Dialogue.pGender + " are you? Very good, let's see if we can rattle loose any more memories.";
        }
            if(Input.GetMouseButtonDown(0) && lineFlag != Dialogue.lineNum)
            {
                dialogueText.text = Dialogue.pronounText.Dequeue();
                lineFlag++;
                Debug.Log(lineFlag + "" + Dialogue.lineNum);
                dialogueFlag = 1;
            }
            if(lineFlag == Dialogue.lineNum)
            {
                diaTreePos = 0;
                lineFlag = 0;
                GameManager.playerRaceSelected = 1;
                dialogueUI.SetActive(false);
                dialogueFlag = 0;
            }
    }

    //Ask player to choose race
    public void RaceScene()
    {
        dialogueUI.SetActive(true);
        speakerName.text = "???";
        if (dialogueFlag == 0)
        {
            //Sets first text box to work with Queue, and queues the linesw
            Dialogue.RaceScene();
            dialogueText.text = "Oh? " /*Figure out how to do an a/an for correct grammar*/ + Dialogue.pRace + " eh? Haven't seen one of those down here in quite some time";
        }
            if(Input.GetMouseButtonDown(0) && lineFlag != Dialogue.lineNum)
            {
                dialogueText.text = Dialogue.raceText.Dequeue();
                lineFlag++;
                Debug.Log(lineFlag + "" + Dialogue.lineNum);
                dialogueFlag = 1;
            }
            if(lineFlag == Dialogue.lineNum)
            {
                diaTreePos = 0;
                lineFlag = 0;
                GameManager.playerClassSelected = 1;
                dialogueUI.SetActive(false);
                dialogueFlag = 0;
            }
    }

    //Ask player to choose class
    public void ClassScene()
    {
        dialogueUI.SetActive(true);
        speakerName.text = "???";
        if (dialogueFlag == 0)
        {
            //Sets first text box to work with Queue, and queues the linesw
            Dialogue.ClassScene();
            dialogueText.text = "A " + Dialogue.pClass + "? My, that's a great choice little one, hopefully these skills will serve you well in the coming days.";
        }
            if(Input.GetMouseButtonDown(0) && lineFlag != Dialogue.lineNum)
            {
                dialogueText.text = Dialogue.raceText.Dequeue();
                lineFlag++;
                Debug.Log(lineFlag + "" + Dialogue.lineNum);
                dialogueFlag = 1;
            }
            if(lineFlag == Dialogue.lineNum)
            {
                diaTreePos = 0;
                lineFlag = 0;
                GameManager.playerNameSelected = 1;
                dialogueUI.SetActive(false);
                dialogueFlag = 0;
            }
    }
 
    //Ask player to choose name
    public void NameScene()
    {
                diaTreePos = 0;
                lineFlag = 0;
                GameManager.playerComment = 1;
                dialogueUI.SetActive(false);
                dialogueFlag = 0;
    }
    //Comment on players choices
    public void CommentScene()
    {
        speakerName.text = "???";
        //Comment on name, and class, basically confirming info unless it's an easter egg 
        if(ClassManager.Egg1 == true || ClassManager.Egg2 == true || ClassManager.Egg3 == true || ClassManager.Egg4 == true || ClassManager.Egg5 == true)
        {
            commentText.text = "";
        }


        //After the comment, before "Waking up"
        //dialogueText.text = "Well, chop chop, you can't be lying here all day listening to make believe voices in your head, now can you? You've got work to do, and I hear something roaming around nearby, goodbye for now, little one.";
    }



    //Function to try and introduce characters
    public void UnknownCharacter()
    {

    }
}