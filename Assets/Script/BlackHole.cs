using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public Rigidbody rb;
 
    private const float G = 6.67f;
 
    public static List<BlackHole> pAttraction;

    public float gravitationalRadius ;

    void AttractorFormular(BlackHole other )
    {
        Rigidbody rbOther = other.rb;
 
        Vector3 direction = rb.position - rbOther.position;

        float distance = direction.magnitude; // Declare the distance variable here
        // Check if the distance is within the gravitational radius
        if (distance < gravitationalRadius)
        {
            // Calculate and apply gravitational force
            float forceMagnitude = G * (rb.mass * rbOther.mass) / Mathf.Pow(distance, 2);
            Vector3 forceDir = direction.normalized * forceMagnitude;
            rbOther.AddForce(forceDir);
        }
    }//AttractorFormular

    void FixedUpdate()
    {
        foreach ( var attraction in pAttraction)
        {
            if (attraction != this)
            {
                AttractorFormular(attraction);
            }
        }
    }//FixedUpdate

    private void OnEnable()
    {
        if ( pAttraction == null )
        {
            pAttraction = new List<BlackHole>();
        }
 
        pAttraction.Add(this);
 
    }//

    // public float gravitationalConstant = 6.67f;  // Gravitational constant G
    // public float planetMass = 100f;               // Mass of the planet
    // public float radius = 10f;                          // Radius of planet influence

    // // Update is called once per frame
    // void FixedUpdate()
    // {
    //     Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

    //     foreach (Collider collider in colliders)
    //     {
    //         Rigidbody rb = collider.GetComponent<Rigidbody>();

    //         if (rb != null)
    //         {
    //             Vector3 direction = transform.position - collider.transform.position;
    //             float distance = direction.magnitude;

    //             if (distance > 0)  // Avoid division by zero
    //             {
    //                 // Calculate the gravitational force
    //                 float forceMagnitude= gravitationalConstant * (planetMass * rb.mass) / (distance * distance);

    //                 // Apply the gravitational force to the object
    //                 rb.AddForce(direction.normalized * forceMagnitude, ForceMode.Force);
    //             }
    //         }
    //     }
    // }
}
