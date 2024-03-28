using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRespawn : MonoBehaviour
{
    public Transform respawnPoint; // Set this in the Inspector to the position where you want the ball to respawn

    void Update()
    {
        // Check for the 'R' key press
        if (Input.GetKeyDown(KeyCode.R))
        {
            Respawn();
        }
    }

    void Respawn()
    {
        // Reset ball's position to the respawn point
        transform.position = respawnPoint.position;
        // You may want to reset its velocity too, depending on your game's requirements
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}