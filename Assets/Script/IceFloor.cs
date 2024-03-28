using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceFloor : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object colliding with the ice floor is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Reduce friction of the player's physics material
            collision.collider.material.dynamicFriction = 0.01f;
            collision.collider.material.staticFriction = 0.01f;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Reset the friction when the player leaves the ice floor
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.collider.material.dynamicFriction = 0.6f; // Reset to default value
            collision.collider.material.staticFriction = 0.6f; // Reset to default value
        }
    }
}