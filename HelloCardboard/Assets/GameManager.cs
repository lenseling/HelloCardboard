using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshPro scoreText;
    public TextMeshPro gameText;
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score + "/4";
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score + "/4";
        if (score >= 4)
        {
            gameText.text = "You win!";
        }

    }
}
