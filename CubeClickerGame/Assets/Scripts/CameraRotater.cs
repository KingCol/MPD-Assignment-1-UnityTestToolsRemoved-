using UnityEngine;
using System.Collections;

public class CameraRotater : MonoBehaviour
{
    [SerializeField] private Transform cubeSpawner;

    void Update()
    {
        transform.RotateAround(cubeSpawner.position, transform.up, 100.0f * Time.deltaTime);
    }
}
