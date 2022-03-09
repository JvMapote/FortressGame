using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTextScript : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;
    Text text;
    public static int itemAmount;
    public static int counts;
    // Start is called before the first frame update
    void Start()
    {
        //The timer
        currentTime = startingTime;
        counts = 6;
        itemAmount = 0;
        text = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {

        //every second it will lose 1 value
        currentTime -= 1 * Time.deltaTime;

        //conditions for scenes
        if (currentTime <= 0)
        {
            if (itemAmount <= 4)
            {
                SceneManager.LoadScene("Scene D");
            }
            else
            {
                SceneManager.LoadScene("SampleScene");
            }

            
        }
    
            if (itemAmount >= 5)
            {
            SceneManager.LoadScene("Scene C");

        }

    text.text = itemAmount.ToString();
    }
}
