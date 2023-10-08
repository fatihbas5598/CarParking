using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject settingsMenu;


    public void MainMenuPlayGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void MainMenuSetting()
    {
        settingsMenu.SetActive(true);
    }

    public void MainMenuSettingBack()
    {
        settingsMenu.SetActive(false);

    }

    public void MainMenuExit()
    {
        Application.Quit();
    }

    public void WinPanelNextLevel1()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }

    public void WinPanelNextLevel2()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }

    public void WinPanelNextLevel3()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }

    public void WinPanelNextLevel4()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
    }

    public void WinPanelNextLevel5()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void WinPanelMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LostPanelTryAgain()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void LostPanelMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
