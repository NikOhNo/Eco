using System;
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
    bool gameOver;

    IGameplayPhase currPhase;
    Player currPlayer;

    // Cached References to phases
    public DrawPhase DrawPhase { get; set; }
    public StandbyPhase StandbyPhase { get; set; }
    public SummonPhase SummonPhase { get; set; }
    public BattlePhase BattlePhase { get; set; }
    public EndPhase EndPhase { get; set; }

    void Awake(){
        DrawPhase = new(this);
        StandbyPhase = new(this);
        SummonPhase = new(this); 
        BattlePhase = new(this);
        EndPhase = new(this);

        SwitchPhase(DrawPhase);
        currPlayer = player;
    }

    private void Update()
    {
        currPhase.PerformPhase();
    }

    public void WinGame()
    {
        throw new NotImplementedException();
    }

    public void LoseGame()
    {
        throw new NotImplementedException();
    }

    public void SwitchPhase(GamePhaseBase phase)
    {
        currPhase?.ExitPhase();
        currPhase = phase;
        currPhase.EnterPhase(currPlayer);
    }

    public void SwitchPlayer()
    {
        if (currPlayer == player)
        {
            currPlayer = enemyAI;
        }
        else
        {
            currPlayer = player;
        }    
    }
}
