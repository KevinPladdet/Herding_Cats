using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CatTitle : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    CatHandler ch;

    void Awake()
    {
        ch = GameObject.FindObjectOfType<CatHandler>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ch.SetDraggingState(this.transform.gameObject, true);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ch.SetDraggingState(this.transform.gameObject, false);
    }
}
