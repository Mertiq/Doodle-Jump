using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platform;

    public int numberOfPlatforms = 200;
    public float levelWidth = 1.2f;
    public float minY = .2f;
    public float maxY = 2.5f;

    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platform, spawnPosition, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
