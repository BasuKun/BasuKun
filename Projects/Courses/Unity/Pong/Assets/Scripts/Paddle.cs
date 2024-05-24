using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 1f;
    public float aiSpeedMultiplier = 0.8f;
    public float finalAIMultiplier;
    public int playerIndex = 1;
    public float ballVelocityComparison;

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
            if (GameController.instance.currentBall.GetComponent<Rigidbody2D>().velocity.x > 0)
            {
                AIPaddle();
            }
        }
    }

    public void AIPaddle()
    {
        BallVelocityPositive();
        if (GameController.instance.currentBall.transform.position.y > rightPaddle.transform.position.y)
        {
            if (ballVelocityComparison <= aiSpeedMultiplier * speed)
            {
                finalAIMultiplier = aiSpeedMultiplier * speed;
                finalAIMultiplier = Mathf.Clamp(aiSpeedMultiplier * speed, GameController.instance.currentBall.GetComponent<Rigidbody2D>().velocity.y, GameController.instance.currentBall.GetComponent<Rigidbody2D>().velocity.y);
                rightPaddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0, finalAIMultiplier);
            }
            if (ballVelocityComparison > aiSpeedMultiplier * speed)
            {
                finalAIMultiplier = aiSpeedMultiplier * speed;
                finalAIMultiplier = Mathf.Clamp(aiSpeedMultiplier * speed, aiSpeedMultiplier * speed, aiSpeedMultiplier * speed);
                rightPaddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0, finalAIMultiplier);
            }
        }
        if (GameController.instance.currentBall.transform.position.y < rightPaddle.transform.position.y)
        {
            if (ballVelocityComparison <= aiSpeedMultiplier * speed)
            {
                finalAIMultiplier = -aiSpeedMultiplier * speed;
                finalAIMultiplier = Mathf.Clamp(-aiSpeedMultiplier * speed, GameController.instance.currentBall.GetComponent<Rigidbody2D>().velocity.y, GameController.instance.currentBall.GetComponent<Rigidbody2D>().velocity.y);
                rightPaddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0, finalAIMultiplier);
            }
            if (ballVelocityComparison > aiSpeedMultiplier * speed)
            {
                finalAIMultiplier = -aiSpeedMultiplier * speed;
                finalAIMultiplier = Mathf.Clamp(-aiSpeedMultiplier * speed, -aiSpeedMultiplier * speed, -aiSpeedMultiplier * speed);
                rightPaddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0, finalAIMultiplier);
            }
        }
    }

    public void BallVelocityPositive()
    {
        if (GameController.instance.currentBall.GetComponent<Rigidbody2D>().velocity.y < 0)
        {
            ballVelocityComparison = GameController.instance.currentBall.GetComponent<Rigidbody2D>().velocity.y * -1;
        }
        else
        {
            ballVelocityComparison = GameController.instance.currentBall.GetComponent<Rigidbody2D>().velocity.y;
        }
    }
}
