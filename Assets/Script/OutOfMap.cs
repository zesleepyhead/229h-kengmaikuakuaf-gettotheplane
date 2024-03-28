using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfMap : MonoBehaviour
{
    
    AirPlane m_airplane;
    public GameObject plane;
    private void Start()
    {
        m_airplane = plane.GetComponent<AirPlane>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (m_airplane.CheckRespawnPlane()) 
        {
            plane.GetComponent<AirPlaneRespawn>().Respawn();
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerRespawn>().Respawn();
        }
    }
}
