using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 3f; // Speed of the obstacle's movement
    public float movementRange = 0.5f; // How far it moves left and right

    private Vector3 startPosition; // Initial position of the obstacle
    private bool movingRight = true; // Is the obstacle currently moving right?

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Move the obstacle left and right
        if (movingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            if (transform.position.x >= startPosition.x + movementRange)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            if (transform.position.x <= startPosition.x - movementRange)
            {
                movingRight = true;
            }
        }
    }
}
