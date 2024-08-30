using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefabs;
    private float spawnRange = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefabs, GenerateSpawnPosition(), enemyPrefabs.transform.rotation);
    }

    // Update is called once per frame
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosZ);
        return randomPos;
    }
}
