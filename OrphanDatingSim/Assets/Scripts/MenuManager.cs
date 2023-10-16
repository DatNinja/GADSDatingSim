using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Menu;
    public GameObject About;

    public void PlayGame()
    {
        SceneManager.LoadScene("John");
    }

    public void ViewAbout()
    {
        Menu.SetActive(false);
        About.SetActive(true);
    }

    public void Back()
    {
        Menu.SetActive(true);
        About.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
