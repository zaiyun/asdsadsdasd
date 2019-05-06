using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioPlay : MonoBehaviour
{



    public AudioSource DeathSound;
   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //if(FpsController.Jumping == true) {

        //    Hop.Play();
        
        //}

        if(LazerScript.diehard == true) {


            DeathSound.Play();
           
             }
    }

}
