using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public int MainMenu;
    public int SammyLawrence;
    public int SettingsMenu;
    public int Load;
    public int AboutTheAuthors;
  

    public void ToMainMenu()
    {

        SceneManager.LoadScene(MainMenu);

    }


    public void ToSammyLawrence()
    {

        SceneManager.LoadScene(SammyLawrence);

    }

    public void ToSettings()
    {

        SceneManager.LoadScene(SettingsMenu);

    }

    public void ToLoad()
    {

        SceneManager.LoadScene(Load);

    }

    public void ToAboutTheAuthors()
    {

        SceneManager.LoadScene(AboutTheAuthors);

    }

    public void ExitGame()
    {

        Application.Quit();

    }
}













/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void Settings()
    {
        SceneManager.LoadScene(3);
    }

    public void Load()
    {
        SceneManager.LoadScene(4); 
    }

    public void Abouttheauthors()
    {
        SceneManager.LoadScene(5);
    }

    public void Quit()
    {
        Application.Quit();
    }

}*/
