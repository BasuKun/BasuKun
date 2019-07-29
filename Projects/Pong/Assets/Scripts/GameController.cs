using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject ballPrefab;
    public Text score1Text;
    public Text score2Text;
    public float scoreCoordinates = 3.4f;
    public Text winText;
    public GameObject endScreen;

    private Ball currentBall;
    public int score1 = 0;
    public int score2 = 0;

    void Start()
    {
        SpawnBall();
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

        if (score1 == 7 || score2 == 7)
        {
            EndGame(true);
        }
    }

    public void EndGame(bool finished)
    {
        endScreen.SetActive(true);
        Time.timeScale = 0.0f;

        if (score1 == 7)
        {
            winText.text = "P1 Won";
        }
        if (score2 == 7)
        {
            winText.text = "P2 Won";
        }
    }
}
