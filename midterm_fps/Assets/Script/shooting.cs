using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Rigidbody projectile;
    public float timer = 0;
    Vector3 spawn;
    public float speed = 40;
    public Transform spawnPos;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    private void Update()
    {
        spawn = spawnPos.position;

        if (Input.GetMouseButton(0))
        {
              
            if (timer > 8)
            {
                Rigidbody clone;
                audio.PlayOneShot(audio.clip);
                clone = Instantiate(projectile, spawn, transform.rotation);
                clone.velocity = Camera.main.transform.TransformDirection(Vector3.forward * speed);
               
                timer = 0;
               
            }


        }
        if (Input.GetMouseButtonDown(0))
        {

            Rigidbody clone;
            audio.PlayOneShot(audio.clip);
            clone = Instantiate(projectile, spawn, transform.rotation);
            clone.velocity = Camera.main.transform.TransformDirection(Vector3.forward * speed);

            timer = 0;
        }
        if (Input.GetMouseButtonDown(0))
        {
            timer = 0;
        }
    }
    void FixedUpdate()
    {
     
        if (Input.GetMouseButton(0))
        {




            timer+= 60 * Time.deltaTime;
           


        }


    }

 
    
} 
