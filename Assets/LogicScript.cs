using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource audioSource;

    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        audioSource.Play();
    }

    public void restartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        Time.timeScale = 0;
        gameOverScreen.SetActive(true);

    }

    public void startGame()
    {
        // public static void LoadScene(int sceneBuildIndex, SceneManagement.LoadSceneMode mode = LoadSceneMode.Single);
        SceneManager.LoadScene(1);
    }
}
