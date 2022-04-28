using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{   AudioSource[] allSources;

    AudioSource jumpSound;
    AudioSource run;
    AudioSource land;
    AudioSource crouch;
    AudioSource cherry;
    // keep track of the jumping state ... 
    bool isJumping = false;
    
    // make sure to keep track of the movement as well !

    Rigidbody2D rb; // note the "2D" prefix 
    
    bool isPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        allSources = GetComponents<AudioSource>();
    
	    rb = GetComponent<Rigidbody2D>();

        jumpSound = allSources[0];
        run = allSources[1];
        land = allSources[2];
        crouch = allSources[3];
        cherry = allSources[4];
        



	// get the references to your audio sources here !        
    }
    
    

    // FixedUpdate is called whenever the physics engine updates
    void FixedUpdate()
    {float v = rb.velocity.magnitude;
     
        if (v > 1 && !isPlaying) {
            run.Play();
        isPlaying = true;
        } 
        else if (v < 1 && isPlaying)  {
            run.Stop();
        isPlaying = false;
     
        } 
      
	// Use the ridgidbody instance to find out if the fox is
	// moving, and play the respective sound !
	// Make sure to trigger the movement sound only when
	// the movement begins ...

	
    }
    
    // trigger your landing sound here !
    public void OnLanding() {
        if (isJumping = true); {
        print("the fox has landed");
        land.Play();
        }
        if (Random.Range(0,100)<50) {
            land.pitch = (1f / 3);
        }
        else if (Random.Range(0,100)>50) {
            land.pitch = (1f);
        }
	// to keep things cleaner, you might want to
	// play this sound only when the fox actually jumped ...
    }

    // trigger your crouching sound here
    public void OnCrouching() {
        print("the fox is crouching");
        crouch.Play();
    }
 
    // trigger your jumping sound here !
    public void OnJump() {
        if (isJumping = true); {
            jumpSound.Play();
        
        }
        print("the fox has jumped");
        if (Random.Range(0,100)<50) {
            jumpSound.pitch = (1f / 5);
        }
        else if (Random.Range(0,100)>50) {
            jumpSound.pitch = (1f);
        }
    }

    public void OnCherryCollect() {
        print("the fox has collected a cherry");
        cherry.Play();
    }
}
