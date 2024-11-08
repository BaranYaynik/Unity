using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI ScoreText;






    public void updateScore()
    {
        score++;
        ScoreText.text = score.ToString();

    }
    public void restartgame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
