using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;
    
    // Begins game (loads scene) when called
    public void StartGame()
    {
        //Loads the scene within the "sceneToLoad" variable.
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("New Scene Loaded Successfully");
    }
    //Method quits the game when called
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit Successfully");
    }
}
