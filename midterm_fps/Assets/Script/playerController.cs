using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float slowdownFactor = 0.2f;
    Rigidbody rb;
    public float moveSpeed;
    public float jumpHeight;
    public float fpForward;
    public float fpStrafe;

    public Vector3 inputVector;
    public Vector3 outputVector;
    public Vector3 jumpVector;
   public static bool isgrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpVector = new Vector3(0,1,0);
}

    // Update is called once per frame
    void Update()
    {


        fpForward = Input.GetAxis("Vertical");
        fpStrafe = Input.GetAxis("Horizontal");
        if (isgrounded == true) { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpHeight = 2f;
             
                isgrounded = false;
        }

        }
        else
        {
            if (jumpHeight > 0)
            {
                jumpHeight -= 0.1f;
            }
        }
        inputVector = transform.forward * fpForward;
        inputVector += transform.right * fpStrafe;
        inputVector += jumpVector * jumpHeight;
        if (Input.GetKey(KeyCode.E))
        {
            slowMo();
        }
        else
        {
            normalMo();
        }
    }

    private void FixedUpdate()
    {

        rb.velocity = inputVector * moveSpeed + (Physics.gravity * 0.69f);

        outputVector = rb.velocity;
    }


    private void slowMo ()
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
