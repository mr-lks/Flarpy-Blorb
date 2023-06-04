using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject Pipe; // Reference to the pipe prefab
    public BirdScript Bird; // Reference to the BirdScript component
    public float spawnRate = 2.0f; // Time interval between spawning pipes
    public float heightOffset = 1; // Offset for randomizing pipe height

    void Start()
    {
        StartCoroutine(SpawnObject()); // Start the coroutine to spawn pipes
    }

    public IEnumerator SpawnObject()
    {
        while (!Bird.isDead) // Loop until the bird is dead
        {
            float lowestPoint = transform.position.y - heightOffset; // Calculate the lowest y position for pipe spawn
            float highestPoint = transform.position.y + heightOffset; // Calculate the highest y position for pipe spawn

            // Instantiate a pipe at a random y position within the specified range
            Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
            
            yield return new WaitForSeconds(spawnRate); // Wait for the specified spawn rate before spawning the next pipe
        }
    }
}
