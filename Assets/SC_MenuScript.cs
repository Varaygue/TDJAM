using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_MenuScript : MonoBehaviour
{
    public string sceneName;

    public void PlayScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
