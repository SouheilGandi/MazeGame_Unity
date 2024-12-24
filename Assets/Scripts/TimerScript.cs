using UnityEngine;
using UnityEngine.UI; // For using UI elements
using TMPro;

public class TimerScript : MonoBehaviour
{
    public float timeLeft = 120f;  // 2 minutes in seconds (120 seconds)
    public TextMeshProUGUI timerText;         // Reference to the Text component to display the time
    public GameOverUI gameOverUI;

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;  // Decrease time left
            UpdateTimerText();           // Update timer text
        }
        else
        {
            // Ensure timer does not go below 0
            timeLeft = 0;

            // Trigger Game Over only once
            if (!gameOverUI.gameOverPanel.activeSelf)
            {
                gameOverUI.ShowGameOverScreen();
            }
        }
    }

    // Method to update the timer UI text
    void UpdateTimerText()
    {
        // Convert the time left (in seconds) into minutes and seconds
        int minutes = Mathf.FloorToInt(timeLeft / 60);
        int seconds = Mathf.FloorToInt(timeLeft % 60);

        // Format the time as "MM:SS"
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
