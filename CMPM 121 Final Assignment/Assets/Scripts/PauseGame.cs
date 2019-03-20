using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject PauseButton, PausePanel;

    public void Start()
    {
        PausePanel.SetActive(false);
        PauseButton.SetActive(true);
    }
    public void Pause()
    {
        PausePanel.SetActive(true);
        PauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void Unpause()
    {
        PausePanel.SetActive(false);
        PauseButton.SetActive(true);
        Time.timeScale = 1;
    }
}
