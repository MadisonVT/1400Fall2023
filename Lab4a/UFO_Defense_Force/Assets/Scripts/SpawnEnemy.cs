using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnEnemy : MonoBehaviour
{
    //Array that stores the UFOs.
    public GameObject[] ufoPrefabs;

    public int ufoIndex;

    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int ufoIndex = Random.Range(0, ufoPrefabs.Length);
        Instantiate(ufoPrefabs[ufoIndex],spawnPos, ufoPrefabs[ufoIndex].transform.rotation);
    }
}
