using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BondCard : Card
{

    void Awake()
    {
        base.type = Card.CardType.Bond;
    }

}
