using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    public GameObject[] roadPrefabs;
    private float spawnPos = 0;
    private float roadLength = 53;

    private List<GameObject> activeRoad = new List<GameObject>();
    [SerializeField] private Transform car;
    private int startRoad = 6;


    void Start()
    {
        SpawnRoad(0);
        for(int i = 1; i< startRoad; i++)
        {
            SpawnRoad(Random.Range(0,roadPrefabs.Length));
        }
    }

    void Update()
    {
        if (car.position.x + 60 < (startRoad * roadLength) - spawnPos)
        {
            SpawnRoad(Random.Range(0, roadPrefabs.Length));
            DeleteRoad();
        }

    }
    public void SpawnRoad(int roadIndex)
    {
        GameObject nextRoad = Instantiate(roadPrefabs[roadIndex], -transform.right * spawnPos, transform.rotation);
        activeRoad.Add(nextRoad);
        spawnPos += roadLength;
    }

    private void DeleteRoad()
    {
        Destroy(activeRoad[0]);
        activeRoad.RemoveAt(0);
    }

}