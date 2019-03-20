using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
 public void StartGame()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1;
    }
 public void LoadIns1()
    {
        SceneManager.LoadScene(1);
    }
 public void LoadIns2()
    {
        SceneManager.LoadScene(2);
    }
 public void LoadIns3()
    {
        SceneManager.LoadScene(3);
    }
 public void GameOverSceneSwitcher()
    {
        SceneManager.LoadScene(0);
    }
}
