using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LongClickButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool pointerDown;
    private float pointerDownTimer;

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
        if (pointerDown && PileHandler.Instance.pileDict.Count > 0)
        {
            InfoPopupHandler.Instance.DespawnInfoPopup();
            pointerDownTimer += Time.deltaTime;
            if (pointerDownTimer >= GameManager.Instance.shovelSpeed * Powerups.Instance.ShovelMaster())
            {
                if (onLongClick != null)
                    onLongClick.Invoke();

                if (PileHandler.Instance.pileDict.Count > 0)
                {
                    pointerDownTimer = 0;
                }
                else
                {
                    Reset();
                }
            }
            fillImage.fillAmount = pointerDownTimer / (GameManager.Instance.shovelSpeed * Powerups.Instance.ShovelMaster());
        }
    }

    private void Reset()
    {
        pointerDown = false;
        pointerDownTimer = 0;
        fillImage.fillAmount = pointerDownTimer / (GameManager.Instance.shovelSpeed * Powerups.Instance.ShovelMaster());
    }

}