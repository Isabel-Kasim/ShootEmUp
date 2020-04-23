﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void QuitGame()
    {
        Debug.Log("App Quit Game");
        Application.Quit();
    }

    public void OptionMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }
}
