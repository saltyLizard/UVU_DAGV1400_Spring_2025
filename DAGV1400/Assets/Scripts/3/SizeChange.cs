using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChange : MonoBehaviour
{
    public float shrinkFactor = 0.9f;

    void OnCollisionEnter(Collision collision)
    {
        transform.localScale *= shrinkFactor;
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
