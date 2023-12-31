using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    public void PlayCard(Card card)
    {
        switch (card.CardInfo.Type)
        {
            case CardSO.CardType.Vessel:
                onPlots.Add(card as VesselCard);
                break;
            case CardSO.CardType.Environment:
                environment = card;
                break;
            case CardSO.CardType.Bond:
                heavenlyBond = card;
                break;
            default:
                Debug.LogError($"Unrecognized card type: {card.CardInfo.Type}. It could not be played.");
                break;
        }
    }
}
