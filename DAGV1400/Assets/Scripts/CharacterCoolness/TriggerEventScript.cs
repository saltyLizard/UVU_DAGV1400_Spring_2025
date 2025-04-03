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
         
         if (other.gameObject.tag == "Player" && gameObject.tag == "Orange")
         {
            Destroy(gameObject.GetComponent<Collider>());
         }
      }
      

   }
}