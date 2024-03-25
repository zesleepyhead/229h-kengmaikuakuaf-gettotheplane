using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTrigger : MonoBehaviour
{
    public Transform[] objectsToMove;

    void OnTriggerEnter(Collider other)
    {

        StartCoroutine(MoveObjectsWithCooldown());
    }

    private IEnumerator MoveObjectsWithCooldown()
    {
        for (int currentIndex = 0; currentIndex < objectsToMove.Length; currentIndex++)
        {
            objectsToMove[currentIndex].GetComponent<MoveToWaypoint>().Building();
            yield return new WaitForSeconds(0.5f);
            if (currentIndex >= objectsToMove.Length)
            {
                currentIndex = 0;      // Reset the index
            }
        }
    }
}
