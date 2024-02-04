using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MenuHandle : MonoBehaviour
{
    public GameObject unitsMenu;
    public FmodSound buttonPress;
    public void OpenUnits()
    {
       // buttonPress.Play();
        unitsMenu.SetActive(true);

    }
}
