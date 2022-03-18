using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upscript : MonoBehaviour
{
    private PlatformEffector2D effector;
    public float waitTime;
    
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    
    void Update()
    {
       
        if (Input.GetButtonUp("Crouch"))
        {
            waitTime = 0.5f;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            if (waitTime <= 0)
            {
                effector.rotationalOffset = 180f;
                waitTime = 0.5f;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }

        }
        if (Input.GetButtonDown("Jump"))
        {
            effector.rotationalOffset = 0f;
        }
    }
}
