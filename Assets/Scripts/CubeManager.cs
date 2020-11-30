using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class CubeManager : MonoBehaviour
{
    private float spawnRangeX = 10;
    private float spawnRangeMinZ = -15;
    private float spawnRangeMaxZ = -25;
    private float startTime = 1;
    private float repeatTime = .5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnCubes), startTime, repeatTime);
    }

 
    void SpawnCubes()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 2, Random.Range(spawnRangeMinZ, spawnRangeMaxZ));
        GameObject cube = ObjectPooler.SharedInstance.GetPooledObjects();
        if (cube != null)
        {
            cube.transform.position = spawnPos;
            cube.SetActive(true);
        }
        
        
    }
}
