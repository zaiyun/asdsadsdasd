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
    public float speed = 6.0f;
    public float rotateSpeed = 6.0f;
    private float gravity = 400.0f;
    public float jumpSpeed = 8.0f;

    private Vector3 moveDirection =  Vector3.zero;
    private CharacterController controller;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {

        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        moveDirection.y -= gravity*Time.deltaTime;
        if (Input.GetButton("Jump"))
        {
            moveDirection.y = jumpSpeed;
        }

        controller.Move(moveDirection * Time.deltaTime);
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
