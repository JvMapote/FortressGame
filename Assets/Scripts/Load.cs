using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Load : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        //going to different scene
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Credits");
        }
    }
}
