using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShapes : MonoBehaviour
{
    public GameObject[] shapePrefab;
    public float spawnDelay;

    private Vector3 pos;
    private Quaternion rot;

    public bool randomRotation;

    public float rotationX;
    public float rotationY;

    public bool randomPosition;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    
    public float zSpawn;

    void Awake() {
        InvokeRepeating("Make", 0f, spawnDelay);
    }

    // Called repeatedly to make prefabs
    void Make()
    {
        if (randomPosition) {
            pos = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), zSpawn);
        } else {
            pos = new Vector3(minX, minY, zSpawn);
        }
        if (randomRotation) {
            rot = new Quaternion(Random.Range(0, 365), Random.Range(0, 365), Random.Range(0, 365), 0);
        } else {
            rot = new Quaternion(rotationX, rotationY, 0, 0);
        }
        
        Instantiate(shapePrefab[Random.Range(0, shapePrefab.Length)], pos, rot);
    }
}
