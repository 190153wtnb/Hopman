using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    public void OnClickRetryButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickQuitButton()
    {
        Application.Quit();
    }
}