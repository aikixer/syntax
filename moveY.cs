using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Get the Animator component attached to the player GameObject
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Get the vertical input (typically from the W/S keys or up/down arrow keys)
        float moveYValue = Input.GetAxis("Vertical");

        // Validate moveYValue to ensure it is not NaN
        if (float.IsNaN(moveYValue))
        {
            Debug.LogError("moveYValue is NaN! Check your calculations or input.");
            moveYValue = 0f; // Set to a default value to avoid issues
        }

        // Set the move y parameter in the Animator
        animator.SetFloat("move y", moveYValue);

        // Optional: Debug log to see the value in the Console
        Debug.Log("moveYValue: " + moveYValue);
    }
}