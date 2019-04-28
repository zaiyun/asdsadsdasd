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
    public int ammo = 4;
    public bool outOfAmmo = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        spawn = spawnPos.position;

        //autoMode
        //if (Input.GetMouseButton(0)&&outOfAmmo ==false)
        //{

        //    if (timer > 8)
        //    {
        //        Rigidbody clone;
        //        audio.PlaÏOneShot(audio.clip);
        //        clone = Instantiate(projectile, spawn, transform.rotation);
        //        clone.velocity = Camera.main.transform.TransformDirection(Vector3.forward * speed);

        //        timer = 0;
        //        ammoDetection();
        //    }
        //}
        if (Input.GetMouseButtonDown(0) && outOfAmmo == false)
        {

            Rigidbody clone;
            audio.PlayOneShot(audio.clip);
            clone = Instantiate(projectile, spawn, transform.rotation);
            clone.velocity = Camera.main.transform.TransformDirection(Vector3.forward * speed);
            ammo -= 1;
            timer = 0;
        }
        ammoDetection();
        if (Input.GetKeyDown(KeyCode.R))
        {
            reload();
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




            timer += 60 * Time.deltaTime;



        }


    }
    void ammoDetection()
    {

        if (ammo <= 0)
        {
            outOfAmmo = true;
        }
        else
        {
            outOfAmmo = false;
        }
    }
    void reload()
    {
        ammo = 4;
        PopOutScript.disableAll = true;
      

    }



}
