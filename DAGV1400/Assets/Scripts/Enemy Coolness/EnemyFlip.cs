using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFlip : MonoBehaviour
{
    public float direction1 = 0, direction2 = 180;
    private Vector3 lastPosition;
    private NavMeshAgent agent;

    void Start()
    {
        lastPosition = transform.position;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        Vector3 movement = transform.position - lastPosition;

        // Only flip if there's some noticeable movement
        if (movement.x > 0.00f)
        {
            // Moving right
            transform.rotation = Quaternion.Euler(0, direction1, 0);
        }
        else if (movement.x < -0.00f)
        {
            // Moving left
            transform.rotation = Quaternion.Euler(0, direction2, 0);
        }

        lastPosition = transform.position;
    }
}