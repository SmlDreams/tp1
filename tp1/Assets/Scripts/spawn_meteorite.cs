using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteorite : MonoBehaviour
{
    public GameObject meteoritePrefab;
    public float spawnTime = 0.5f;
    public float meteoriteSpeed = 4.5f;
    public float minMeteoriteSize = 0.3f;
    public float maxMeteoriteSize = 1.0f;
    public float minMeteoriteSpeed = 2.0f;
    public float maxMeteoriteSpeed = 5.0f;


    void Start()
    {
        InvokeRepeating("SpawnMeteoriteAtRandomPosition", 0f, spawnTime);
    }

    void SpawnMeteoriteAtRandomPosition()
    {
        float cameraSize = Camera.main.orthographicSize;
        float randomX = Random.Range(-Camera.main.aspect * cameraSize, Camera.main.aspect * cameraSize);
        float fixedY = cameraSize;
        Vector3 spawnPosition = new Vector3(randomX, fixedY, 0f);

        float randomSize = Random.Range(minMeteoriteSize, maxMeteoriteSize);
        float randomSpeed = Random.Range(minMeteoriteSpeed, maxMeteoriteSpeed);
    
        // Set the direction to be downward with a random horizontal component
        Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), -1f).normalized;

        GameObject meteorite = Instantiate(meteoritePrefab, spawnPosition, Quaternion.identity);
        Meteorite meteoriteScript = meteorite.AddComponent<Meteorite>();

        meteorite.transform.localScale = new Vector3(randomSize, randomSize, 1f);
        meteoriteScript.meteoriteSpeed = randomSpeed;
        meteoriteScript.meteoriteDirection = randomDirection;
    }


}