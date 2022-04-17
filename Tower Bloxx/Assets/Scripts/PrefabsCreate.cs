using System.Collections.Generic;
using UnityEngine;

public class PrefabsCreate : MonoBehaviour
{
    [SerializeField] private GameObject cubes;
    [SerializeField] private List<GameObject> cubos;
    [SerializeField] private GameObject crane;

    private int spawnPosY = 1;

    // Start is called before the first frame update
    void Start()
    {
        cubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cubos.Add(Instantiate(cubes, new Vector3(0, crane.transform.position.y - spawnPosY, 0), Quaternion.identity));
        }
    }
}
