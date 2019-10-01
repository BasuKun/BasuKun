using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public int[] playerScores;
    [SerializeField]
    private float gameTime;
    [SerializeField]
    private TextMeshProUGUI[] playerScoresText;
    [SerializeField]
    private TextMeshProUGUI timerText, playerWinnerText;
    [SerializeField]
    private GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        playerScores = new int[2];
    }

    public void AddPoints(int player, int amount)
    {
        playerScores[player] += amount;
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        gameTime -= Time.deltaTime;
        // update timer text
        timerText.text = gameTime.ToString("00.0");
        if (gameTime <= 0)
        {
            // game over!
            Time.timeScale = 0;
            int winner = playerScores[0] > playerScores[1] ? 1 : 2;
            gameOverPanel.SetActive(true);
            playerWinnerText.text = string.Format("Player {0} wins!", winner);
        }
    }

    private void UpdateUI()
    {
        // update ui text
        playerScoresText[0].text = playerScores[0].ToString();
        playerScoresText[1].text = playerScores[1].ToString();
    }
}
