using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKey("x"))
        {
            ScoreTextScript.coinAmount += 1;
            gameObject.SetActive(false);
           
        }

    }
}