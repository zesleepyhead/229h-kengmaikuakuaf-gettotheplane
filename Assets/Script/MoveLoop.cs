using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLoop : MonoBehaviour
{
    public Transform startPoint;    // Starting waypoint
    public Transform endPoint;      // Ending waypoint
    public float moveSpeed = 2f;    // Speed of movement

    private Transform currentTarget; // Current target waypoint

    void Start()
    {
        // Set the initial target as the starting point
        currentTarget = startPoint;
    }

    void Update()
    {
        // Move towards the current target
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, moveSpeed * Time.deltaTime);

        // Check if the object has reached the current target
        if (Vector3.Distance(transform.position, currentTarget.position) < 0.01f)
        {
            // If the current target is the starting point, set the target to the ending point, and vice versa
            if (currentTarget == startPoint)
            {
                currentTarget = endPoint;
            }
            else
            {
                currentTarget = startPoint;
            }
        }
    }
}
