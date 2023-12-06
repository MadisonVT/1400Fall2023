using System.Collections;
using System.Collections.Generic;
using TMPro; //Namespace for Text Mesh Pro.
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score; //Contains score value.

    public TextMeshProUGUI scoreText; //Visual text element to be modified.
    
    // Increases score by a set amount in the score variable.
    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    // Decreases score by a set amount in the score variable
    public void DecreaseScore(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }
    // Updates the text shown to the player.
    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
