using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpoint : MonoBehaviour
{
    [SerializeField] protected GameObject enemy1;
    [SerializeField] protected int numEnemy1;
    [SerializeField] protected GameObject enemy2;
    [SerializeField] protected int numEnemy2;
    public List<Transform> spawnPoints = new List<Transform>();
     void Start()
    {
        SpawnEnemies(enemy1, numEnemy1);
        SpawnEnemies(enemy2, numEnemy2);
    }
    protected void SpawnEnemies(GameObject enemyPrefab, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Count)];
            Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
