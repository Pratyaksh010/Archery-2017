using UnityEngine;
using System.Collections;

public class AnimateChar : MonoBehaviour {
	
	
	public Transform rightUpperArm;
	
	public Transform rightLowerArm;
	
	public Transform spine;
	
	public Transform lookObject;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//if(InputHandler.instance.isTouchStationary())
		//rightUpperArm.Rotate(0,-Input.GetAxis("Mouse X")*50*Time.deltaTime,0);
		
		spine.forward=(lookObject.position-spine.position).normalized;
		
		
		//if(rightUpperArm.transform.localEulerAngles.x<351)// && rightUpperArm.transform.localEulerAngles.x>180)
			//rightUpperArm.transform.localEulerAngles=new Vector3(rightUpperArm.localEulerAngles.x,351,rightUpperArm.localEulerAngles.z);
	}
}
