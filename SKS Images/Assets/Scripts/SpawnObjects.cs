using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public float xMinRange = -1.0f;
    public float xMaxRange = 2.0f;
    public float yMinRange = 8.0f;
    public float yMaxRange = 2.0f;
    public float zMinRange = 10.0f;
    public float zMaxRange = 12.0f;
    public float secondsBetweenSpawning = 0.1f;
    public GameObject spawnObjects;
    private float nextSpawnTime;

    // Use this for initialization
    void Start()
    {
        // determine when to spawn the next object
        nextSpawnTime = Time.time + secondsBetweenSpawning;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            // Spawn the game object through function below
            MakeThingToSpawn();

            // determine the next time to spawn the object
            nextSpawnTime = Time.time + secondsBetweenSpawning;
        }
        
    }
    void MakeThingToSpawn()
    {
        Vector3 spawnPosition;
        // get a random position between the specified ranges
        spawnPosition.x = Random.Range(xMinRange, xMaxRange);
        spawnPosition.y = Random.Range(yMinRange, yMaxRange);
        spawnPosition.z = Random.Range(zMinRange, zMaxRange);


        // actually spawn the game object
        GameObject spawnedObject = Instantiate(spawnObjects, spawnPosition, transform.rotation) as GameObject;

        // make the parent the spawner so hierarchy doesn't get super messy
        spawnedObject.transform.parent = gameObject.transform;
    }
}
