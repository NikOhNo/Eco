using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField]
    private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    Vector2 origAnchorPos;
    Transform origParent;

    public bool Slotted { get; set; } = false;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        origAnchorPos = rectTransform.anchoredPosition;
        origParent = transform.parent.transform;
        transform.SetParent(canvas.transform);
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 0.6f;
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        if (!Slotted)
        {
            rectTransform.anchoredPosition = origAnchorPos;
            transform.SetParent(origParent);
        }
        else
        {
            this.gameObject.GetComponent<Card>().onField = true;
            this.enabled = false;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }
}
