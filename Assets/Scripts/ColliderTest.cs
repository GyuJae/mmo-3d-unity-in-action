using System;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
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
        
    }

    void Update()
    {
        var look = transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(transform.position + Vector3.up, look * 10f, Color.red);

        if (Physics.Raycast(transform.position + Vector3.up, look, out RaycastHit hit, 10))
        {
            Debug.DrawRay(transform.position + Vector3.up, hit.point, Color.green);
            Debug.Log($"Hit Raycast: {hit.collider.gameObject.name}");
        }
        
        var hits = Physics.RaycastAll(transform.position + Vector3.up, look);
        foreach (var raycastHit in hits)
        {
            Debug.Log($"Hit RaycastAll: {raycastHit.collider.gameObject.name}");
        }
    }
}
