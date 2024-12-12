using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers _instance;
    public static Managers GetInstance()
    {
        init();
        return _instance;
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private static void init()
    {
        if (_instance != null) return;
        
        var go = GameObject.Find("@Managers");
        if (go == null)
        {
            go = new GameObject("@Managers");
            go.AddComponent<Managers>();
        }
        
        DontDestroyOnLoad(go);
        _instance = go.GetComponent<Managers>();
    }
}
