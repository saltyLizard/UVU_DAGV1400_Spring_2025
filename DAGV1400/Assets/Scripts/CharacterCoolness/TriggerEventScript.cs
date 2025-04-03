using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventScript : MonoBehaviour
{
   public UnityEvent triggerEvent;

   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.tag == "Player")
      {
         triggerEvent.Invoke();
         Debug.Log("Player interacted with object");
         if (other.gameObject.tag == "Player" && gameObject.tag == "Orange")
         {
            Destroy(gameObject.GetComponent<Collider>());
         }
      }
      

   }
}