using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HeartCollection : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D WhatHitMe)
    {
        // Enemy hit player, destory enemy 
        if (WhatHitMe.tag == "Player")
        {
            // Add life
            WhatHitMe.GetComponent<Player>().GainALife();
 
            //should destroy but teliport for now
            //Destroy(this.gameObject);


        }
    }









    
}