using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * 400);
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision detected with" + other.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
