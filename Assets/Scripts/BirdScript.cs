using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRig; // Reference to the 2D Rigidbody component of the bird

    public bool isDead; // Boolean variable to check if the bird is dead

    public float gravityScale = 1f; // Bird's gravity scale
    public float verticalVelocity = 5f; // Bird's vertical movement scale

    public GameManager GM; // Reference to the GameManager script

    void Start()
    {
        setGravityScale(); // Update the gravity scale on start
    }

    void Update()
    {
        moveBird(); // Update the bird's vertical movement on each frame
    }

    void moveBird()
    {
        // Update the bird's vertical velocity on input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            birdRig.velocity = Vector2.up * verticalVelocity;
        }
    }

    void setGravityScale()
    {
        birdRig.gravityScale = gravityScale; // Set the bird's gravity scale
    }

    void setLocalPosition()
    {
        transform.position = transform.localPosition; // Set the bird's local position to its transform position
    }

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.name == "ScoreArea")
        {
            GM.UpdateScore(); // Call the UpdateScore method in the GameManager when the bird collides with the score area
        }
    }

    private void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.tag == "DeathArea")
        {
            isDead = true; // Set the bird as dead
            Time.timeScale = 0; // Freeze the game
            GM.ShowDeathScreen(); // Call the ShowDeathScreen method in the GameManager to display the death screen
        }
    }
}
