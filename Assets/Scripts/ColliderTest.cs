using System;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    private Camera _camera;

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log($"Collider: {other.gameObject.name}");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Collider: {other.gameObject.name}");
    }

    void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);
            
            Debug.DrawRay(_camera.transform.position, ray.direction * 100.0f, Color.red, 1.0f);

            if (Physics.Raycast(ray, out RaycastHit hit, 100.0f))
            {
                Debug.Log($"Hit: {hit.collider.gameObject.name}");
            }
        }
        
    }
}
