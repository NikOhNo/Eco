using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandbyPhase : GamePhaseBase
{
    public StandbyPhase(GameManager gameManager) : base(gameManager)
    {
    }

    public override void EnterPhase(Player player)
    {
        base.EnterPhase(player);
        throw new System.NotImplementedException();
    }

    public override void ExitPhase()
    {
        throw new System.NotImplementedException();
    }

    public override void PerformPhase()
    {
        throw new System.NotImplementedException();
    }
}
