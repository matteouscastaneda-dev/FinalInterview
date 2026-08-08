using UnityEngine;
using System.Collections.Generic;
using System;

public class Turret : MonoBehaviour
{
    [SerializeField] private EnemySpawner enemySpawner;

    private GameObject GetclosestEnemy(List<GameObject> enemies)
    {
        float bestDistance = Mathf.Infinity;
        GameObject bestEnemy = null;

        for (int i = 0; i < enemies.Count - 1; i++)
        {
            float distance = Vector3.Distance(transform.position, enemies[i].transform.position);

            GameObject enemy = enemies[i];

            if (distance < bestDistance)
            {
                bestDistance = distance;
                bestEnemy = enemies[i];
            }
        }
        return bestEnemy;
    }
}
