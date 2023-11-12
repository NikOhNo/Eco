using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField]
    CardSO cardInfo;

    [SerializeField]
    CardDisplay fullscreenDisplay;

    [SerializeField]
    Image dragCardImage;

    RawImage rawImage;

    [SerializeField]
    Texture2D happyImage;
    public CardSO CardInfo => cardInfo;

    void Awake()
    {
        dragCardImage.sprite = cardInfo.Sprite;
    }
}
