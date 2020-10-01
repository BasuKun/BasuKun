using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LongClickInstantButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool pointerDown;
    private float pointerDownTimer = 0.5f;
    private float timeNeeded = 0.5f;
    private float acceleration = 1.05f;
    private float maxAcceleration = 0.05f;

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
                    timeNeeded = Mathf.Clamp(timeNeeded / acceleration, maxAcceleration, 0.5f);
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
        pointerDownTimer = 0.5f;
        timeNeeded = 0.5f;
        fillImage.fillAmount = (float)GameManager.Instance.absorbedSnowflakes / 10f;
    }

}