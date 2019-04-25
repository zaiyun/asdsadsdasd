using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collsionTrigger : MonoBehaviour
{
    public bool hit = false;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GameObject.Find("testTarget").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "projectile")
        {
            hit = true;
            audio.PlayOneShot(audio.clip);
        }
    }
}
