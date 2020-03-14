using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public BubbleLaunch bubbleLaunch;
    public GameObject chargeBar;
    public Image chargeFiller;
    private Color chargeColor = new Color(0.3415807f, 0.7169812f, 0.6826473f);

    public static GameUI instance;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void FixedUpdate()
    {
        ChargeBarFiller();
    }

    void ChargeBarFiller()
    {
        if (bubbleLaunch.dashCharge <= 0)
        {
            chargeBar.SetActive(false);
        }
        else if (bubbleLaunch.dashCharge > 0 && bubbleLaunch.dashCharge < 1)
        {
            chargeBar.SetActive(true);
            Vector2 charPos = Camera.main.WorldToScreenPoint(bubbleLaunch.transform.position);
            chargeBar.transform.position = new Vector2(charPos.x, charPos.y + 40f);
            chargeFiller.color = chargeColor;
            chargeFiller.fillAmount = bubbleLaunch.dashCharge;
        }
        else if (bubbleLaunch.dashCharge == 1)
        {
            chargeFiller.fillAmount = bubbleLaunch.dashCharge;
            Vector2 charPos = Camera.main.WorldToScreenPoint(bubbleLaunch.transform.position);
            chargeBar.transform.position = new Vector2(charPos.x, charPos.y + 40f);
            chargeFiller.color = Color.white;
        }
    }
}
