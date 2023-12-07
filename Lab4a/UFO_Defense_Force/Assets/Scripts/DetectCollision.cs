using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager; //stores reference to ScoreManager
    public int scoreToGive;

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); 
        //Finds the ScoreManager Game Object and references it's ScoreManager script component
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Item"))
        {
            Destroy(gameObject); //Destroy this game object. 
            scoreManager.IncreaseScore(scoreToGive); 
        }
        else
        {
            Destroy(gameObject); //Destroy this game object.
            Destroy(other.gameObject); //Destroy the other object it hits.
            scoreManager.IncreaseScore(scoreToGive); 
        }
    }
}
