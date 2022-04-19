using System.Collections.Generic;
using UnityEngine;

public class PrefabsCreate : MonoBehaviour
{
    [SerializeField] private GameObject cubes;
    [SerializeField] private List<GameObject> cubos;
    [SerializeField] private GameObject claw;
    [SerializeField] private GameObject crane;

    private int spawnPosY = 1;
    private bool firstTime = true;

    // Start is called before the first frame update
    void Start()
    {
        cubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        //Condicion para generar solo el cubo
        if (firstTime || cubos[cubos.Count - 1].GetComponent<Rigidbody>().isKinematic)
        {
            cubos.Add(Instantiate(cubes, new Vector3(0, claw.transform.position.y - spawnPosY, 0), Quaternion.identity));
            firstTime = false;

            //Mover crane cada vez que se tira el cubo
        }

        //Mover crane para los costados
        MoveCubeWithPendule();
        
    }

    public void MoveCubeWithPendule()
    {
        cubes.transform.position = new Vector3(0, 0, claw.transform.position.z);
    }
}
