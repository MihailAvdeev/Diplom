using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    float RandX;
    Vector2 whereToSpawn;
    private float spawnRate = 2f;
    float nextSpawn = 0.0f;
    void Start()
    {
        
    }

    void Update()
    {
        if(Time.time > RandX)
        {
            nextSpawn = Time.time + spawnRate;
            RandX = Random.Range(-9.14f, 10.09f);
            whereToSpawn = new Vector2(RandX, transform.position.y);
            Instantiate(obj, whereToSpawn, Quaternion.identity);
        }
    }
}
