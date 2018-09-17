using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    int playerLane;
    public float moveSpeed;
    public float laneSize = 2.0f;
    Vector3 dest;
	// Use this for initialization
	void Start () {
        playerLane = 1; //ranges from 0 to 2
        dest = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A) && playerLane > 0)
        {//ide levo ako ima gde
            playerLane--;
            dest += new Vector3(-laneSize, 0, 0);
        }
        else if(Input.GetKeyDown(KeyCode.D) && playerLane < 2)
        {//ide desno ako ima gde
            playerLane++;
            dest += new Vector3(laneSize, 0, 0);
        }

        transform.position = Vector3.MoveTowards(transform.position, dest, Time.deltaTime * moveSpeed);
    }

}
