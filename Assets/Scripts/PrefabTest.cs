using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    private GameObject _prefab;
    
    void Start()
    {
        _prefab = Managers.Resource.Instantiate("Tank");
        Managers.Resource.Destroy(_prefab, 3.0f);
    }

}
