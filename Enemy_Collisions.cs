using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Collisions : MonoBehaviour
{
    // The target position  to move the object to
    public Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D WhatHitMe)
    {
            // Enemy hit player, destory enemy 
            if (WhatHitMe.tag == "Player")
            {
                // Subtract life
                WhatHitMe.GetComponent<Player>().LoseALife();
                //should destroy but teliport for now
                //Destroy(this.gameObject);
                transform.position = targetPosition;
        }

            // Enemy hit bullet, then bullet and enemy destroyed
            else if (WhatHitMe.tag == "Weapons")
            {
                Destroy(WhatHitMe.gameObject);
                //should destroy but teliport for now
                //Destroy(this.gameObject);
                transform.position = targetPosition;
        }
    }


}
