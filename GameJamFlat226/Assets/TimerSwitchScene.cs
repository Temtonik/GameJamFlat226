using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerSwitchScene : MonoBehaviour {

    public float DelayTime;
    public string NextLevel;

	// Use this for initialization
	void Start () {
        StartCoroutine(SwitchScene());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(DelayTime);
        SceneManager.LoadScene(NextLevel);
    }
}
