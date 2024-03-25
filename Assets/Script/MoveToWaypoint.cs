using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToWaypoint : MonoBehaviour
{
    public GameObject targetPosition;
    public float speed = 2;
    private bool startBuild = false;

    void Update()
    {
        if (startBuild)
        {
            Vector3 newPos = Vector3.MoveTowards(transform.position, targetPosition.transform.position, speed * Time.deltaTime);
            transform.position = newPos;
        }
    }
    public void Building()
    {
        startBuild = true;
    }

}

