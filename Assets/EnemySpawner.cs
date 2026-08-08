using UnityEngine;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    //I forgot the question specifics :O

    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject turret;

    public List<GameObject> activeEnemies = new List<GameObject>();

    private float spawnDistance = 15f;

    private void SpawnEnemy(Vector3 position)
    {
        Instantiate(prefab, position, transform.rotation);
    }

    private void getSpawnPosition()
    {

    }
}
