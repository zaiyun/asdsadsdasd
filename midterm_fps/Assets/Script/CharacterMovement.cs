using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** 
 * This script controlls the movement of Stanley using WASD
 * 
 * @author Zaiyun Lin
 */

public class CharacterMovement : MonoBehaviour
{
    private float slowdownFactor = 0.2f;


    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    private float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
    

        if (Input.GetKey(KeyCode.E))
        {
            slowMo();
        }
        else
        {
            normalMo();
        }

    }
    private void slowMo()
    {
        print(Time.timeScale);
        print(Time.fixedDeltaTime);
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = slowdownFactor * 0.02f;

    }
    private void normalMo()
    {
        Time.timeScale = 1;
        Time.fixedDeltaTime = 0.02f;

    }
}
