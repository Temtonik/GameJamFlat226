using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour {

    public float moveSpeedZ;
    public float rotateSpeedZ;
    public bool rotateRight = true;
    public float secondToWait;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (rotateRight)
        {
            StartCoroutine(RotateSwitchLeft());
            transform.Rotate(new Vector3(Time.deltaTime * 0, Time.deltaTime * 0, Time.deltaTime * rotateSpeedZ));
            transform.position = new Vector3(transform.position.x + 0 * Time.deltaTime, transform.position.y + 0 * Time.deltaTime, transform.position.z + moveSpeedZ * Time.deltaTime);
        }
        else
        {
            StartCoroutine(RotateSwitchRight());
            transform.Rotate(new Vector3(Time.deltaTime * 0, Time.deltaTime * 0, Time.deltaTime * -rotateSpeedZ));
            transform.position = new Vector3(transform.position.x + 0 * Time.deltaTime, transform.position.y + 0 * Time.deltaTime, transform.position.z - moveSpeedZ * Time.deltaTime);
        }
    }


    IEnumerator RotateSwitchLeft()
    {
        yield return new WaitForSeconds(secondToWait);
        rotateRight = false;
    }

    IEnumerator RotateSwitchRight()
    {
        yield return new WaitForSeconds(secondToWait);
        rotateRight = true;
    }
}
