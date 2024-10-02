using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void TestLevel()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Junglelevel()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void Retrolevel()
    {
        SceneManager.LoadSceneAsync(5);
    }

    public void Spacelevel()
    {
        SceneManager.LoadSceneAsync(4);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
