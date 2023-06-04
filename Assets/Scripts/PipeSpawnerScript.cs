using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{


    public GameObject Pipe;
    public BirdScript Bird;
    public float spawnRate = 2.0f;

    public float heightOffset = 1;

    // Start is called before the first frame update
    void Start()
    {

        // Initiate Spawn Enumerator
        StartCoroutine(SpawnObject());
    }



    // Spawn Object In Time Interval 
    public IEnumerator SpawnObject()
    {


        while (!Bird.isDead)
        {
            float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;


            //Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
            Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(-heightOffset, heightOffset), 0), transform.rotation);
            yield return new WaitForSeconds(spawnRate);
        }

    }

}
