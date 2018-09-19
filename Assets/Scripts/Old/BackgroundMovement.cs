using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour {

    public float movementSpeed;
    MeshRenderer mr;
    Material mat;
    // Use this for initialization
    void Start () {
        mr = GetComponent<MeshRenderer>();
        mat = mr.material;
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 offset = mat.mainTextureOffset;
        offset.y += ((15 / transform.localScale.y) / 8);
        mat.mainTextureOffset = offset;
	}
}
