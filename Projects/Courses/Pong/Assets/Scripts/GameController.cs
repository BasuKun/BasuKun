using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject ballPrefab;
    public Text score1Text;
    public Text score2Text;
    public float scoreCoordinates = 3.4f;
    public Text winText;
    public GameObject endScreen;
    public int winCondition = 2;
    public bool initialBallSpawned = false;

    public Ball currentBall;
    public int score1 = 0;
    public int score2 = 0;

    public static GameController instance;

    void Start()
    {
        instance = this;
        Time.timeScale = 1.0f;
        score1 = 0;
        score2 = 0;
    }

    void SpawnBall()
    {
        GameObject ballInstance = Instantiate(ballPrefab, transform);

        currentBall = ballInstance.GetComponent<Ball>();
        currentBall.transform.position = Vector3.zero;

        score1Text.text = score1.ToString();
        score2Text.text = score2.ToString();
    }

    void Update()
    {
        if (Countdown.instance.countdownFinished == true && initialBallSpawned == false)
        {
            SpawnBall();
            initialBallSpawned = true;
        }

        if (currentBall != null)
        {
            if (currentBall.transform.position.x > scoreCoordinates)
            {
                score1++;
                Destroy(currentBall.gameObject);
                SpawnBall();
            }
            if (currentBall.transform.position.x < -scoreCoordinates)
            {
                score2++;
                Destroy(currentBall.gameObject);
                SpawnBall();
            }
        }

        if (score1 == winCondition || score2 == winCondition)
        {
            EndGame(true);
        }
    }

    public void EndGame(bool finished)
    {
        endScreen.SetActive(true);
        Time.timeScale = 0.0f;

        if (score1 == winCondition)
        {
            winText.text = "P1 Won";
        }
        if (score2 == winCondition)
        {
            winText.text = "P2 Won";
        }
    }

    public void OnRestartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void OnHomeButton()
    {
        SceneManager.LoadScene(0);
    }
}
