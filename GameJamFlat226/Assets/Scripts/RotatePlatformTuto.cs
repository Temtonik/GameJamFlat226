using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatformTuto : MonoBehaviour {

    public float moveSpeedZ;
    public float secondToWait;

    public bool switchRotate = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(switchRotate)
        {
            StartCoroutine(RotationSwitchLeft());
            transform.Rotate(new Vector3(Time.deltaTime * 0, Time.deltaTime * 0, Time.deltaTime * moveSpeedZ));
        }
        if (!switchRotate)
        {
            StartCoroutine(RotationSwitchRight());
            transform.Rotate(new Vector3(Time.deltaTime * 0, Time.deltaTime * 0, Time.deltaTime * -moveSpeedZ));
        }
    }

    IEnumerator RotationSwitchLeft()
    {
        yield return new WaitForSeconds(secondToWait);
        switchRotate = false;
    }

    IEnumerator RotationSwitchRight()
    {
        yield return new WaitForSeconds(secondToWait);
        switchRotate = true;
    }
}
