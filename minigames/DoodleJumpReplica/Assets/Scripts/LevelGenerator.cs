using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    private Vector3 spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        
        for(int i = 0; i < 200; i++)
        {
            spawnPosition.x = Random.Range(-3f, 3f);
            spawnPosition.y += Random.Range(0.2f, 1.5f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
           
    }
}
