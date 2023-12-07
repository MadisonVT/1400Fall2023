using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;

    public float lowerBounds = -10.0f;

    public GameManager gameManager;
    
    //public GameManager gameManager;
    

    // Update is called once per frame
    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
            if (gameObject.CompareTag("Item"))
                Destroy(gameObject);
            else
            {
                Destroy(gameObject);
                gameManager.isGameOver = true;
            }

        }
    }
}
