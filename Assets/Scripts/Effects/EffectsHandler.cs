using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsHandler : MonoBehaviour
{    
    
    void Awake()
    {
        
    }

    public void DrawCard(GameObject target, int drawn){ //Passes in player and number of cards drawn 

    }

    public void BuffAttack(VesselCard target, int change, bool perma){
        if(perma){
            target.SetPermaAttack(target.GetMaxAttack() + change);
        }else{
            target.SetCurAttack(target.GetCurAttack() + change);
        }
    }

    public void BuffTough(VesselCard target, int change, bool perma){
        if(perma){
            target.SetToughness(target.GetMaxToughness() + change);
        }else{
            target.TakeDamage(-change);
        }
    }

    public void BuffBoth(VesselCard target, int change, bool perma){
        BuffAttack(target, change, perma);
        BuffTough(target, change, perma);
    }

    public void HealPlayer(GameObject target, int healing){

    }

    public void DamagePlayer(GameObject target, int damage){

    }

    public void DestroyCard(Card target){

    }
}
