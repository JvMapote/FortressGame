﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        //condition
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Intro");
        }

    }
}
