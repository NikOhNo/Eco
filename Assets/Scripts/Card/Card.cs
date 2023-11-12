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

    public bool onField;

    [SerializeField]
    Texture2D happyImage;
    public CardSO CardInfo => cardInfo;

    void Awake()
    {
        dragCardImage.sprite = cardInfo.Sprite;
    }

    public void OpenFullScreen()
    {
        fullscreenDisplay.OpenDisplay(cardInfo);
    }
}
