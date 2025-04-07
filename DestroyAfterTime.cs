using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
   public float destroyTime = 5f; // Time in seconds before destruction

        void Start()
        {
            Destroy(gameObject, destroyTime);
        }
   
}
