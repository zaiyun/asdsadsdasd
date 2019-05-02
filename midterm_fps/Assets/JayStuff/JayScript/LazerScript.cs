using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LazerScript : MonoBehaviour
{
    
    private LineRenderer Lr;
    // Start is called before the first frame update
    void Start()
    {
        Lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Lr.SetPosition(0, transform.position);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {

            if (hit.collider)
            {

                Lr.SetPosition(1, hit.point);

            }

            if (hit.collider.tag == "Player") {

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            }

        }
        else Lr.SetPosition(1, transform.forward * 5000);
    }
}
