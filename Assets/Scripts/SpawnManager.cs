using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //conjunto de los game obj
    public GameObject[] animalPrefabs;

   private int animalIndex;

    public float spawnRangeX = 14f;
    public float spawnPosZ = 25f;

    private float startDelay = 1.5f;
    public float spawnInterval = 2f;



   
    private void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Debug.Log(animalPrefabs);
        Instantiate(animalPrefabs[animalIndex], RandomSpawnPos(), animalPrefabs[animalIndex].transform.rotation);
    }

    private Vector3 RandomSpawnPos()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        return new Vector3(randomX, 0, spawnPosZ);
    }

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay,
         spawnInterval);
    }

}
