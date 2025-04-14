using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PowerupScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D WhatDidIHit)
    {
        // Enemy hit player, destory enemy 
        if (WhatDidIHit.tag == "Player")
        {
            // Subtract life
            Destroy(gameObject);
            //should destroy but teliport for now
            //Destroy(this.gameObject);
           
        }

        // Enemy hit bullet, then bullet and enemy destroyed
       
    }
}
