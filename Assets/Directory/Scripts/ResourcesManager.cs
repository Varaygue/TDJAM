using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResourcesManager : MonoBehaviour
{
    public int goldAmount;
    public TMP_Text goldDisplay;
    public int woodAmount;
    public TMP_Text woodDisplay;
    void Update()
    {
        goldDisplay.text = goldAmount.ToString();
        woodDisplay.text = woodAmount.ToString();
    }
}