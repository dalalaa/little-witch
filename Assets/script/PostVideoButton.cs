using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PostVideoButton : MonoBehaviour
{
    // Start is called before the first frame update
    public VideoPlayer _video;
    public GameObject _ThingToHide;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _ThingToHide.SetActive(!_video.isPlaying);
       
    }
}
