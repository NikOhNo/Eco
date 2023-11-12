using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    [SerializeField] List<Card> deck;

    void Awake(){
        deck = Shuffle(deck);
    }

    public Card DrawCard(){
        Card temp = deck[0];
        deck.RemoveAt(0);

        return temp;
    }


    private List<Card> Shuffle(List<Card> cards){
        int n = cards.Count;
        Card temp;

        for(int i = 0; i < n; i++){
            int k = (int)(Random.value*(n+1));
            temp = cards[i];
            cards[i] = cards[k];
            cards[k] = temp;
        }
        return cards;
    }



}
