using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsHandler : MonoBehaviour
{

    enum Effect{Draw, BuffAttack, BuffTough, BuffBoth, HealPlayer, DamagePlayer, DestroyCard}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DrawCard(GameObject target, int drawn){ //Passes in player and number of cards drawn 
        
    }

    public void BuffAttack(Card target, int change){

    }

    public void BuffTough(Card target, int change){

    }

    public void BuffBoth(Card target, int change){
        BuffAttack(target, change);
        BuffTough(target, change);
    }

    public void HealPlayer(GameObject target, int healing){

    }

    public void DamagePlayer(GameObject target, int damage){

    }

    public void DestroyCard(Card target){

    }
}
