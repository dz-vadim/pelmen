using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject boxPrefab;
    [Space(10)]
    [SerializeField] private float spawnTime;
    void Start()
    {
        StartCoroutine("Spawn");
    }
    IEnumerator Spawn()
    {
        int randomPosiiton = Random.Range(0, spawnPoints.Length);
        Instantiate(boxPrefab, spawnPoints[randomPosiiton].position, Quaternion.identity);
        yield return new WaitForSeconds(spawnTime);
        StartCoroutine("Spawn");
    }
}
