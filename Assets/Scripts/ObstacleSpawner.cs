using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {
    public float spawnRate;
    public float laneSize = 4;
    public GameObject background, minePrefab, player;
    int spawnCount = 0, obstacleCombo;
    float backgroundSizeY, spawnTimer;

	void Start () {
        backgroundSizeY = background.transform.localScale.y;
        resetTimer();
    }
	
	void Update () {
        spawnTimer -= Time.deltaTime;
		if(spawnTimer <= 0)
        {
            Instantiate(background, new Vector3(0, backgroundSizeY * spawnCount, 5),Quaternion.identity);
            obstacleCombo = Random.Range(0, 12);
            spawnObstacles(obstacleCombo);
            spawnCount++;
            resetTimer();
        }
	}

    void spawnObstacles(int obstacleCombo)
    {
        if (obstacleCombo < 3)
        {
            Instantiate(minePrefab, new Vector3(-laneSize, backgroundSizeY * spawnCount, 3), Quaternion.identity);
        }
        else if (obstacleCombo < 6)
        {
            Instantiate(minePrefab, new Vector3(0, backgroundSizeY * spawnCount, 3), Quaternion.identity);
        }
        else if (obstacleCombo < 9)
        {
            Instantiate(minePrefab, new Vector3(laneSize, backgroundSizeY * spawnCount, 3), Quaternion.identity);
        }
        else if (obstacleCombo == 9)
        {
            Instantiate(minePrefab, new Vector3(-laneSize, backgroundSizeY * spawnCount, 3), Quaternion.identity);
            Instantiate(minePrefab, new Vector3(0, backgroundSizeY * spawnCount, 3), Quaternion.identity);
        }
        else if (obstacleCombo == 10)
        {
            Instantiate(minePrefab, new Vector3(-laneSize, backgroundSizeY * spawnCount, 3), Quaternion.identity);
            Instantiate(minePrefab, new Vector3(laneSize, backgroundSizeY * spawnCount, 3), Quaternion.identity);
        }
        else
        {
            Instantiate(minePrefab, new Vector3(0, backgroundSizeY * spawnCount, 3), Quaternion.identity);
            Instantiate(minePrefab, new Vector3(laneSize, backgroundSizeY * spawnCount, 3), Quaternion.identity);
        }
    }

    void resetTimer()
    {
        spawnTimer = backgroundSizeY / player.GetComponent<PlayerCtrl>().runSpeed - 0.07f;
    }
}
