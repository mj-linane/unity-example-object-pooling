using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler SharedInstance;

    public List<GameObject> pooledObjects;

    public GameObject objectToPool;

    public int amountToPool;

    // Start is called before the first frame update
    private void Awake()
    {
        SharedInstance = this;
    }

    // Update is called once per frame

    private void Start()
    {
        pooledObjects = new List<GameObject>();
        for (var i = 0; i < amountToPool; i++)
        {
            var obj = Instantiate(objectToPool);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject GetPooledObjects()
    {
        for (var i = 0; i < pooledObjects.Count; i++)
            if (!pooledObjects[i].activeInHierarchy)
                return pooledObjects[i];
        return null;
    }
}