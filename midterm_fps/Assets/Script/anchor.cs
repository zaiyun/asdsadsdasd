using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anchor : MonoBehaviour
{
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos.y = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        pos.x = this.GetComponentInParent<Transform>().position.x;
        pos.z = this.GetComponentInParent<Transform>().position.z;
        this.transform.position = pos;

    }
}
