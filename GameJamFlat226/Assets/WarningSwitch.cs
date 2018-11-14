using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarningSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Delay());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Main");
    }
}
