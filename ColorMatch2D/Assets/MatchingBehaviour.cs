using System;
using UnityEngine;
using UnityEngine.Events;

public class MatchingBehaviour : MonoBehaviour
{
    public JulianID idObj;
    public UnityEvent matchEvent, nomatchEvent;

    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>().idObj;
        if (tempObj == null)
            return;
        
        var otherID = tempObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            nomatchEvent.Invoke();
        }
    }
}
