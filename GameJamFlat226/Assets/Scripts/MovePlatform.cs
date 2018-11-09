using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour {

    public float moveSpeedX;
    public float moveSpeedY;
    public bool moveRight = true;
    public float secondToWait;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (moveRight == true)
        {
            StartCoroutine(MovementSwitchLeft());
            transform.position = new Vector2(transform.position.x + moveSpeedX * Time.deltaTime, transform.position.y + moveSpeedY * Time.deltaTime);
        }
        else
        {
            StartCoroutine(MovementSwitchRight());
            transform.position = new Vector2(transform.position.x - moveSpeedX * Time.deltaTime, transform.position.y - moveSpeedY * Time.deltaTime);
        }
    }

    IEnumerator MovementSwitchLeft()
    {
        yield return new WaitForSeconds(secondToWait);
        moveRight = false;
    }

    IEnumerator MovementSwitchRight()
    {
        yield return new WaitForSeconds(secondToWait);
        moveRight = true;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.collider.transform.SetParent(transform);
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.collider.transform.SetParent(null);
        }
    }
}
