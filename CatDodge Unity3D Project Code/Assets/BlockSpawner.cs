using UnityEngine;

public class BlockSpawner : MonoBehaviour {

	public Transform[] spawnPoints;

	public GameObject meteor_6Prefab;

    public GameObject Shield_bonus;

    public GameObject Coin;

    public float timeBetweenWaves = 0.8f;

	private float timeToSpawn = 3f;
    private float timeToBonus = 5f;
    private float timeToCoins = 8f;

    void Update () {
        
        if (Time.time >= timeToSpawn)
		{
            if (Time.time >= timeToBonus)
            {
                SpawnBonus();
                timeToBonus = Time.time + timeToBonus;
            }
            if (Time.time >= timeToCoins)
            {
                SpawnCoins();
            }
            if (timeBetweenWaves < 0.3f)
            {
                SpawnBlocks();
                timeToSpawn = Time.time + timeBetweenWaves;
                timeBetweenWaves = timeBetweenWaves - 0.005f;
            }
            else
            {
                SpawnBlocks();
                timeToSpawn = Time.time + timeBetweenWaves;
            }
        }

	}

	void SpawnBlocks ()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);

				Instantiate(meteor_6Prefab, spawnPoints[randomIndex].position, Quaternion.identity);
	}
    void SpawnBonus()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(Shield_bonus, spawnPoints[randomIndex].position, Quaternion.identity);
    }
    void SpawnCoins()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(Coin, spawnPoints[randomIndex].position, Quaternion.identity);
    }
}
