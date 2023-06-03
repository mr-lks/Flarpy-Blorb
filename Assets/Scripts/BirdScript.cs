using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    // 2D RigidBody Component Reference
    public Rigidbody2D birdRig;

    // Birds's Gravity Scale 
    public float gravityScale = 1;

    // Bird's Vertical Movement Scale 
    public float upperMovement = 5;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Bird Character";


        // Update Gravity Scale on BeginPlay 
        setGravityScale();


    }

    // Update is called once per frame
    void Update()
    {

        // Update Bird Vertical Movement on Each Draw Call { Tick }

        moveBird();

    }

    void moveBird()
    {


        // Update the Bird Vertical Velocity by Input Key Down

        if (Input.GetKeyDown(KeyCode.W))
        {
            birdRig.velocity = Vector2.up * upperMovement;
        }


    }

    void setGravityScale()
    {

        // Set Bird's Gravity Scale
        birdRig.gravityScale = gravityScale;

    }

    void setLocalPosition()
    {

        // Set the bird's transform to the bird's transform
        transform.position = transform.localPosition;
    }
}
