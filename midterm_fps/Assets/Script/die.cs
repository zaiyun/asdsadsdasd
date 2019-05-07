using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class die : MonoBehaviour
{
    public AudioSource dieSource;
    public AudioClip dieClip;

    // Start is called before the first frame update
    void Start()
    {
        dieSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        print("enter");
        if (collision.gameObject.tag == "Player")
        {
            dieSoundPlay();
            Invoke("RestartAgain", 1.2f);
        }
    }


    void dieSoundPlay() {

        dieSource.PlayOneShot(dieClip);
     
       }


    void RestartAgain() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
