using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LazerScript : MonoBehaviour
{
    
    private LineRenderer Lr;
    public static bool diehard;
    public GameObject Player;
    public AudioSource Lazeraudio;
    public AudioClip Deathaudio;
    
    // Start is called before the first frame update
    void Start()
    {
        Lr = GetComponent<LineRenderer>();
        diehard = false;
        Lazeraudio = GetComponent<AudioSource>();
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
                diehard = true;

                Player.GetComponent<FpsController>().walkSpeed = 0f;
               
                Invoke("GameRestartScene", 1.3f);

            }
            else {

                diehard = false;
               }

        }
        else Lr.SetPosition(1, transform.forward * 5000);


        //Play Sound
        SoundPlay();
    }




    void GameRestartScene()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }

    void SoundPlay() {
    
     if(diehard == true) {


            Lazeraudio.PlayOneShot(Deathaudio, 1f);
     }


    }

}




