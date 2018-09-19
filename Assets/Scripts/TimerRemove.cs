using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerRemove : MonoBehaviour {
    public GameObject cleanUp;
	// Use this for initialization
	void Start () {
        cleanUp = GameObject.FindGameObjectWithTag("Cleanup");
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < cleanUp.transform.position.y)
            Destroy(gameObject);
	}
}
