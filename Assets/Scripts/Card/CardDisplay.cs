using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    [SerializeField]
    CanvasGroup panel;

    [SerializeField]
    TMP_Text nameText;

    [SerializeField]
    Image cardImage;

    [SerializeField]
    TMP_Text effectText;

    [SerializeField]
    TMP_Text flavorText;

    [SerializeField]
    float openTime = 1f;

    private void Awake()
    {
        CloseDisplay();
    }

    public void OpenDisplay(CardSO card)
    {
        StopAllCoroutines();
        nameText.text = card.name;
        cardImage.sprite = card.Sprite;
        effectText.text = "[EFFECT]:\n" + card.EffectText;
        flavorText.text = card.FlavorText;
        panel.blocksRaycasts = true;
        StartCoroutine(OpenDisplayOverTime(openTime));
    }

    public void CloseDisplay()
    {
        StopAllCoroutines();
        panel.blocksRaycasts = false;
        panel.alpha = 0f;
    }

    IEnumerator OpenDisplayOverTime(float openTime)
    {
        float timeElapsed = 0f;

        while (timeElapsed < openTime)
        {
            panel.alpha = Mathf.Lerp(0, 1, timeElapsed / openTime);

            yield return null;
        }

        panel.alpha = 1;
    }    
}
