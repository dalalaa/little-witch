using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PointAndClickController : MonoBehaviour
{
 public Camera _GameCamera;
 public mycharacter _GameCharacter;
 // Start is called before the first frame update
 void Start()
 {

 }
 // Update is called once per frame
 void Update()
 {
   // Debug.Log("update click cotroller");
 //check if the user is pressing the mouse button
 if (Input.GetButton("Fire1")) //by default, the left mouse is hooked to "Fire1"
 {
    //Debug.Log(" click cotroller pressed");
 //get the position of the mouse pointer (in screen space)
 Vector3 mousePos = Input.mousePosition;
 //calculate the position of the mouse in world space (this is a position just in front of the camera, not the point on the
 //world floor
 Vector3 point = _GameCamera.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, _GameCamera.nearClipPlane));
 //calculate the direction from the camera to the world space mouse position
 Vector3 direction = point - _GameCamera.transform.position;
 //ensure the direction is a unit vector
 direction.Normalize();
 //cast a ray from the camera in the direction of the world space mouse position
 RaycastHit hit;
 if (Physics.Raycast(_GameCamera.transform.position, direction, out hit))
 {
 //the point that the ray hits geometry is the point we are interested in
 _GameCharacter.SetTarget (hit.point);
 }
 }
 }
}
//save and return to unity, set up the variables for this n
