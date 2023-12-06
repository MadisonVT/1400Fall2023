using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //Destroy this game object.
        Destroy(other.gameObject); //Destroy the other object it hits.
    }
}
