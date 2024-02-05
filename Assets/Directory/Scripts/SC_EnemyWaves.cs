using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_EnemyWaves : MonoBehaviour
{
    public Transform[] spawnPoints; // Array to store your transforms
    public GameObject prefabToSpawn;
    public float spawnCooldown = 5;

    void Start()
    {
        StartCoroutine(SpawnPrefabs());
    }

    IEnumerator SpawnPrefabs()
    {
        while (true) // You may want to add a condition to exit the loop
        {
            Transform randomTransform = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(prefabToSpawn, randomTransform.position, randomTransform.rotation);

            yield return new WaitForSeconds(spawnCooldown); // Adjust the delay as needed
        }
    }
}
