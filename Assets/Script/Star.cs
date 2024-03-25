using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public GameObject gameManager;
    private Rigidbody rb;

    private void Start() 
    {
        rb = gameObject.GetComponent<Rigidbody>();    
    }

    private void Update() 
    {
            rb.AddTorque(0,1,0);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.GetComponent<CheckPoint>().AddScore();
            other.gameObject.GetComponent<PlayerRespawn>().SaveCheckPoint(transform.position);
            Destroy(gameObject);
        }
    }
}
