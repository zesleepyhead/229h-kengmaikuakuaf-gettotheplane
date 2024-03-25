using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform startPoint;
    public GameObject gameManager;
    private Vector3 lastCheckPoint;
    private int currentScore = 0;

    public void SaveCheckPoint(Vector3 position)
    {
        lastCheckPoint = position;
    }
    public void Respawn()
    {
        currentScore = gameManager.GetComponent<CheckPoint>().CheckScore();

        if (currentScore != 0)
        {
            transform.position = lastCheckPoint;
        } else
        {
            transform.position = startPoint.position;
        }
    }
}
