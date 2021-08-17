using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] humanPrefabs;
    private float spawnRangeX = 30;
    private float spawnPosZ = 30;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomHuman", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
            //     // Random generate animal index and spawn position
    }

    void SpawnRandomHuman(){
        int humanIndex = Random.Range(0, humanPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0 , spawnPosZ);
        Instantiate(humanPrefabs[humanIndex], new Vector3(0,0,60), 
        humanPrefabs[humanIndex].transform.rotation);
    }
}
