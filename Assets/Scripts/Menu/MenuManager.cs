using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneLoader.Instance.StartScene();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}