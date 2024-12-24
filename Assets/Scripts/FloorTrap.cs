using UnityEngine;

public class FloorTrap : MonoBehaviour
{
    // Method called when something enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered is the player
        if (other.CompareTag("Player"))
        {
            // Call a method to handle the player's death
            KillPlayer(other.gameObject);
        }
    }

    // Method to handle the player's death
    private void KillPlayer(GameObject player)
    {
        Debug.Log("Player stepped on a trap!");
        // Optionally disable the player or stop movement
       //player.GetComponent<PlayerMovement>().enabled = false;

        // Show the game over screen (optional)
        FindObjectOfType<GameOverUI>().ShowGameOverScreen();
    }
}
