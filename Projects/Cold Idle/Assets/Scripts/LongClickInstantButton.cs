using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LongClickInstantButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool pointerDown;
    private float pointerDownTimer = 1;
    private float timeNeeded = 1;

    public UnityEvent onLongClick;

    public Image fillImage;

    public void OnPointerDown(PointerEventData eventData)
    {
        pointerDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Reset();
    }

    private void Update()
    {
        if (pointerDown && GameManager.Instance.snowflakesAmount > 0)
        {
            pointerDownTimer += Time.deltaTime;
            if (pointerDownTimer >= timeNeeded)
            {
                if (onLongClick != null)
                {
                    onLongClick.Invoke();
                    fillImage.fillAmount = (float)GameManager.Instance.absorbedSnowflakes / 10f;
                    timeNeeded /= 1.3f;
                }
                if (GameManager.Instance.snowflakesAmount > 0)
                {
                    pointerDownTimer = 0;
                }
                else
                {
                    Reset();
                }
            }
        }
    }

    private void Reset()
    {
        pointerDown = false;
        pointerDownTimer = 1;
        timeNeeded = 1;
        fillImage.fillAmount = (float)GameManager.Instance.absorbedSnowflakes / 10f;
    }

}