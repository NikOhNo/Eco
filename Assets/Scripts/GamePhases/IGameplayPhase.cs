using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameplayPhase
{
    void EnterPhase(Player player);
    void PerformPhase();
    void ExitPhase();
}
