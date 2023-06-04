using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{


    public float movementSpeed = 3;
    public float movementMultipler = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PipeMovement();
    }

    void PipeMovement(){

        float normalizedMovementSpeed =  movementSpeed*movementMultipler;

        
        transform.position = transform.position + (Vector3.left * normalizedMovementSpeed)*Time.deltaTime;
        

    }
}
