using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuToggle : MonoBehaviour
{
    public RectTransform rectTransform;
    public Vector2 currentPosition;
    public Vector2 targetPosition;
    public float moveSpeed; 
    public bool isMoving = false;
    private bool isOpening = false;

    public static MenuToggle Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void MoveUIOnClick()
    {
        isMoving = true;
        StartCoroutine(MoveUIOverTime());
    }

    private IEnumerator MoveUIOverTime()
    {
        isOpening = currentPosition.x < targetPosition.x ? true : false;

        Vector2 oldPosition = currentPosition;
        float checkPosOffset = isOpening ? 0 : -1;
        float timeElapsed = 0f;
        float totalDistance = Vector2.Distance(rectTransform.anchoredPosition, targetPosition);
        float totalTime = totalDistance / moveSpeed;

        while (isMoving)
        {
            timeElapsed += Time.deltaTime;
            rectTransform.anchoredPosition = Vector2.Lerp(rectTransform.anchoredPosition, targetPosition, timeElapsed / totalTime);
            yield return null;

            if ((int)rectTransform.anchoredPosition.x + checkPosOffset == targetPosition.x)
            {
                rectTransform.anchoredPosition = targetPosition;
                isMoving = false;
            }
        }

        targetPosition = oldPosition;
        currentPosition = rectTransform.anchoredPosition;

        yield return null;
    }
}
