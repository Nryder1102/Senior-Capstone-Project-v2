using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAnim : MonoBehaviour
{

    public Text uiText; 
    public string textToWrite; 
    public float timeperChar;
    public float timer;
    public int characterIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(uiText != null) {
            timer -= Time.deltaTime;
            if(timer <= 0f) {
                timer += timeperChar;
            }
        }
    }

    public void AddWriter(Text uiText, string textToWrite, float timeperChar) {
        this.uiText = uiText;
        this.textToWrite = textToWrite;
        this.timeperChar = timeperChar;
        characterIndex = 0;
    }

}
