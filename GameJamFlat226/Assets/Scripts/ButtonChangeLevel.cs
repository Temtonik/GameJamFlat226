using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonChangeLevel : MonoBehaviour {

    public GameObject imageTuto;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            imageTuto.SetActive(false);
        }
    }
}
