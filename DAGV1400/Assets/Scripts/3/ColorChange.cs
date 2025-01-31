using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
