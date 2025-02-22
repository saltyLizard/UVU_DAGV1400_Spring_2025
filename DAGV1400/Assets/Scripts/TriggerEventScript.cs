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

/*
public class TriggerEventScript : MonoBehaviour
{
   public UnityEvent triggerEvent;
   public Animator animator;
   public string triggerName;

   private void OnTriggerEnter(Collider other)
   {
      // Trigger the event and test with a debug message
      
      if (other.CompareTag("Player"))
      {
         triggerEvent.Invoke();
         Debug.Log("Player interacted with object");
      }

   }

   public void SetAnimatorTrigger()
   {
      if (animator != null)
      {
         animator.SetTrigger(triggerName);
      }
      else
      {
         Debug.LogWarning("Animator not assigned");
      }
   }
   
   
   
}

*/