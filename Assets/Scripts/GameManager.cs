using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Set Variables
    public float gameOverDelay;

    // When the player is killed, wait to call the Game Over scene
    void OnPlayerDied()
    {
        Invoke("GameOver", gameOverDelay);
    }

    // When the game is over, the game over screen shows up
    void GameOver()
    {
        SceneManager.LoadScene("Game Over Screen");
    }
}
