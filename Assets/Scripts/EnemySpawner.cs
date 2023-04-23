using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy1PreFab;
    [SerializeField] private float enemySpawnInterval = 1f;

    
    void Start()
    {
        StartCoroutine(spawnEnemy(enemySpawnInterval,enemy1PreFab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy,new Vector2(Random.Range(-5.61f,5.64f),1.95f),Quaternion.identity);
        StartCoroutine(spawnEnemy(interval,enemy));
    }

}
