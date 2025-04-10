using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class SnailDeathBehavior : MonoBehaviour
{
    
    public UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Shield")
        {
            //triggerEvent.Invoke();
            Destroy(gameObject);
        }
      

    }
    
}
