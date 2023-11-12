using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPhase : GamePhaseBase
{
    public EndPhase(GameManager gameManager) : base(gameManager)
    {
    }

    public override void EnterPhase(Player player)
    {
        base.EnterPhase(player);

        foreach (VesselCard vessel in player.getPlots())
        {
            vessel.ResetVessel();
        }

        gameManager.SwitchPlayer();
        gameManager.SwitchPhase(gameManager.DrawPhase);
    }

    public override void PerformPhase()
    {
    }

    public override void ExitPhase()
    {
    }
}
