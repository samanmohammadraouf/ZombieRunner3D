using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceLoader : MonoBehaviour
{
    public void LoadGameAgain()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }

    public void quit()
    {
        Application.Quit();
    }
}
