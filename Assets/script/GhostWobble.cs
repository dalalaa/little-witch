using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostWobble : MonoBehaviour
{
    public float wobbleSpeed = 10.0f;
    float origHeight=0;
    float delta=0;
    // Start is called before the first frame update
    void Start()
    {
        origHeight= transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        delta+=0.1f*wobbleSpeed;
        newPosition.y=origHeight+Mathf.Sin(delta);
     transform.position = newPosition;
    }
}
