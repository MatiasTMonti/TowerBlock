using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private Transform pendulum;
    private Camera camera;

    private float up = 1;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MovementCamera()
    {
        //pendulum.position = new Vector3(0, up, 0);
        //camera.transform.position = pendulum.position;
        Debug.Log("Mover");    
    }
}
