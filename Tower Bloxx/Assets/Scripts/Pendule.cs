using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendule : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] private Vector3 moveSpeed;
    [SerializeField] private float leftAngle;
    [SerializeField] private float rightAngle;

    bool movingClockWise;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movingClockWise = true; 
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void ChangeMoveDir()
    {
        if (transform.rotation.z > rightAngle)
        {
            movingClockWise = false;
        }

        if (transform.rotation.z < leftAngle)
        {
            movingClockWise = true;
        }
    }

    public void Move()
    {
        ChangeMoveDir();

        if (movingClockWise)
        {
            rb.angularVelocity = moveSpeed;
        }

        if (!movingClockWise)
        {
            rb.angularVelocity = -1 * moveSpeed;
        }
    }
}
