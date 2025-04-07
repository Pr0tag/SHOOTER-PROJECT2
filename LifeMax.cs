using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LifeMax : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D WhatHitMe)
    {
        // Enemy hit player, destory enemy 
        if (WhatHitMe.tag == "Player")
        {
            // Max Life
            WhatHitMe.GetComponent<Player>().MaxLife();

            //should destroy but teliport for now
            //Destroy(this.gameObject);


        }
    }
}

