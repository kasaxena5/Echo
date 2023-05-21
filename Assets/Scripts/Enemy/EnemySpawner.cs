using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Spawner Transforms")]
    [SerializeField] Transform rockSpawner;
    [SerializeField] RockEnemy rockPrefab;
    [SerializeField] Transform batSpawner;
    [SerializeField] BatEnemy batPrefab;

    [Header("Rock Configs")]
    [SerializeField] float maxRockSize;
    [SerializeField] float minRockSize;
    [SerializeField] float maxRockInitialSpeed;
    [SerializeField] float minRockInitialSpeed;
    [SerializeField] float minRockSpawnWaitTime;
    [SerializeField] float maxRockSpawnWaitTime;

    [Header("Bat Configs")]
    [SerializeField] float maxBatInitialSpeed;
    [SerializeField] float minBatInitialSpeed;
    [SerializeField] float minBatSpawnWaitTime;
    [SerializeField] float maxBatSpawnWaitTime;
    [SerializeField] Transform batTarget;


    void Start()
    {
        StartCoroutine(BatSpawner());
        StartCoroutine(RockSpawner());
    }

    IEnumerator RockSpawner()
    {
        while (GameManager.Instance.GamePlaying)
        {
            float spawnWaitTime = Random.Range(minRockSpawnWaitTime, maxRockSpawnWaitTime);
            
            RockEnemy rock = Instantiate(rockPrefab, rockSpawner.position + new Vector3(Random.Range(-5, 5), 0, 0), Quaternion.identity);
            rock.Initialize(Random.Range(minRockInitialSpeed, maxRockInitialSpeed), Random.Range(minRockSize, maxRockSize));

            yield return new WaitForSeconds(spawnWaitTime);
        }
    }

    IEnumerator BatSpawner()
    {
        while (GameManager.Instance.GamePlaying)
        {
            float spawnWaitTime = Random.Range(minBatSpawnWaitTime, maxBatSpawnWaitTime);

            BatEnemy bat = Instantiate(batPrefab, batSpawner.position + new Vector3(Random.Range(-5, 5), 0, 0), Quaternion.identity);

            float speed = Random.Range(minBatInitialSpeed, maxBatInitialSpeed);
            Vector2 direction = Random.insideUnitCircle;
            bat.Initialize(direction, speed, batTarget);

            yield return new WaitForSeconds(spawnWaitTime);
        }
    }
}
