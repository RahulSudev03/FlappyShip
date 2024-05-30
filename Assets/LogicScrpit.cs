using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScrpit : MonoBehaviour
{
    public int playerScore;

    public Text scoreText;

    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToBeAdded)
    {
        playerScore = playerScore + scoreToBeAdded;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
