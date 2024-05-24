using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float timer = 3f;

    public bool countdownFinished;
    public bool countdownDisappear;

    public GameObject countdownObject;
    public Text countdown;

    public static Countdown instance;

    void Awake()
    {
        instance = this;
        countdownFinished = false;
        countdownDisappear = false;
        CountdownActive(true);
    }

    void FixedUpdate()
    {
        if (countdownDisappear == false)
        {
            timer -= Time.deltaTime;
            UpdateCountdown();
        }
    }

    public void UpdateCountdown()
    {
        if (timer > 2f)
        {
            countdown.text = "3";
        }
        if (timer > 1f && timer <= 2f)
        {
            countdown.text = "2";
        }
        if (timer > 0f && timer <= 1f)
        {
            countdown.text = "1";
        }
        if (timer <= 0f && timer > -2f)
        {
            countdown.text = "GO";
            countdownFinished = true;
        }
        if (timer <= -2f)
        {
            countdownObject.SetActive(false);
            countdownDisappear = true;
        }
    }

    public void CountdownActive(bool active)
    {
        countdownObject.SetActive(true);
    }
}
