using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDestroyerScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Collision)
    {
        Debug.Log(Collision.gameObject.name); // Print the name of the collided game object for debugging purposes
        
        if (Collision.gameObject.name == "Pipe(Clone)")
        {
            Destroy(Collision.gameObject); // Destroy the collided pipe game object
        }
    }
}
