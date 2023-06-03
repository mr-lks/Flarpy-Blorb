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
        destroyPipeOnOverLap();
    }
    
    void destroyPipeOnOverLap()
    {

        Collider2D coll = GetComponent<Collider2D>();

        ContactFilter2D filter = new ContactFilter2D().NoFilter();
        List<Collider2D> results = new List<Collider2D>();
        Console.Write(results);

       // Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Console.WriteLine("Test");

    }
}
