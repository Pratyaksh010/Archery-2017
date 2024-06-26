using UnityEngine;
using System.Collections;

public class kinematicTest : MonoBehaviour {
	
	
	public Transform arrowLook;
	
	public Transform foreArm;
	
	public Transform upperArm;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		
		 foreArm.LookAt(arrowLook);
		
		 Vector3 upperArmLookPos=foreArm.position+(-foreArm.forward)*0.1436827f;
		
		//upperArm.LookAt(upperArmLookPos);
	}
}
