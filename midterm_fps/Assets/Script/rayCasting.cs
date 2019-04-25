using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using Color = UnityEngine.Color;

public class rayCasting : MonoBehaviour
{
    float rayDistance = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = new Ray(this.transform.position, Vector3.down);
        Debug.DrawRay(myRay.origin,new Vector3(0,-rayDistance,0), Color.red);

        if (Physics.Raycast(myRay, rayDistance))
        {

            playerController.isgrounded = true;
        }
        else
        {
            playerController.isgrounded = false;
        }

    } 

}
