using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
   
    public static AudioClip jumpSound;
    //public static AudioClip walkingSound;
    public static AudioClip collectSound;
    static AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        //components
        jumpSound = Resources.Load<AudioClip>("JumpingSound");
        //walkingSound = Resources.Load<AudioClip>("WalkingSound");
        collectSound = Resources.Load<AudioClip>("CollectSound");

        audioSource = GetComponent<AudioSource>();
    }
    
    public static void PlaySound(string clip)
    {
        //conditions
        switch (clip)
        {
            case "JumpingSound":

               


                audioSource.PlayOneShot(jumpSound, 1f);               
                break;

            case "CollectSound":
                audioSource.PlayOneShot(collectSound);
                break;
            
        }
    }

    
        
    
}
