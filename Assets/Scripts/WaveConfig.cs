using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave Config")]
public class WaveConfig : ScriptableObject
{
    [SerializeField] private int numberOfEnemies = 5;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float timeBetweenSpawns = 0.5f;
    [SerializeField] private float spawnRandomFactor = 0.3f;

    public GameObject GetEnemyPrefab()
    {
        return enemyPrefab;
    }

    public int GetNumberOfEnemies()
    {
        return numberOfEnemies;
    }

    public GameObject GetPathPrefab()
    {
        return pathPrefab;
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

    public float GetTimeBetweenSpawns()
    {
        return timeBetweenSpawns;
    }

    private float GetSpawnRandomFactor()
    {
        return spawnRandomFactor;
    }

    public List<Transform> GetWaypoints()
    {
        List<Transform> waveWaypoints = new List<Transform>();
        foreach (Transform child in pathPrefab.transform)
        {
            waveWaypoints.Add(child);
        }
        return waveWaypoints;
        // return pathPrefab.GetComponentInChildren<Transform>().ToList();
    }
}
