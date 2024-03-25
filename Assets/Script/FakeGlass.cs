using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeGlass : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(BreakGlass());
        }
    }

    private IEnumerator BreakGlass()
    {
        GetComponent<Rigidbody>().useGravity = true;
        Debug.Log("Use Gravity");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("Destroyed");
        Destroy(gameObject);
    }
}
