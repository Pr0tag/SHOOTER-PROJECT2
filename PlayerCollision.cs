using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Example: Check if the player collided with an object tagged "Enemy"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player collided with an enemy!");
            // Add your collision response code here (e.g., damage, respawn, etc.)
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        // Example: Check if the player is still colliding with an object tagged "Ground"
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Add your collision response code here (e.g., allow jumping)
            Debug.Log("Player is grounded");
        }
    }
}