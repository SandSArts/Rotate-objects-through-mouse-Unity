//Coded	by Shashank.S - creator of SandS Arts ,Mail me at - sandsarts.developer@gmail.com

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectsThroughMouse : MonoBehaviour {
public float speed;                                                                            //speed of rotation
bool mouseover=false;                                                                          //just to know whether we have moved the mouse over the object
	
	void Update () {
		//Rotating object without checking whether mouse was over this object

		float mouseX=Input.GetAxis("Mouse X");                                             //input from the mouse from x axis
		transform.RotateAround(transform.position,Vector3.down*mouseX,speed*Time.deltaTime);   //rotating the object around


		//Rotating object through mouse
		
		//checking whether we have pressed the left mouse button and have we moved the mouse over the object
		if(Input.GetMouseButton(0)&&mouseover)
		{
			float mouseX2=Input.GetAxis("Mouse X");                                             //input from the mouse from x axis
		transform.RotateAround(transform.position,Vector3.down*mouseX2,speed*Time.deltaTime);   //rotating the object around
		}
		//setting mouseover to false whenever we have released the left mouse button
		if(Input.GetMouseButtonUp(0)&&mouseover)
		mouseover=false;
	}
	
    //thing inside this function are executed only if you move the mouse cursor over the object , make sure you have added a collider to the object
	void OnMouseOver()
	{ 
		mouseover=true;                                                                        //setting mouseover to true when we have moved the mouse over the object
	}



}
