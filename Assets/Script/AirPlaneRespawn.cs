using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPlaneRespawn : MonoBehaviour
{
    public Transform startPoint;
    public void Respawn()
    {
        transform.position = startPoint.position;
        transform.rotation = Quaternion.identity;
    }
}
