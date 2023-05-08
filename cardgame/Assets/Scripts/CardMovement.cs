using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardMovement : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
  public Transform defaultParent;
  void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
  {
    defaultParent = transform.parent;
    transform.SetParent(defaultParent.parent, false);
    GetComponent<CanvasGroup>().blocksRaycasts = false;
  }
  public void OnDrag(PointerEventData eventData)
  {
    transform.position = eventData.position;
  }

  void IEndDragHandler.OnEndDrag(PointerEventData eventData)
  {
    transform.SetParent(defaultParent, false);
    GetComponent<CanvasGroup>().blocksRaycasts = true;
  }
}
