using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public int lives, score;
    [SerializeField]
    private Player player;
    [SerializeField]
    private Transform playerSpawnPoint;

    public void LoseLife()
    {
        if (lives > 0)
        {
            StartCoroutine(Respawn());
            // deduct life
        }
        else
        {
            // end the game
        }
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(2f);
        lives--;
        Instantiate(player.gameObject, playerSpawnPoint.position, Quaternion.identity);
        // update HUD show new life count
    }

    public void AddPoints(int points)
    {
        score += points;
        // update HUD
        // is the level complete?
    }
}