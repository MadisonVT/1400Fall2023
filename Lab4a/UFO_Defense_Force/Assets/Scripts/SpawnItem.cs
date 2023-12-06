using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    
    public GameObject[] itemPrefabs;

    public int itemIndex;

    private float itemSpawnRangeX = 20f;
    private float itemSpawnPosZ = 20f;
    private float itemStartDelay = 2.0f;
    private float itemSpawnInterval = 4.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomItem", itemStartDelay, itemSpawnInterval);
    }

    void SpawnRandomItem()
    {
        Vector3 itemSpawnPos = new Vector3(Random.Range(-itemSpawnRangeX, itemSpawnRangeX), 0, itemSpawnPosZ);
        int ufoIndex = Random.Range(0, itemPrefabs.Length);
        Instantiate(itemPrefabs[itemIndex],itemSpawnPos, itemPrefabs[itemIndex].transform.rotation);
    }
}