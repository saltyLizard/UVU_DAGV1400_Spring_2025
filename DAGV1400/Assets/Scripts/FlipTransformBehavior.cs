using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class FlipTransformBehavior : MonoBehaviour
{
    public KeyCode key1 = KeyCode.RightArrow, key2 = KeyCode.LeftArrow, key3 = KeyCode.A, key4 = KeyCode.D;
    public float direction1 = 0, direction2 = 180;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key1) || Input.GetKeyDown(key4))
        {
            transform.rotation = Quaternion.Euler(0, direction1, 0);
            
        }
        
        if (Input.GetKeyDown(key2) || Input.GetKeyDown(key3))
        {
            transform.rotation = Quaternion.Euler(0, direction2, 0);
            
        }
    }
}
