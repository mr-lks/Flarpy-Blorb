using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDestroyerScript : MonoBehaviour
{

    //  public Collider2D Collision;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //  Debug.Log("Test");
    }



    void OnTriggerEnter2D(Collider2D col)
    {



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("collision name = " + collision.gameObject.name);
        Destroy(collision.gameObject);

    }
}
