using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuFunction : MonoBehaviour
{

    public GameObject pauseMenuUI;

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
