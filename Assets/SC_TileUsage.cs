using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_TileUsage : MonoBehaviour
{
    public bool tileUsed;
    // Start is called before the first frame update
    void Start()
    {
        tileUsed = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            tileUsed=true;
        }
    }
}
