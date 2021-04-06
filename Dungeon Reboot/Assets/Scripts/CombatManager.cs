using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{









    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //System Functions start here
    public void StartCombat()
    {

    }
    //Standard start turn
    public void PartyStartTurn()  
    {

    }

    public void PartyEndTurn()
    {

    }
    //Standard start turn
    public void EnemyStartTurn()
    {

    }
    //Ends enemy turn based on something, probably after every enemy has done an attack, how to track that? More variables, yay
    public void EnemyEndTurn()
    {

    }
    //Ends combat, switches scenes (probably, if I do end up doing the isometric battle thing), runs droploot
    public void EndCombat()
    {

        DropLoot();
    }

    //Pull from ItemManager and EnemyManager to decide loot, and number of shinies gained, as well as hand out EXP, so will also need to pull from ClassManager and PartyManager
    public void DropLoot()
    {

    }

    
    //Attack Functions




    //Defense Functions




    //Skill Functions




}
