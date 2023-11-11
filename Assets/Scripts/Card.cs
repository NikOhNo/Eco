using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

    enum CardType{Vessel, Environment, Bond};

    public string name;
    public string flavorText;
    public string effectText;
    //Also need sprite and way to handle effects

    void Awake()
    {

    }

    //Setters:
    public void setName(string _name)
    {
        name = _name;
    }

    public void setflavor(string _flavor){
        flavorText  = _flavor;
    }

    public void effectText(string _effect){
        effectText = _effect;
    }


    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
}
