using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1f;

    public GameObject hexagonObj;

    private float nextTo = 0f;

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextTo)
        {
            Instantiate(hexagonObj, Vector3.zero, Quaternion.identity);
            nextTo = Time.time + 1f / spawnRate;
        }
    }
}
