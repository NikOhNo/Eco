using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newCard", menuName = "New Card")]
public class CardSO : ScriptableObject
{
    // Card Type
    public enum CardType { Vessel, Environment, Bond };

    //-- Serialized Fields
    // [SerializeField] EffectsHandler effects;
    [SerializeField] List<CardEffect> effects;
    [SerializeField] CardType type;

    [SerializeField] string cardName;
    [SerializeField] string flavorText;
    [SerializeField] string effectText;
    [SerializeField] Sprite sprite;

    //-- Properties
    public List<CardEffect> Effects => effects;
    public CardType Type => type;
    public string CardName => cardName;
    public string FlavorText => flavorText;
    public string EffectText => effectText;
    public Sprite Sprite => sprite; 
}
