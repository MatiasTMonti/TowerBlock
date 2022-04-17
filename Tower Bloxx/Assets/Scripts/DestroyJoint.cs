using UnityEngine;

public class DestroyJoint : MonoBehaviour
{
    [SerializeField] private FixedJoint joint;

    void Start()
    {
        joint = gameObject.GetComponent<FixedJoint>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Destroy(joint);
        }
    }
}
