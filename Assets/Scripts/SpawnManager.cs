using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject dodgeBall;

    private float startTime = 3.0f;
    private float spawnInterval = 2.0f;

    private float spawnRangeX;
    private float spawnPosY = 1.0f;
    private float spawnPosZ = 20.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnDodgeBall", startTime, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnDodgeBall()
    {
        spawnRangeX = Random.Range(-9, 9);
        Vector3 spawnPosition = new Vector3(spawnRangeX, spawnPosY, spawnPosZ);
        Instantiate(dodgeBall, spawnPosition, dodgeBall.transform.rotation);
    }
}
