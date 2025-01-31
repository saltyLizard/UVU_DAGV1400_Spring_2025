using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force2 : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.left * 200);
        }
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
