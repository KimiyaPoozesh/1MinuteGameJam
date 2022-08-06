using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public void Next()
    {
     //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
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
