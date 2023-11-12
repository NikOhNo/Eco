using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

    public enum CardType{Vessel, Environment, Bond};

    // [SerializeField] EffectsHandler effects;
    public List<CardEffect> effects;
    
    public CardType type;

    public string name;
    public string flavorText;
    public string effectText;
    //Also need sprite and way to handle effects

    void Awake()
    {
        
    }

    //Setters:
    public void SetName(string _name)
    {
        name = _name;
    }

    public void SetFlavor(string _flavor){
        flavorText  = _flavor;
    }

    public void SetEffectText(string _effect){
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
