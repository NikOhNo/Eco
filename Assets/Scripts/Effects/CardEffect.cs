using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newEffect", menuName = "Card Effect")]

public class CardEffect : ScriptableObject //Purely Informational
{
    public enum Activation{OnPlay, PerTurn, OnDeath};
    public enum Effect{Draw, BuffAttack, BuffTough, BuffBoth, HealPlayer, DamagePlayer, DestroyCard}; //
    public enum Target{Any, Vessel, Player}

    //Variables
    [SerializeField] Effect effect;
    [SerializeField] Activation activationTime;
    [SerializeField] Target target;
    [SerializeField] int effectVal;
 
    //public int GetEffect => effect;

    //Getters and Setters
    public int getEffect(){
        return (int) effect;
    }

    public int getActivation(){
        return (int)activationTime;
    }

    public int getTarget(){
        return (int)target;
    }

    public int getEffectVal(){
        return effectVal;
    }

    

}
