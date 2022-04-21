using UnityEngine;

public class Collisions : MonoBehaviour
{
    private Rigidbody rb;
    private Camera camera;
    private Pendulum pd;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        camera = Camera.main;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("Cube"))
        {
            rb.isKinematic = true;
            camera.GetComponent<MoveCamera>().MovementCamera();
            pd.GetComponent<Pendulum>().MovePendulum();
        }
        else
        {
            rb.isKinematic = false;
        }
    }
}
