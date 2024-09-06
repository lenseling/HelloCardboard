using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameTimer : MonoBehaviour
{
    public TextMeshPro timerText; 

    void Update()
    {
        
    }

    // Display the time in minutes and seconds
    public void DisplayTime(float timeToDisplay)
    {
        timeToDisplay = Mathf.Clamp(timeToDisplay, 0, Mathf.Infinity); 

        int seconds = Mathf.FloorToInt(timeToDisplay); 

        if (timerText != null)
        {
            timerText.text = seconds.ToString(); 
        }
    }

    
}
