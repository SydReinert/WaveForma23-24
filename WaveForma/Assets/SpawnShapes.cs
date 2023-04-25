using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShapes : MonoBehaviour
{
    public GameObject[] shapePrefab;
    public float spawnDelay;

    private Vector3 pos;
    private Quaternion rot;

    public float rotationX;
    public float rotationY;

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
        rot = new Quaternion(rotationX, Random.Range(0, 365), Random.Range(0, 365), 0);
        pos = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), zSpawn);
        Instantiate(shapePrefab[Random.Range(0, shapePrefab.Length)], pos, rot);
    }
}
