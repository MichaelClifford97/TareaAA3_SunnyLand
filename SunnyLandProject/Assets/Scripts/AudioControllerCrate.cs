using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class AudioControllerCrate : MonoBehaviour
{
    AudioSource crate;
    AudioSource rumble;
  
    // Start is called before the first frame update
    void Start()
    {
        crate = GetComponent<AudioSource>();
        rumble = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D (Collision2D coll) {

        crate.Play();
        rumble.Play();  


    }


}
