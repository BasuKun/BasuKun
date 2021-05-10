using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EraseSaveButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool pointerDown;
    private float pointerDownTimer;

    public UnityEvent onLongClick;

    public Image fillImage;

    public void OnPointerDown(PointerEventData eventData)
    {
        this.gameObject.GetComponent<OnMouseOverHandler>().DespawnPopup();
        pointerDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Reset();
    }

    private void Update()
    {
        if (pointerDown)
        {
            InfoPopupHandler.Instance.DespawnInfoPopup();
            pointerDownTimer += Time.deltaTime;
            if (pointerDownTimer >= 2f)
            {
                if (onLongClick != null)
                    onLongClick.Invoke();

                Reset();
            }
            fillImage.fillAmount = pointerDownTimer / 2f;
        }
    }

    private void Reset()
    {
        pointerDown = false;
        pointerDownTimer = 0;
        fillImage.fillAmount = pointerDownTimer / 2f;
    }

    public void DeleteSaveFile()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }
}
