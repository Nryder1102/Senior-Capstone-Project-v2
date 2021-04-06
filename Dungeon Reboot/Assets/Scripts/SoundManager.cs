using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class SoundManager : MonoBehaviour
{

    public AudioSource characterButtons;
    public AudioSource menuButtons;
    public AudioSource inventoryButtons;
    public AudioSource attributeButtons;
    public AudioSource attributeConfirm;
    public AudioSource menuBGM;

 
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuButtonSound()
    {
        menuButtons.Play();
    }

    public void CharacterButtonSound()
    {
        characterButtons.Play();
    }
    public void InventoryButtonSound()
    {
        inventoryButtons.Play();
    }
    public void AttributeButtonSound()
    {
        attributeButtons.Play();
    }
    public void AttributeConfirmSound()
    {
        attributeConfirm.Play();
    }
    public void MenuBGM()
    {
        menuBGM.Play();
    }
    }
