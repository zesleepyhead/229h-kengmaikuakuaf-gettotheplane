using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    private Rigidbody rb;
    public Transform player;
 
    public Vector3 angularV, sVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, player.position) < 10f)
        {
            if ( Input.GetKeyDown( KeyCode.E ) )
            {
                rb.angularVelocity = angularV;
                rb.velocity = sVelocity;
            }
            rb.AddForce( Vector3.Cross ( rb.angularVelocity , rb.velocity ) );
        }
    }
}
