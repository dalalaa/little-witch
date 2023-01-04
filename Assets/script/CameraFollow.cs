using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;//绑定人物的Transform
    public float Up = 25f;//相机与目标的竖直高度参数
    public float Away = 35f;//相机与目标的水平距离参数
    public float smooth = 2f;//位置平滑移动插值参数值
    public float camDepthSmooth = 20f;

    void Update()
    {
        // Mouse control diatance of the camera
        if ((Input.mouseScrollDelta.y < 0 && Camera.main.fieldOfView >= 3) || Input.mouseScrollDelta.y > 0 && Camera.main.fieldOfView <= 80)
        {
            Camera.main.fieldOfView += Input.mouseScrollDelta.y * camDepthSmooth * Time.deltaTime;
        }
    }

    void LateUpdate()
    {
        //Calculate camera position
        Vector3 disPos = target.position + Vector3.up * Up - target.forward * Away;
        transform.position = Vector3.Lerp(transform.position, disPos, Time.deltaTime * smooth);
        //Camera angle
        transform.LookAt(target.position);
    }
}
