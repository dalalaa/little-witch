using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//int varbob = 0;

public class ClickToDestroy : MonoBehaviour
{
    //public GameObject _ThingToDestroy;
    public int _ID;
      public GameObject _Button;
    public AudioSource _sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }
public void OnClick()
{
    Debug.Log("click to destroy");
        _sound.Play();
        SceneObjectStore._ActiveSceneStore.DestroyObjectFromIndex(_ID);
        //gameObject.SetActive(false);

        Debug.Log("on click destroy press "+_ID);
                _Button.SetActive(false);
                switch (_ID)
                {
                    case 0:
                    GameManager.Instance.TomatoPressed=true;
                    break;
                    case 1:
                    
                    GameManager.Instance.CabagePressed=true;
                    Debug.Log("cabage sweith " + GameManager.Instance.CabagePressed);
                    break;
                    case 2:
                    GameManager.Instance.CarrotPressed=true;
                    break;

                }


//Destroy(_ThingToDestroy);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
