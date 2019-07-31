using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 1f;
    public float aiSpeedMultiplier = 0.8f;
    public int playerIndex = 1;

    public GameObject rightPaddle;

    void Awake()
    {
        if(ModeSelection.instance.modeSelected == "PVP")
        {
            rightPaddle.GetComponent<Paddle>().playerIndex = 2;
        }
        if (ModeSelection.instance.modeSelected == "PVE")
        {
            rightPaddle.GetComponent<Paddle>().playerIndex = 0;
        }
    }

    void Update()
    {
        float verticalMovement = Input.GetAxis("Vertical" + playerIndex);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, verticalMovement * speed);

        if (ModeSelection.instance.modeSelected == "PVE")
        {
            AIPaddle();
        }
    }

    public void AIPaddle()
    {
        if(GameController.instance.currentBall.transform.position.y > rightPaddle.transform.position.y)
        {
            rightPaddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0, aiSpeedMultiplier * speed);
        }
        if (GameController.instance.currentBall.transform.position.y < rightPaddle.transform.position.y)
        {
            rightPaddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -aiSpeedMultiplier * speed);
        }
    }
}
