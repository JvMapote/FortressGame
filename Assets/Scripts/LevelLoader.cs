using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    int set;
   
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        //conditions for scenes
        if (Input.GetMouseButtonDown(0))
        {
            //SceneManager.LoadScene("Scene B");
        
            set = SceneManager.GetActiveScene().buildIndex;
            LoadNextLevel();
            
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    public void LoadNextLevel()
    {
        //conditions for scenes
        if (set == 0)
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
            //SceneManager.LoadScene("Scene B");
        }
        else if (set == 1)
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
            //SceneManager.LoadScene("SampleScene");
        }
        else if (set == 2)
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }
        else if (set == 3) {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }
        else
        {
            SceneManager.LoadScene("SampleScene");
        }
        //SceneManager.LoadScene("SampleScene");




    }
    IEnumerator LoadLevel(int levelIndex)
    {
        //value
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
        
    }
}
