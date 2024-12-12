using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers _instance;

    private static Managers Instance { get { init(); return _instance; } }

    private readonly InputManger _input = new InputManger();
    private readonly ResourceManager _resource = new ResourceManager();
    public static InputManger Input => Instance._input;
    public static ResourceManager Resource => Instance._resource;

    void Start()
    {
        init();
    }

    void Update()
    {
        _input.OnUpdate();
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
