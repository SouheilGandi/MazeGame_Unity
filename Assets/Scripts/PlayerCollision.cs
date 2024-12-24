using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameOverUI gameOverUI; // Reference to the GameOver UI Manager

    void OnCollisionEnter(Collision collision) // For 3D Collision
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameOver(); // Call the Game Over function
        }
    }

    void OnTriggerEnter(Collider other) // If using Trigger instead of Collision
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            GameOver();
        }
    }

    void GameOver()
    {
        // Stop the game and show Game Over screen
        Time.timeScale = 0f;
        gameOverUI.ShowGameOverScreen();
    }
}
