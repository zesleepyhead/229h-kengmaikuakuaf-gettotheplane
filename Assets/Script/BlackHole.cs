using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public float gravitationalConstant = 6.67f;  // Gravitational constant G
    public float planetMass = 100f;               // Mass of the planet
    public float radius = 10f;                          // Radius of planet influence

    // Update is called once per frame
    void FixedUpdate()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider collider in colliders)
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();

            if (rb != null)
            {
                Vector3 direction = transform.position - collider.transform.position;
                float distance = direction.magnitude;

                if (distance > 0)  // Avoid division by zero
                {
                    // Calculate the gravitational force
                    float forceMagnitude = gravitationalConstant * (planetMass * rb.mass) / (distance * distance);

                    // Apply the gravitational force to the object
                    rb.AddForce(direction.normalized * forceMagnitude, ForceMode.Force);
                }
            }
        }
    }
}
