using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public static string[] pTerms;
    public static string pGender = GameManager.playerGender;
    public static string pName = GameManager.statPlayerName;
    public static string pRace = GameManager.playerRace;
    public static string pClass = ClassManager.className; 
    public static Queue<string> introText;
    public static Queue<string> pronounText;
    public static Queue<string> raceText;
    public static Queue<string> classText;
    public static Queue<string> nameText;
    public static Queue<string> commentText;
    public static Queue<string> bossDoor;
    public static int lineNum;

   void Start()
      {
        pTerms = new string[8];
        introText = new Queue<string>();
        bossDoor = new Queue<string>();
        pronounText = new Queue<string>();
        raceText = new Queue<string>();
        classText = new Queue<string>();
        nameText = new Queue<string>();
        commentText = new Queue<string>();
        lineNum = 12;
         //Intro
         //Provide background on the world, tell stories of the 6 heroes and what's to come
        introText.Enqueue("Once upon a time, war ravaged the lands, and a hero was called for by the Fates themselves to reunite the races as one.");
        introText.Enqueue("Don't get your hopes up now, this is a history lesson remember? You certainly aren't that hero.");
        introText.Enqueue("Now, going back to the story, there was a little... problem, you see, a little... hiccup, in the Fates' design, no big deal, really.");
        introText.Enqueue("Except for well, the fact that they called for too many heroes, one from each major race, advancing the war, instead of ending it.");
        introText.Enqueue("Now, instead of just a normal territory war, it suddenly turned into much, much more almost overnight, after all, when you have six heroes, and a prophecy made for one, things get a little hectic.");
        introText.Enqueue("And now they've left that whole mess for me to deal with.");

        //Then say none of that matters
        introText.Enqueue("Except, however, none of that matters to you, being stuck in this lightless prison as you are, recieving basic history lessons from the voices in your head. Should you ever escape this place, I suppose it'd do you some good to know this, though.");
        introText.Enqueue("Who am I? Well, I'm no one important enough for you to worry about right now, little one.");
        introText.Enqueue("Just know, I've brought you here for a very specific reason, that I do hope you'll fulfill.");
        introText.Enqueue("What reason? Well, I just can't outright tell you, now can I? Where's the fun in that? No no, you'll have to figure that out on your own.");
        introText.Enqueue("Anyways, little one, it's time to start waking up. Do you happen to remember what pronouns you identify by, by any chance?");
        introText.Enqueue("");
        
      }
   void Update()
   {
        pGender = GameManager.playerGender;
        pName = GameManager.statPlayerName;
        pRace = GameManager.playerRace;
        pClass = ClassManager.className; 
   }
   public static void QueueDialogue()
   {
         Debug.Log("Queue Confirm");



   }
    public static void PronounScene()
    {
        lineNum = 3;
        pronounText.Enqueue("Let's continue our little history lesson on the heroes then, shall we?");
        pronounText.Enqueue("Might as well get to know them a bit after all, as well as the races they represent.");
        //Explain how the 6 heroes were the pinnacles of their respective races
        pronounText.Enqueue("");

    }
    
    public static void RaceScene()
    {
        lineNum = 1;

        //Explain further how the 6 heroes were specialized in a class each
        raceText.Enqueue("");
    }

    public static void ClassScene()
    {
        lineNum = 1;

        classText.Enqueue("");
    }

    public static void NameScene()
    {
        lineNum = 1;

        classText.Enqueue("");
    }

    public static void CommentScene()
    {
        lineNum = 1;

        classText.Enqueue("");
    }





   public void PronounTerms()
   {
        Debug.Log("PTerms Loaded");
        if(pGender == "male")
        {
            pTerms[0] = "he";
            pTerms[1] = "He";
            pTerms[2] = "him";
            pTerms[3] = "Him";
            pTerms[4] = "his";
            pTerms[5] = "His";
            pTerms[6] = "he's";
            pTerms[7] = "He's";
        }
        if(pGender == "female")
        {
            pTerms[0] = "she";
            pTerms[1] = "She";
            pTerms[2] = "her";
            pTerms[3] = "Her";
            pTerms[4] = "hers";
            pTerms[5] = "Hers";
            pTerms[6] = "she's";
            pTerms[7] = "She's";
        }
        if(pGender == "non-binary")
        {
            pTerms[0] = "they";
            pTerms[1] = "They";
            pTerms[2] = "them";
            pTerms[3] = "Them";
            pTerms[4] = "theirs";
            pTerms[5] = "Theirs";
            pTerms[6] = "they're";
            pTerms[7] = "They're";
        }
        
    }

    public static void BossDoor1()
    {

    }
   
}
