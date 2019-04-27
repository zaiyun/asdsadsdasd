using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopOutScript : MonoBehaviour
{
    private Transform popoutObj;
    BoxCollider coll;
    float length;
    Vector3 position;
    public float popOutDistance;
    bool pop = false;
    // Start is called before the first frame update
    void Start()
    {

        popoutObj = this.transform.Find("PopOut");
        //coll = popout.GetComponent<BoxCollider>();
        //length = coll.bounds.size.y;
        position = popoutObj.localPosition;
        //print(length);
        //position.y = 0 - (length / 2.0f);
        //popout.localPosition = position;
    }

    // Update is called once per frame
    void Update()
    {
        if (pop)
        {
        
            position = popoutObj.localPosition;
            position.y = popOutDistance;
            popoutObj.localPosition = position;


        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "projectile")
        {
            pop = !pop;
        }
    }
}