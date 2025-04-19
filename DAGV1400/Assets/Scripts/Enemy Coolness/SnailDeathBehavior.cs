using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class SnailDeathBehavior : MonoBehaviour
{
    public ShieldBehavior shieldStuff;
    public UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (shieldStuff.isShieldRunning == true && other.CompareTag("Player") == true)
        {
            //Debug.Log("Player with active shield touched " + gameObject.name);
            
            Destroy(gameObject.GetComponent<Collider>());
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            triggerEvent.Invoke();
            
        }

    }
    
}
