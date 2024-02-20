using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehaviour : MonoBehaviour
{
    public JulianID idObj;
    public UnityEvent startEvent;

    public void Start()
    {
        startEvent.Invoke();
    }
}
