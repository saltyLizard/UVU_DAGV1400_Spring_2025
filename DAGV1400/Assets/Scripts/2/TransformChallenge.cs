using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class TransformChallenge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float pulseSpeed = 0.5f;
    public float maxScale = 1.5f;
    public float minScale = 0.5f;
    

    // Update is called once per frame
    void Update()
    {
        //Move the target GameObject
        var x = Mathf.PingPong(Time.time, 3);
        var y = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(RandomNumberGenerator.GetInt32(-3,3), RandomNumberGenerator.GetInt32(-3,3), 0);
        transform.position = p;
        
        //Rotate the target
        transform.Rotate(new Vector3(RandomNumberGenerator.GetInt32(0, 90), RandomNumberGenerator.GetInt32(0, 90), RandomNumberGenerator.GetInt32(0, 90))* Time.deltaTime);
        
        //Scale the target
        float scale=Mathf.PingPong(Time.time * RandomNumberGenerator.GetInt32(0,2), maxScale-RandomNumberGenerator.GetInt32(0,2))+minScale;
        transform.localScale = new Vector3(scale, scale, scale);
    }
}