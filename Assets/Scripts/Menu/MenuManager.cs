using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneLoader.Instance.currentScene = "GameScene";
        GameManager.Instance.GamePlaying = true;
        SceneLoader.Instance.StartScene();
    }
    public void ReturnToMenu()
    {
        SceneLoader.Instance.currentScene = "MainMenuScene";
        GameManager.Instance.GamePlaying = false;
        SceneLoader.Instance.StartScene();
    }
    public void QuitGame()
    {
        GameManager.Instance.GamePlaying = false;
        Application.Quit();
    }

}