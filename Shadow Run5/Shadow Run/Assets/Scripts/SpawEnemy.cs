using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawEnemy : MonoBehaviour
{
    [SerializeField] private GameObject EnemyPrefab;
    [SerializeField] private Transform[] EnemyPosition;


    void Start()
    {
        StartCoroutine(GenerateEnemy());
    }

    IEnumerator GenerateEnemy()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.2f);

            GameObject  newEnemyPrefab =  Instantiate(EnemyPrefab, EnemyPosition[Random.Range(0, 3)].position, Quaternion.identity);
            Destroy(newEnemyPrefab, 7); 
        }
    }
}
