using UnityEngine;
using System.Collections;

public class sky_rotate : MonoBehaviour {
   public Camera a;
	 public  Skybox ti;
	// Use this for initialization
	void Start ()
	{
		
	 // ti=transform.camera.src.GetComponent(typeof(Skybox)) as Skybox
		
	}
	
	// Update is called once per frame
	void Update () {
		 //=CameraClearFlags.Skybox;
	    ti=a.GetComponent(typeof(Skybox))as Skybox;
		print (ti);
		ti.transform.Rotate(Vector3.up*1* Time.deltaTime, Space.World);
		
	
	}
}
