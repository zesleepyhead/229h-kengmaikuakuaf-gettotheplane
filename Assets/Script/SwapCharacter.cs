using System.Collections;
using System.Collections.Generic;
using Supercyan.FreeSample;
using UnityEngine;
using Cinemachine;

public class SwapCharacter : MonoBehaviour
{
    public GameObject airPlane;
    public CinemachineVirtualCamera cam;
    private AirPlane m_airPlane;

    private void Start()
    {
        airPlane = GameObject.Find("AirPlane");
        m_airPlane = airPlane.GetComponent<AirPlane>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           
            other.GetComponent<SimpleSampleCharacterControl>().enabled = false;
            other.gameObject.SetActive(false);
            cam.gameObject.SetActive(false);
            airPlane.GetComponent<AirPlane>().enabled = true;
            if(m_airPlane != null)
            {
                m_airPlane.SwapCharacter();
            }
        }
    }

}
