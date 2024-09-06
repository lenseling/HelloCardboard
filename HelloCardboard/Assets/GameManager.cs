using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshPro scoreText;
    public TextMeshPro gameText;
    public GameTimer gameTimer;
    private bool gameEnded = false;
    public float timeRemaining = 30f; // 30 seconds


    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score + "/4";
    }

    void Update()
    {
        if (!gameEnded)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime; // Countdown by time
                gameTimer.DisplayTime(timeRemaining);
            }
            else
            {
                EndGame(); // Time's up!
            }
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score + "/4";
        if (score >= 4)
        {
            gameEnded = true;
            EndGame();
        }

    }

    // End the game when time runs out
    void EndGame()
    {
        gameEnded = true;
        
        Debug.Log("Time's up!");
        if (score >= 4)
        {
            gameText.text = "You win!";
        }
        else
        {
            Time.timeScale = 0;
            gameText.text = "Out of time...";

        }
        
    }
}
