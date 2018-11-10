using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;

    public bool IsInputJumpEnabled = true;
    public bool IsInputMoveEnabled = true;

    //bool crouch = false;

    // Update is called once per frame
    void Update () {

        if (IsInputMoveEnabled)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        }

        if (IsInputJumpEnabled)
        {
            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
                animator.SetBool("IsJumping", true);
            }
        }

        if (!IsInputMoveEnabled)
        {
            horizontalMove = Input.GetAxisRaw("HorizontalInverse") * runSpeed;

            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        }

        if (!IsInputJumpEnabled)
        {
            if (Input.GetButtonDown("JumpInverse"))
            {
                jump = true;
                animator.SetBool("IsJumping", true);
            }
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
}
