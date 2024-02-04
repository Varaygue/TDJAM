using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_MenuScript : MonoBehaviour
{
    public string sceneName;
    public FmodSound buttonPress;
    public FmodSound MenuTheme;

    public void Start()
    {
        MenuTheme.Play();
    }
    public void PlayScene(string sceneName)
    {
        buttonPress.Play();
        SceneManager.LoadScene(sceneName);
    }
    public void QuitButton()
    {
        buttonPress.Play();
        Application.Quit();
    }
}
