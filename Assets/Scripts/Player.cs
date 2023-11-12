using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [Header("Object Assignment")]
    [SerializeField] EffectsHandler handler;

    [Header("PlayerVariables")]
    [SerializeField] int health;
    [SerializeField] int maxHealth;

    [Header("Misc.")]
    [SerializeField] List<Card> inHand;
    [SerializeField] Deck deck;
    [SerializeField] List<VesselCard> onPlots;
    [SerializeField] Card environment;
    [SerializeField] Card heavenlyBond;


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

    public void Heal(int x){
        health += x;
    }


    public int GetHealth(){
        return health;
    }

    public int GetMaxHealth(){
        return maxHealth;
    }

    //Card Management:
    public List<Card> getHand(){
        return inHand;
    }
    
    public List<VesselCard> getPlots(){
        return onPlots;
    }

    public BondCard getBond(){
        return (BondCard) heavenlyBond;
    }

    public EnvCard getEnv(){
        return (EnvCard) environment;
    }

    public void DrawCard(){
        inHand.Add(deck.DrawCard());
    }

    //Using Cards:
    public void PlayCard(Card card){

        //On-Play effects can happen here

    }

}
