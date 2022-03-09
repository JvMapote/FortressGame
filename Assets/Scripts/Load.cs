using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Load : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //going to different scene
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Credits");
        }
    }
}
