using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void PlayGame()
    {
        SceneManager.LoadScene("Cutscene");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void FirstLevel()
    {
        SceneManager.LoadScene("dont fall in lava");
    }

    public void SecondLevel()
    {
        SceneManager.LoadScene("Deathslide");
    }

    public void ThirdLevel()
    {
        SceneManager.LoadScene("Deathslide 2");
    }

    public void fourthLevel()
    {
        SceneManager.LoadScene("dont fall in lava 2");
    }

    public void fifthLevel()
    {
        SceneManager.LoadScene("Holemaze");
    }

    public void GameWorld()
    {
        SceneManager.LoadScene("world");
    }

    public void DeathSlide()
    {
        
    }

    public void Holemaze()
    {
        SceneManager.LoadScene("Holemaze");
    }

    public void DeathSlide4()
    {
        SceneManager.LoadScene("Deathslide 4");
    }

    public void  QuitGame()
    {
        Application.Quit();
    }
}
