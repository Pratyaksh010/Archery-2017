using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	// Use this for initialization
	public Transform cam;
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		
		transform.Translate(Vector3.forward*5*Time.deltaTime);
		 cam.position=new Vector3(cam.position.x,cam.position.y,transform.position.z-5);
		
	}
}
