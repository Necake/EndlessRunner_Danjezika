using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCtrl : MonoBehaviour {
    int playerLane = 1;
    float laneSize = 4;
    public float runSpeed = 5, laneSpeed = 4;

    Vector3 dest;
    Rigidbody2D rb;
    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        dest = transform.position;
    }

	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.A) && playerLane > 0)
        {
            anim.SetInteger("Direction", -1);
            playerLane--;
            if(playerLane == 0)
            {
                dest = transform.position;
                dest.x = -laneSize;
            }
            else
            {
                dest = transform.position;
                dest.x = 0;
            }
            
        }
        else if(Input.GetKeyDown(KeyCode.D) && playerLane < 2)
        {
            anim.SetInteger("Direction", 1);
            playerLane++;
            if (playerLane == 1)
            {
                dest = transform.position;
                dest.x = 0;
            }
            else
            {
                dest = transform.position;
                dest.x = laneSize;
            }
        }
        else
        {
            anim.SetInteger("Direction", 0);
        }
        rb.velocity = new Vector2(0, runSpeed);
        dest.y = transform.position.y;
        transform.position = Vector3.MoveTowards(transform.position, dest, Time.deltaTime * laneSpeed);
        runSpeed = Time.timeSinceLevelLoad / 6 + 7;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        //if its a mine then die lol
        if (other.gameObject.CompareTag("Traps"))
        {
            SceneManager.LoadScene(1); //game over scene
        }

    }
}
