using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Threading.Tasks;

[RequireComponent(typeof(SpriteRenderer), typeof(BoxCollider))]
public class ShieldBehavior : MonoBehaviour
{
    public SimpleFloatData dataObj;
    public int waitTime = 3;
    public bool isShieldRunning = false; // to prevent repeated triggers
    public UnityEvent triggerEvent;
    void Update()
    {
        if (dataObj.currentValue == 1 && !isShieldRunning)
        {
            ShieldOnSequence(); // call async method
        }
    }

    async void ShieldOnSequence()
    {
        isShieldRunning = true;

        gameObject.GetComponent<SpriteRenderer>().enabled = true;

        await Task.Delay(waitTime * 1000); // delay for _ seconds

        dataObj.currentValue = dataObj.startValue;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        
        triggerEvent.Invoke();
        isShieldRunning = false;
    }

}
