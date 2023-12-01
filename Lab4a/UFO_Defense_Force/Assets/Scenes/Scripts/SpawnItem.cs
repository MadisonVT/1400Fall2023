using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject pickUp;

    public Transform itemSpawn;

    // Start is called before the first frame update
    void Start()
    {
        //Creates a lazerBeam at the blaster position while maintaining it's rotation.
        Instantiate(pickUp, itemSpawn.transform.position, pickUp.transform.rotation);
    }
}