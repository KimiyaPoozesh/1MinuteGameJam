using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void Menu()
    {
        SceneManager.LoadScene("menu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
