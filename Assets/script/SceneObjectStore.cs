using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneObjectStore : MonoBehaviour
{
    static public SceneObjectStore _ActiveSceneStore;
    public GameObject[] AllObjects;
    void OnEnable()
    {
        _ActiveSceneStore = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void DestroyObjectFromIndex(int index)
    {
        Debug.Log("destroy from index");
        Destroy(AllObjects[index]);
        AllObjects[index] = null;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
