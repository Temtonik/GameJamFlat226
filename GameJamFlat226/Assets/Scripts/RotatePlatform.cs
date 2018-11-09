using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour {

    public float moveSpeedZ;
    public float moveSpeedY;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(Time.deltaTime * 0, Time.deltaTime * moveSpeedY, Time.deltaTime * moveSpeedZ));
	}
}
