using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertControls : MonoBehaviour {

    public PlayerMovement my_PlayerMovement;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "TriggerJumpControl")
        {
            my_PlayerMovement.IsInputJumpEnabled = false;
        }

        if (other.gameObject.tag == "TriggerMoveControl")
        {
            StartCoroutine(MoveInverseTrue());
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "TriggerJumpControl")
        {
            my_PlayerMovement.IsInputJumpEnabled = true;
        }

        if (other.gameObject.tag == "TriggerMoveControl")
        {
            StartCoroutine(MoveInverseFalse());
        }
    }

    IEnumerator MoveInverseTrue()
    {
        yield return new WaitForSeconds(1f);
        my_PlayerMovement.IsInputMoveEnabled = false;
    }

    IEnumerator MoveInverseFalse()
    {
        yield return new WaitForSeconds(1f);
        my_PlayerMovement.IsInputMoveEnabled = true;
    }

}
