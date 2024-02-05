using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Farm : MonoBehaviour
{
    public float goldCountdown = 5;
    private ResourcesManager resourcesManager;
    public FmodSound GoldGain;

    // Update is called once per frame
    void Start()
    {
        resourcesManager = GameObject.FindWithTag("GM").GetComponent<ResourcesManager>();
    }
    void Update()
    {
        goldCountdown -= Time.deltaTime;

        if(goldCountdown<=0)
        {
            resourcesManager.goldAmount = resourcesManager.goldAmount+25;
            GoldGain.Play();
            goldCountdown=5;
        }
    }
}
