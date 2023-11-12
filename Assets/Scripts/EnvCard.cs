using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvCard : Card
{

    void Awake()
    {
        base.type = Card.CardType.Environment;
    }

    public void FieldEffect(){
        
    }

}
