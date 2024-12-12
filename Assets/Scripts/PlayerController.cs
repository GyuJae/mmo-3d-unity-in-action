using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;

    void Start()
    {
        
    }

    // Local -> World
    // TransformDirection
    
    // World -> Local
    // InverseTransformDirection
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
           transform.Translate( Vector3.forward * (Time.deltaTime * speed));
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * (Time.deltaTime * speed));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * (Time.deltaTime * speed));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * (Time.deltaTime * speed));
        }
    }
}
