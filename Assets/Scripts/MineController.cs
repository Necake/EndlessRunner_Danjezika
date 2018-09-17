using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineController : MonoBehaviour {
    Rigidbody2D rb;
    Vector3 velocity;
    public float speed;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        velocity = new Vector3(0, -speed, 0);
        rb.velocity = velocity;
	}
}
