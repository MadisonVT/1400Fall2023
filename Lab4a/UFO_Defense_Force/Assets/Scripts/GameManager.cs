using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Namespace for Text Mesh Pro.

using Object = System.Object;


public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;
    
    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    public void Update()
    {
        if (isGameOver)
        {
            Debug.Log("Calling End Game");
            EndGame(); //Calls the EndGame method to end the game.
        }
        else
        {
            gameOverText.gameObject.SetActive(false); //Hide UI "Game Over" text.
        }
    }

    public void EndGame()
    {
        Debug.Log("Game is Over");
        gameOverText.gameObject.SetActive(true); //Displays "Game Over" UI text.
        Time.timeScale = 0; //Freezes time.
    }
}
