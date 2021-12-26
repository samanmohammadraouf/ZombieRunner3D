using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOver;

    private void Start()
    {
        gameOver.enabled = false;
    }

    public void HandlerDeath()
    {
        gameOver.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
