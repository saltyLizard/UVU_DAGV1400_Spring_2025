using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleIdMatchBehavior : MonoBehaviour
{
    public Id id;
    public UnityEvent matchEvent, noMatchEvent;

    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<SimpleIdBehavior>();

        if (otherID == null)
        {
            Debug.Log("Ignored collision with: " + other.name);
            return;
        }

        if (otherID.id == id)
        {
            matchEvent.Invoke();
            Debug.Log("Matched ID: " + id);
        
            // Destroy the key after matching
            Destroy(other.gameObject);
        }
        else
        {
            noMatchEvent.Invoke();
            Debug.Log("No Match: " + id);
        }
    }



}
