using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningUI : MonoBehaviour {

    public PlayerMovement my_PlayerMovement;

    public GameObject jumpWarning;
    public GameObject moveWarning;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (my_PlayerMovement.IsInputJumpEnabled)
        {
            jumpWarning.SetActive(false);
        }
        if (!my_PlayerMovement.IsInputJumpEnabled)
        {
            jumpWarning.SetActive(true);
        }


        if (my_PlayerMovement.IsInputMoveEnabled)
        {
            moveWarning.SetActive(false);
        }
        if (!my_PlayerMovement.IsInputMoveEnabled)
        {
            moveWarning.SetActive(true);
        }
    }
}
