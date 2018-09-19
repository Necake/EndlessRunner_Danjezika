using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickLevelSwitch : MonoBehaviour {

	// Use this for initialization
	
    public void LoadLevel(int lvlIndex)
    {
        SceneManager.LoadScene(lvlIndex);
    }
}
