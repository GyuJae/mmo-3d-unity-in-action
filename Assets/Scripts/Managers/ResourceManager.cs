using UnityEngine;

public class ResourceManager
{
    private T Load<T>(string path) where T : Object
    {
        return Resources.Load<T>(path);
    }

    public GameObject Instantiate(string path, Transform parent = null)
    {
        var prefab = Load<GameObject>($"Prefabs/{path}");

        if (prefab ==null)
        {
            Debug.LogError($"Can't find Prefab: {path}");
            return null;
        }
        
        return Object.Instantiate(prefab, parent);
    }

    public void Destroy(GameObject go, float time = 0.0f)
    {
        if (go == null) return;
        Object.Destroy(go, time);
    }
}
