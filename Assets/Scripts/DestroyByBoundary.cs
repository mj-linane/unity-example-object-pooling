using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
    private int zLimit = 15;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= zLimit)
        {
            gameObject.SetActive(false);
        }
    }
}
