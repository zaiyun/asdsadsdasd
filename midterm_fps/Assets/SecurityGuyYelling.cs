using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityGuyYelling : MonoBehaviour
{
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)

    {
        if (this.GetComponentInParent<collsionTrigger>().hit == false)
        {
            audio.PlayOneShot(audio.clip);
        }
    }
}
