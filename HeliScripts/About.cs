using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class About : MonoBehaviour
{ public void LoadAbout()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
  
    
    public void TurnStartMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }
    public void TurnEndMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }

    public void TurnFirstMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
    }

    public void TurnBack()
    {
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +3);
    }
}
