using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Item"))
        {
            Destroy(gameObject); //Destroy this game object. 
        }
        else
        {
            Destroy(gameObject); //Destroy this game object.
            Destroy(other.gameObject); //Destroy the other object it hits.
        }
    }
}
