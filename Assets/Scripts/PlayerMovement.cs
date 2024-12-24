using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 100f;//movement speed
    private float rotationSpeed = 180f; // Speed for turning left/right
    private Rigidbody rb;        // Reference to the Rigidbody component
    private Animator animator;   // Reference to the Animator component

    void Start()
    {
        rb = GetComponent<Rigidbody>();      // Get the Rigidbody component
        animator = GetComponent<Animator>(); // Get the Animator component
    }

  


    void FixedUpdate()
    {
        // Get movement input from phone accelerometer
        float moveX = Input.acceleration.x; // Left/Right tilt of the phone
        float moveY = Input.acceleration.y; // Forward/Backward tilt of the phone

        // ** Forward Movement (Only Forward) **
        if (moveY<0.1f) // Prevent moving backward
        {
            Vector3 forwardMovement = transform.forward * -moveY * speed;
             rb.velocity = new Vector3(forwardMovement.x, rb.velocity.y, forwardMovement.z);

        }
        else if(moveY> -0.1f)
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0); // Stop forward movement
        }
        Debug.Log("Velocity: " + rb.velocity);

        //Rotate character left/right base on phone tilt 
        float turn = moveX * rotationSpeed * Time.fixedDeltaTime;
        transform.Rotate(0, turn, 0);

        // Control animations based on movement magnitude
        if (Mathf.Abs(moveY) > 0.1f || Mathf.Abs(moveX) > 0.1f)
        {
            animator.SetFloat("Speed", rb.velocity.magnitude); // Switch to Run
        }
        else
        {
            animator.SetFloat("Speed", 0f); // Switch to Idle
        }



    }
}
