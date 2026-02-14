using UnityEngine;

public class LandingPlatformRandomTransform : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(Random.Range(-100f, 100f), 0, Random.Range(-100f, 100f));
    }
}