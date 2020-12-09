using UnityEngine;

public class CubeManager : MonoBehaviour
{
    private readonly float repeatTime = .5f;
    private readonly float spawnRangeMaxZ = -25;
    private readonly float spawnRangeMinZ = -15;
    private readonly float spawnRangeX = 10;
    private readonly float startTime = 1;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnCubes), startTime, repeatTime);
    }


    private void SpawnCubes()
    {
        var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 2,
            Random.Range(spawnRangeMinZ, spawnRangeMaxZ));
        var cube = ObjectPooler.SharedInstance.GetPooledObjects();
        if (cube != null)
        {
            cube.transform.position = spawnPos;
            cube.SetActive(true);
        }
    }
}