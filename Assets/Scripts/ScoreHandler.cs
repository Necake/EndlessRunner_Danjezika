using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour {
    public Text scoreText;
    public static int score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        score = ((int)(Time.timeSinceLevelLoad * 4.2f));
        scoreText.text = "Rezultat: " + score.ToString();
	}
}
