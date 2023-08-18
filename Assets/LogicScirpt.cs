using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScirpt : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;
    [ContextMenu("Increase score")]
    public void addScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score.ToString();
        

    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void home()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
