using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    private Rigidbody rb;
    private MoveCamera camera;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("Cube"))
        {
            rb.isKinematic = true;
            camera.MovementCamera();
        }
        else
        {
            rb.isKinematic = false;
        }
    }
}
