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

    private float _yAngle = 0.0f;
    void Update()
    {
        // _yAngle += Time.deltaTime * 100.0f;
        // transform.eulerAngles = new Vector3(0.0f, _yAngle, 0.0f);
        
        // transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f); 
            transform.position += Vector3.forward * (speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            transform.position += Vector3.back * (speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            transform.position += Vector3.left * (speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            transform.position += Vector3.right * (speed * Time.deltaTime);
        }
    }
}
