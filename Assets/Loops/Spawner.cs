using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab; // the prefab that will sapwn in game.
    public int spawnCount = 5; // amount of prefab spawn in.
    public float spawnOffset = 1.5f; // each object position, increase X position.

     void Start()
    {
        if (spawnPrefab != null)
        {
            SpawnEnemies();
        }
        else
        {
            Debug.LogError("Cannot spawn enemies! Prefab is missing.");
        }

    }

    void SpawnEnemies()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            float xPos = i * spawnOffset;
            Vector3 spawnPos = new Vector3(xPos, 0, 0);

            Instantiate(spawnPrefab, spawnPos, Quaternion.identity);
        }
    }
}
