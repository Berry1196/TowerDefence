using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WaveSpawner : MonoBehaviour
{
    public int remainingEnemies;
    public Wave[] waves;
    public Transform spawnPoint;

    public float timeBetweenSpawns = 5f;
    private float countdown = 2f;
    private int currentWave = 0;
    private Player player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        remainingEnemies = 0;
    }

    void Update()
    {
        if (remainingEnemies > 0)
        {
            return;
        }
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenSpawns;
        }
        countdown -= Time.deltaTime;

    }

    IEnumerator SpawnWave()
    {
        Wave wave = waves[currentWave];
        Player.waveNumber++;
        Debug.Log("Wave: " + Player.waveNumber);
        for (int i = 0; i < wave.count; i++)
        {
            SpawnEnemy(wave.enemies[i].gameObject);
            yield return new WaitForSeconds(1f / wave.rate);
        }
        currentWave++;

    }
    void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        remainingEnemies++;
    }
}


