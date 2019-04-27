using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootProjectile : MonoBehaviour
{
    public Rigidbody projectile;
    private float timer;
    private float spawnRate;
    private float speed = 40;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(0, 60);
        spawnRate = Random.Range(60, 200);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        timer++;
        if (timer > spawnRate)
        {
        
            spawnRate = Random.Range(60, 200);
            speed = Random.Range(20, 25);
            Rigidbody clone;
            clone = Instantiate(projectile, this.transform.position, transform.rotation);
            clone.velocity = this.transform.TransformDirection(Vector3.up*speed);
           
            timer = 0;
        }
    }
}
