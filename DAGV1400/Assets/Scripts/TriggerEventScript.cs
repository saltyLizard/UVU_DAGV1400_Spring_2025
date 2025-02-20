using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TriggerEventScript : MonoBehaviour
{
   public UnityEvent triggerEvent;

   private void OnTriggerEnter(Collider other)
   {
      // Trigger the event and test with a debug message
      triggerEvent.Invoke();
      Debug.Log("Player interacted with object");

   }
}
