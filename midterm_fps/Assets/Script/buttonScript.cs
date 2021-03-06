﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour
{
    public GameObject main;
    public Collider trigger;

    //audio
    public AudioSource audioSourcePop;
    public AudioClip audioClipPop; 
    
 //   public Object popoutscript;
    // Start is called before the first frame update
    void Start()
    {
        audioSourcePop = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PopOutScript.disableAll == true)
        {
            trigger.enabled = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "projectile")
        {
            PopOutScript.disableAll = false;
            trigger.enabled = !trigger.enabled;
            main.GetComponent<PopOutScript>().pop = !main.GetComponent<PopOutScript>().pop;

            //audio
            audioSourcePop.PlayOneShot(audioClipPop);
        }
    }
}
