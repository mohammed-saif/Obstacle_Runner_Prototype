using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playercontrollerScript;

    // Start is called before the first frame update
    void Start()
    {
        playercontrollerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        int spawnIndex = Random.Range(0, obstaclePrefab.Length);

        if(playercontrollerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab[spawnIndex], spawnPos, obstaclePrefab[spawnIndex].transform.rotation);
        }
        
    }
}
