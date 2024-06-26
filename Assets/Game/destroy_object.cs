using UnityEngine;
using System.Collections;

public class destroy_object : MonoBehaviour {

	// Use this for initialization
	
	float T;
	public Transform renderobject;
	public static destroy_object instances;
	public bool _enableclone;
	//public Transform arrowparrent;
//	public Transfor
	void Start () 
	{
	   // renderobject.renderer.enabled=false;
		instances=this;
		//T=Time.time;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//if(Time.time-T>=1.0f)
		//{
			// renderobject.renderer.enabled=true;
		//}
		if(_enableclone==true)
		{
			renderobject.GetComponent<Renderer>().enabled=true;
			_enableclone=false;
		}
	
	  Destroy (gameObject,6);
	}
}
