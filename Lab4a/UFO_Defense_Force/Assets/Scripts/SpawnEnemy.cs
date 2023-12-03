using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    //Array that stores the UFOs.
    public GameObject[] ufoPrefabs;

    public int ufoIndex;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
            Instantiate(ufoPrefabs[ufoIndex], new Vector3(0,0,15), ufoPrefabs[ufoIndex].transform.rotation);
    }
}
