using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private Transform pendulum;
    private Camera camera;

    private float up = 1;

    void Start()
    {
        camera = GetComponent<Camera>();
    }

    public void MovementCamera()
    {
        pendulum.position = new Vector3(0, camera.transform.position.y + up, 0);
        camera.transform.position = new Vector3(camera.transform.position.x, pendulum.position.y, camera.transform.position.z);
    }
}
