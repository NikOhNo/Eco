using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VesselCard : Card
{   

    [SerializeField] private int attackVal;
    [SerializeField] private int initialAttackVal;
    [SerializeField] private int maxToughness;
    [SerializeField] private int currentToughness;
    [SerializeField] private int summoningCost;
    [SerializeField] private int sacrificeValue;

    // Start is called before the first frame update
    void Awake()
    {   
        attackVal = initialAttackVal;
        currentToughness = maxToughness;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EndOfTurn(){
        attackVal = initialAttackVal;
        currentToughness = maxToughness;
    }

    //Attack:
    public void SetCurAttack(int x){
        attackVal = x;
    } 
    
    public void SetPermaAttack(int x){
        initialAttackVal = x;
        attackVal = initialAttackVal;
    }

    public int GetCurAttack(){
        return attackVal;
    }

    //Toughness
    public int GetToughness(){
        return currentToughness;
    }

    public void TakeDamage(int x){
        currentToughness -= x;
        if(currentToughness <= 0){
            //Die
        }
    }

    public void SetToughness(int x){
        maxToughness = x;
        currentToughness = maxToughness;
    }

    //Summoning
    public bool IsSummonable(int x){
        if(x >= summoningCost)   return true;
        
        return false;
    }

    public int GetSacrificeVal(){
        return sacrificeValue;
    }
}
