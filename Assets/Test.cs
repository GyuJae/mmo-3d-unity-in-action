using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    { 
        transform.Rotate(new Vector3(1.0f, 1.0f, 1.0f), Time.deltaTime * 10.0f);
    }
}
