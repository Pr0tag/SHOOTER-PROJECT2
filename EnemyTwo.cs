using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo: MonoBehaviour
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
        // speed object falls(0, -???, 0) over time
        transform.Translate(new Vector3(0, -3, 0) * Time.deltaTime * 3f);

        // Teleport object if reaches set y position
        // cant respawn deleted object bc its null (find workaround)
        if (transform.position.y < -6.5f)
        {
            transform.position = targetPosition;
        }
    }
}
