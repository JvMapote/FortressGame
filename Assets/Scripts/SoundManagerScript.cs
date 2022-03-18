using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
   
    public static AudioClip jumpSound;
    public static AudioClip collectSound;
    static AudioSource audioSource;


    void Start()
    {
     
        jumpSound = Resources.Load<AudioClip>("JumpingSound");
        collectSound = Resources.Load<AudioClip>("CollectSound");

        audioSource = GetComponent<AudioSource>();
    }
    
    public static void PlaySound(string clip)
    {
        
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
