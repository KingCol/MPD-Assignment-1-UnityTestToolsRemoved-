using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private GameObject cubeSpawner;

    void Start()
    {
        StartCoroutine(cubeSpawnerInterval());
    }

    private IEnumerator cubeSpawnerInterval()
    {
        Instantiate(cubePrefab, new Vector3(Random.Range(cubeSpawner.transform.position.x - 4, cubeSpawner.transform.position.x + 4), 
                                            cubeSpawner.transform.position.y, 
                                            Random.Range(cubeSpawner.transform.position.z - 4, cubeSpawner.transform.position.z + 4)), 
                                            Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(0.25f, 1.0f));
        StartCoroutine(cubeSpawnerInterval());
    }
}
