using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Threading.Tasks;

public class ShieldBehavior : MonoBehaviour
{
    public SimpleFloatData dataObj;
    public int waitTime = 3;
    private bool isShieldRunning = false; // to prevent repeated triggers

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
        gameObject.GetComponent<BoxCollider>().enabled = true;

        await Task.Delay(waitTime * 1000); // delay for _ seconds

        dataObj.currentValue = dataObj.startValue;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;

        isShieldRunning = false;
    }
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Threading.Tasks;

public class ShieldBehavior : MonoBehaviour
{
    public SimpleFloatData dataObj;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dataObj.currentValue == 1)
        {
            ShieldOnSequence();
            
        }
    }

    void ShieldOnSequence()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<BoxCollider>().enabled = true;
        //needs to wait or delay or pause here
        dataObj.currentValue = dataObj.startValue;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        
    }
    
}

*/