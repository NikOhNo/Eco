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

    void endOfTurn(){
        attackVal = initialAttackVal;
        currentToughness = maxToughness;
    }

    //Attack:
    public void setCurAttack(int x){
        attackVal = x;
    } 
    
    public void setPermaAttack(int x){
        initialAttackVal = x;
        attackVal = initialAttackVal;
    }

    public int getCurAttack(){
        return attackVal;
    }

    //Toughness
    public int getToughness(){
        return currentToughness;
    }

    public void takeDamage(int x){
        currentToughness -= x;
        if(currentToughness <= 0){
            //Die
        }
    }

    public void setToughness(int x){
        maxToughness = x;
        currentToughness = maxToughness;
    }

    //Summoning
    public bool isSummonable(int x){
        if(x >= summoningCost)   return true;
        
        return false;
    }

    public int getSacrificeVal(){
        return sacrificeValue;
    }
}
