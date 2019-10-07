using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public int[] playerScores;
    [SerializeField]
    private float gameTime;
    public Text[] playerScoresText;
    public Text timerText, playerWinnerText;
    [SerializeField]
    private GameObject gameOverPanel;
    public bool gamePaused;

    private int winner;

    void Start()
    {
        Time.timeScale = 1f;
        playerScores = new int[2];
        gamePaused = false;
    }

    void Update()
    {
        gameTime -= Time.deltaTime;
        timerText.text = gameTime.ToString("00");
        if (gameTime <= 0)
        {
            Time.timeScale = 0;

            if (playerScores[0] > playerScores[1])
            {
                winner = 1;
            }
            if (playerScores[0] < playerScores[1])
            {
                winner = 2;
            }
            if (playerScores[0] == playerScores[1])
            {
                winner = 0;
            }

            gameOverPanel.SetActive(true);
            gamePaused = true;

            if (winner == 1 || winner == 2)
            {
                playerWinnerText.text = string.Format("Player {0} wins!", winner);
                playerWinnerText.color = winner == 1 ? new Color(0.5f, 0.7f, 0.1f) : new Color(0.8f, 0.5f, 0.06f);
            }
            else
            {
                playerWinnerText.text = string.Format("Draw!");
                playerWinnerText.color = new Color(0.64f, 0.65f, 0.62f);
            }
        }
    }

    public void AddPoints(int player, int amount)
    {
        playerScores[player] += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        playerScoresText[0].text = playerScores[0].ToString();
        playerScoresText[1].text = playerScores[1].ToString();
    }

    public void OnRetryClick()
    {
        gamePaused = false;
        SceneManager.LoadScene(0);
    }
}
