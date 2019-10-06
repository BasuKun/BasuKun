using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public int[] playerScores;
    [SerializeField]
    private float gameTime;
    public Text[] playerScoresText;
    public Text timerText, playerWinnerText;
    [SerializeField]
    private GameObject gameOverPanel;

    private int winner;

    void Start()
    {
        playerScores = new int[2];
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

            if (winner == 1 || winner == 2)
            {
                playerWinnerText.text = string.Format("Player {0} wins!", winner);
            }
            else
            {
                playerWinnerText.text = string.Format("Draw!");
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
        // TO COMPLETE!!!!
    }
}
