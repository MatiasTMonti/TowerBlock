using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private MeshRenderer spawn;
    [SerializeField] private GameObject cube;

    private float timeRestart;

    // Start is called before the first frame update
    void Start()
    {
        spawn.GetComponent<MeshRenderer>();
        timeRestart = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spawn.enabled)
            {
                Instantiate(cube, new Vector3(spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z), Quaternion.identity);
            }

            spawn.enabled = false;
        }

        if (!spawn.enabled)
        {
            timeRestart -= Time.deltaTime;

            if (timeRestart <= 0)
            {
                spawn.enabled = true;
                timeRestart = 2;
            }
        }
    }
}
