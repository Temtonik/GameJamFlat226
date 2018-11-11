using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

    public Vector3 initialPosPlayer;
    public Transform playerPos, respawnPos;

    // Use this for initialization
    void Start () {
        initialPosPlayer = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerPos.transform.position = respawnPos.transform.position;
        }
    }
}
