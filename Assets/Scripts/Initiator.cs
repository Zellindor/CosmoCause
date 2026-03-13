using UnityEngine;

public class Initiator : MonoBehaviour
{
    public GameObject asteroidPrefab;

    float spawnInterval = 2f;
    float timeSinceLastSpawn = 0f;
    float minInterval = 0.4f;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnAsteroid();
            timeSinceLastSpawn = 0f;
            spawnInterval = Mathf.Max(minInterval, spawnInterval - 0.05f);
        }
    }

    void SpawnAsteroid()
    {
        if (asteroidPrefab != null)
        {
            Instantiate(asteroidPrefab, Vector3.zero, Quaternion.identity);
        }
    }
}