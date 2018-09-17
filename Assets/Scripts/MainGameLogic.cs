using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameLogic : MonoBehaviour {
    float timer, mineSpeed;
    public float maxMineSpeed = 17.0f , mineDensity = 0.75f, gameSpeed = 0.8f;
    public Transform leftLaneSpawner, midLaneSpawner, rightLaneSpawner;
    public GameObject minePrefab;
	// Use this for initialization
	void Start () {
        ResetTimer();
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            int spawnCombo = Random.Range(0, 12);
            spawnObstacles(spawnCombo);
            ResetTimer();
        }
		
	}

    void ResetTimer()
    {
        //timer = 2.0f; //TODO add logarithmic difficulty
        timer = 100 / (Time.timeSinceLevelLoad + 50.0f);
        mineSpeed = (-timer + maxMineSpeed / 2) / 0.4f;
        timer /= gameSpeed * mineDensity;
        mineSpeed *= gameSpeed;
        Debug.Log(timer);
    }

    void spawnObstacles(int spawnCombo)
    {
        switch(spawnCombo)
        {
            case 0:
            case 1:
            case 2://spawn left
                Instantiate(minePrefab, leftLaneSpawner).GetComponent<MineController>().speed = mineSpeed;
                break;
            case 3:
            case 4:
            case 5://spawn mid
                Instantiate(minePrefab, midLaneSpawner).GetComponent<MineController>().speed = mineSpeed;
                break;
            case 6:
            case 7:
            case 8://spawn right
                Instantiate(minePrefab, rightLaneSpawner).GetComponent<MineController>().speed = mineSpeed;
                break;
            case 9: //spawn left & mid
                Instantiate(minePrefab, leftLaneSpawner).GetComponent<MineController>().speed = mineSpeed;
                Instantiate(minePrefab, midLaneSpawner).GetComponent<MineController>().speed = mineSpeed;
                break;
            case 10: //spawn left & right
                Instantiate(minePrefab, leftLaneSpawner).GetComponent<MineController>().speed = mineSpeed;
                Instantiate(minePrefab, rightLaneSpawner).GetComponent<MineController>().speed = mineSpeed;
                break;
            case 11: //spawn mid & right
                Instantiate(minePrefab, midLaneSpawner).GetComponent<MineController>().speed = mineSpeed;
                Instantiate(minePrefab, rightLaneSpawner).GetComponent<MineController>().speed = mineSpeed;
                break;
            default:
                Debug.LogError("shit done fucked when spawning!");
                break;
        }
    }
}
