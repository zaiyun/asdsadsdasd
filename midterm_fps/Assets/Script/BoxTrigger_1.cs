using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger_1 : MonoBehaviour
{
    private bool TargetStand = false;
    public bool TargetStood = false;
    public GameObject[] targets;
    Vector3 tpos;
  public  float control = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if(TargetStand == true&&TargetStood==false)
        {
            foreach(GameObject target in targets)
            {
//                print(target.transform.eulerAngles.x);
                if (target.transform.eulerAngles.x <= 270 && target.transform.eulerAngles.x != 0)
                {
                    TargetStood = true;
                  }
                else
                {
                    target.transform.Rotate(0, 1*control, 0);
                    //       tpos = target.transform.rotation.eulerAngles;
                    //control = tpos.x;
                    //tpos.x -= 1;

                    //target.transform.eulerAngles = tpos;
                }
            }
        }
        if (TargetStood == true)
        {
            foreach(GameObject target in targets)
            {
                if(target.GetComponent<collsionTrigger>().hit == true)
                {
                    if (target.transform.eulerAngles.x <= 2 && target.transform.eulerAngles.x != 0)
                    {
                        TargetStood = true;
                    }
                    else
                    {

                        target.transform.Rotate(0, -1*control, 0);
                    }
                }
            }
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            TargetStand = true;
        }
    }
}
