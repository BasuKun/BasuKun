using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InfoPopupHandler : MonoBehaviour
{
    private float timeToAppear = 1f;
    public bool isStillHoveringButton = false;
    public RectTransform canvasRect;
    public GameObject infoPopup;
    public RectTransform rect;
    public TextMeshProUGUI infoText;

    public static InfoPopupHandler Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public IEnumerator SpawnInfoPopup(Transform pos, string info)
    {
        infoPopup.transform.position = new Vector3(-1000, 1000);
        infoText.text = "";
        this.isStillHoveringButton = true;

        yield return new WaitForEndOfFrame();

        for (float timer = timeToAppear; timer > -1; timer -= Time.deltaTime)
        {
            if (timer <= 0 && this.isStillHoveringButton)
            {
                infoPopup.SetActive(true);
                infoText.text = info;

                yield return new WaitForEndOfFrame();

                Vector3 attemptedPos = new Vector3(pos.position.x, pos.position.y + 50, pos.position.z);

                if (attemptedPos.x + rect.rect.width > canvasRect.rect.width)
                {
                    attemptedPos.x = canvasRect.rect.width - rect.rect.width / 2 - 5;
                }

                if (attemptedPos.x - rect.rect.width / 2 <= 0)
                {
                    attemptedPos.x = rect.rect.width / 2 + 25;
                }

                if (attemptedPos.y + rect.rect.height > canvasRect.rect.height)
                {
                    attemptedPos.y = canvasRect.rect.height - rect.rect.height;
                }

                yield return new WaitForEndOfFrame();

                infoPopup.transform.position = attemptedPos;
                yield break;
            }
            else if (!this.isStillHoveringButton)
            {
                yield break;
            }

            yield return null;
        }
    }

    public void RefreshText(string info)
    {
        infoText.text = info;
    }

    public void DespawnInfoPopup()
    {
        StopCoroutine("SpawnInfoPopup");
        this.isStillHoveringButton = false;
        infoText.text = "";
        infoPopup.transform.position = new Vector3(-1000, 1000);
        infoPopup.SetActive(false);
    }
}
