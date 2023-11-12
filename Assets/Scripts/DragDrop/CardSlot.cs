using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardSlot : MonoBehaviour, IDropHandler
{
    [SerializeField]
    Player player;

    [SerializeField]
    Card heldCard;

    [SerializeField]
    CardSO.CardType expectedType;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("drop");
        if (eventData.pointerDrag != null)
        {
            Card card = eventData.pointerDrag.GetComponent<Card>();

            TryRecieveCard(card, eventData.pointerDrag);
        }
    }

    private void TryRecieveCard(Card card, GameObject cardObj)
    {
        if (card != null && heldCard == null)
        {
            if (card.CardInfo.Type == expectedType)
            {
                cardObj.transform.SetParent(this.transform);
                cardObj.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                heldCard = card;

                // inform player that card was recieved
                player.PlayCard(card);

                // set it so card can no longer drag
                cardObj.GetComponent<DragDrop>().Slotted = true;
            }
            else
            {
                // TODO: reject card

            }
        }
    }
}
