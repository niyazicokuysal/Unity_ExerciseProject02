using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1f;

    public GameObject hexagonObj;
    public GameObject squareObj;


    private float nextTo = 0f;

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextTo)
        {
            if(Player.point > 7)
            {
                Instantiate(hexagonObj, Vector3.zero, Quaternion.identity);
                nextTo = Time.time + 1f / spawnRate;
            }
            else
            {
                Instantiate(squareObj, Vector3.zero, Quaternion.identity);
                nextTo = Time.time + 1f / spawnRate;
            }
            
        }
    }
}
