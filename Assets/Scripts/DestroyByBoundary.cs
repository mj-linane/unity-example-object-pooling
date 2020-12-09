using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
    private readonly int zLimit = 15;

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.z >= zLimit) gameObject.SetActive(false);
    }
}