using UnityEngine;

public class MeteorSpawner_Home : MonoBehaviour
{

    public Transform[] spawnPoints;

    public GameObject meteor_6Prefab;

    public float timeBetweenWaves = 2f;

    private float timeToSpawn = 3f;

    void Update()
    {

        if (Time.time >= timeToSpawn)
        {
                SpawnBlocks();
                timeToSpawn = Time.time + timeBetweenWaves;
        }

    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(meteor_6Prefab, spawnPoints[randomIndex].position, Quaternion.identity);
    }
}
