using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadIntro()
    {
        SceneManager.LoadScene("Introduction");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
       
}
