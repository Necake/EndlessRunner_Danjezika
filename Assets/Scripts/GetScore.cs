using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour {

    public Text shadow, hsShadow, hsText;
    static int maxScore = 0;
    // Use this for initialization
    void Start () {
        Text text = GetComponent<Text>();
        text.text += ScoreHandler.score.ToString();
        if(ScoreHandler.score > maxScore)
        {
            hsText.text = "Najbolji rezultat:" + ScoreHandler.score;
            hsShadow.text = hsText.text;
        }
        shadow.text = text.text;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
