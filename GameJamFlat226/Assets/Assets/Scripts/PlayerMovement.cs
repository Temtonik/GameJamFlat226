using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;

    public static bool IsInputEnabled = true;
    public float secondToWait;

    //bool crouch = false;

    // Update is called once per frame
    void Update () {

        if (IsInputEnabled)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        }

        if (IsInputEnabled)
        {
            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
                animator.SetBool("IsJumping", true);
            }
        }

        if (Input.GetKeyDown("e") && IsInputEnabled == true)
        {
            IsInputEnabled = false; //disable all inputs
            StartCoroutine(DisableControl());
        }


        /*if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		} else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}*/

    }

	public void OnLanding ()
	{
		animator.SetBool("IsJumping", false);
	}

	/*public void OnCrouching (bool isCrouching)
	{
		animator.SetBool("IsCrouching", isCrouching);
	}*/

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
		jump = false;
	}

    IEnumerator DisableControl()
    {
        yield return new WaitForSeconds(secondToWait);
        IsInputEnabled = true;
    }
}
