using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float movementSpeed = 3; // Speed at which the pipe moves
    public float movementMultipler = 0.001f; // Multiplier for adjusting the movement speed

    void Update()
    {
        PipeMovement(); // Call the PipeMovement method to move the pipe
    }

    void PipeMovement()
    {
        float normalizedMovementSpeed = movementSpeed * movementMultipler; // Calculate the normalized movement speed

        transform.position = transform.position + (Vector3.left * normalizedMovementSpeed) * Time.deltaTime;
        // Update the position of the pipe by moving it to the left based on the movement speed and deltaTime
    }
}
