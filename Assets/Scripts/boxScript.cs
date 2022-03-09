using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    //When the items collides with the player
    private void OnTriggerEnter2D(Collider2D col)
    {
        SoundManagerScript.PlaySound("CollectSound");
        ScoreTextScript.itemAmount += 1;
        Destroy(gameObject);
    }

}
