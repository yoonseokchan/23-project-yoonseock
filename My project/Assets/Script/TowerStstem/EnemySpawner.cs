using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyController[] enemiesTospawn;

    public Transform spawnPoint;

    public float timeBetweenSpawns = 0.5f;
    private float spawnCounter;

    public int amountTospawn = 15;

    // Start is called before the first frame update
    void Start()
    {
        spawnCounter = timeBetweenSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        if(amountTospawn >0)
        {
            spawnCounter -=Time.deltaTime;
            if(spawnCounter <= 0 )
            {
                spawnCounter = tmeBetweenSpawns;
                Instantiate(enemiesTospawn[Random.Range(0, enemiesTospawn.Length)], spawnPoint.position, spawnPoint.rotation);
            }
        }
    }
}
