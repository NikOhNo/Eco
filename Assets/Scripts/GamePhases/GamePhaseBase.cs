using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GamePhaseBase : IGameplayPhase
{
    protected GameManager gameManager;
    protected Player player;

    public GamePhaseBase(GameManager gameManager)
    {
        this.gameManager = gameManager;
    }

    public virtual void EnterPhase(Player player)
    {
        this.player = player;
    }
    public abstract void ExitPhase();
    public abstract void PerformPhase();
}
