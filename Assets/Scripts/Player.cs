using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
        
    [SerializeField] int health;
    [SerializeField] int maxHealth;

    // List<Card> inHand


    void Awake(){
        health = maxHealth;
    }


    //Health Management
    public void TakeDamage(int x){
        health -= x;

        if (health <= 0){
            //Lose
        }
    }

    public void Heal(int){
        health += x;
    }


    public int GetHealth(){
        return health;
    }

    public int GetMaxHealth(){
        return maxHealth;
    }

    //Card Management:

}
