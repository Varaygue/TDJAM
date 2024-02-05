using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Defeat : MonoBehaviour
{
    public GameObject defeatScreen;
    public FmodSound Defeat;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            PlayerDefeat();
        }
    }

    public void PlayerDefeat()
    {
        Defeat.Play();
        Time.timeScale=0;
        defeatScreen.SetActive(true);
    }
}
