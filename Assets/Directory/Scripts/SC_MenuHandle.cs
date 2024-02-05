using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_MenuHandle : MonoBehaviour
{
    public GameObject returnButton;
    public GameObject unitsMenu;
    public GameObject buildingsMenu;
    public GameObject unitsButton;
    public GameObject buildingsButton;
    public FmodSound buttonPress;
    public FmodSound buttonUnpress;
    public FmodSound GameTheme;

    public void Start()
    {
        GameTheme.Play(); 
    }
    public void OpenUnits()
    {
        buttonPress.Play();
        returnButton.SetActive(true);
        unitsMenu.SetActive(true);
        buildingsButton.SetActive(false);
        unitsButton.SetActive(false);
    }
    public void OpenBuildings()
    {
        buttonPress.Play();
        returnButton.SetActive(true);
        buildingsMenu.SetActive(true);
        buildingsButton.SetActive(false);
        unitsButton.SetActive(false);
    }

    public void ReturnButton()
    {
        buttonUnpress.Play();
        unitsMenu.SetActive(false);
        buildingsMenu.SetActive(false);
        returnButton.SetActive(false);
        buildingsButton.SetActive(true);
        unitsButton.SetActive(true);
    }

    public void RetryButton()
    {
        buttonPress.Play();
        SceneManager.LoadScene("SC_Test");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
