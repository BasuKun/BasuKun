using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHighlight : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text theText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        theText.color = new Color(0.5f, 1f, 0.6f, 1f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        theText.color = new Color(0f, 1f, 0.1098039f, 1f);
    }
}