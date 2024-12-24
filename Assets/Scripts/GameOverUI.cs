using UnityEngine;
using TMPro; // For TextMeshPro
using UnityEngine.SceneManagement;// For scene management
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverPanel; // Panel with the Time's Up and You Lost texts
    public TextMeshProUGUI timeUpText; // Time's Up text
    public TextMeshProUGUI youLostText; // You Lost text
    public Button replayButton; // Replay button
    public Button exitButton; // Exit button

    void Start()
    {
        // Initially hide the game over screen
        gameOverPanel.SetActive(false);

        // Add listeners to the buttons
        replayButton.onClick.AddListener(OnReplay);
        exitButton.onClick.AddListener(OnExit);
    }

    // This function is called when the timer runs out
    public void ShowGameOverScreen()
    {
        // Stop the game
        Time.timeScale = 0f;
        // Show the game over screen
        gameOverPanel.SetActive(true);
        timeUpText.text = "GAME OVER";
        youLostText.text = "YOU LOST!";
    }

    // Replay the game (reset the scene)
    private void OnReplay()
    {
        // Reset the time scale in case it was stopped
        Time.timeScale = 1f;

        // Load the first scene (assumed to be at index 0)
        SceneManager.LoadScene(0);
    }

    // Exit the game
    private void OnExit()
    {
        // Reset the time scale before exiting
        Time.timeScale = 1f;
        // Exit the game
        Application.Quit();

        // If you're in the Unity editor, use this to stop the game instead
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
