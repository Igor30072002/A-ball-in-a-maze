using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingLevel : MonoBehaviour
{
    private int currentLevel;

    void Start()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentLevel);
    }

    public void NextLevel()
    {
        Time.timeScale = 1;
        if (currentLevel == 4) SceneManager.LoadScene(1);
        else SceneManager.LoadScene(currentLevel + 1);
    }

    public void ToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
