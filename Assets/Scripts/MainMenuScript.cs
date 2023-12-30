using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{

    public void Start()
    {
        // Plays the main menu theme
        FindObjectOfType<AudioManager>().Play("MainMenuTheme");

    }
    public void PlayGame()
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        // Quits the game
        Application.Quit();
    }
}
