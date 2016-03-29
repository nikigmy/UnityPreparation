﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuSceneScript : MonoBehaviour 
{
    public void OnPlayGame()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void OnQuitClicked()
    {
        Application.Quit();
    }
}
