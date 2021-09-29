using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDirector : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickRetryButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickQuitButton()
    {
        Application.Quit();
    }
}