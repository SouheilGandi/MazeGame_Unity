using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton to access GameManager globally
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        // If no instance of GameManager exists, set this as the instance
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // Keeps the GameManager between scenes
        }
        else
        {
            Destroy(gameObject); // If an instance already exists, destroy this one
        }
    }


}
