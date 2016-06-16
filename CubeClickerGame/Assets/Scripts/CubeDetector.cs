using UnityEngine;
using System.Collections;

public class CubeDetector : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
    }
}
