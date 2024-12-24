using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinGame : MonoBehaviour
{
    public GameObject winPanel;   // Reference to the Win Panel

    private void Start()
    {
        winPanel.SetActive(false); // Ensure the win panel is hidden at start
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Check if the player reaches the exit
        {
            Win();
        }
    }

    void Win()
    {
        Time.timeScale = 0f;  // Stop the game
        winPanel.SetActive(true);  // Show the win panel
    }

    public void ReplayGame()
    {
        Time.timeScale = 1f;  // Resume the game
        // Load the first scene (assumed to be at index 0)
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit(); // Quit the game (only works in a built game, not in the editor)
    }
}
