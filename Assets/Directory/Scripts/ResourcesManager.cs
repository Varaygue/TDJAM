using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Resources;

public class ResourcesManager : MonoBehaviour
{
    public int goldAmount;
    public TMP_Text goldDisplay;
    public int woodAmount;
    public TMP_Text woodDisplay;
    private float goldCountdown = 2;

    void Update()
    {
    
            goldCountdown -= Time.deltaTime;

            if (goldCountdown <= 0)
            {
                goldAmount = goldAmount + 5;
                goldCountdown = 2;
            }
  
        goldDisplay.text = goldAmount.ToString();
        woodDisplay.text = woodAmount.ToString();
    }
}