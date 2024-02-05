using UnityEngine;

public class SC_SpawnUnits : MonoBehaviour
{
    public GameObject archerPrefab;
    public GameObject farmPrefab;
    public ResourcesManager resourcesManager;
    public SC_TileUsage tileUsage;
    public GameObject tilesObjects;
    public bool archerSelected=false;

    void Start()
    {
        tileUsage =  tilesObjects.GetComponent<SC_TileUsage>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&archerSelected)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                SC_TileUsage tileUsage = hit.collider.GetComponent<SC_TileUsage>();
                if (hit.collider.CompareTag("Tile"))
                {
                    if(resourcesManager.goldAmount>=25 && !tileUsage.tileUsed)
                    {
                     float yPosition = 1;
                    Vector3 tileCenter = hit.collider.bounds.center;
                    Vector3 spawnPosition = new Vector3(tileCenter.x, yPosition, tileCenter.z);
                    Instantiate(archerPrefab, spawnPosition, Quaternion.identity);
                    resourcesManager.goldAmount = resourcesManager.goldAmount-25;
                    }
                    else if(resourcesManager.goldAmount>=25 && tileUsage.tileUsed)
                    {
                        Debug.Log("Tile in usage");
                    }
                    else
                    {
                        Debug.Log("Not enough coins !");
                    }
                }
            }
        }
    }
}
