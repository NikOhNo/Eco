using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    enum TurnPhase{Draw, Standby, Summon, Battle, End}

    [Header("Object Assignment")]
    [SerializeField] Player player;
    [SerializeField] Player enemyAI;


    bool playerTurn; //True for P1, False for P2 (AI)
    TurnPhase curPhase;
    bool gameOver;


    void Awake(){

    }

    public void RunGame(){
        while(!gameOver){
            if(playerTurn){
                curPhase = Draw;
                // drawCard(player);
                

            }else{

            }



        }
    }

    
    


}
