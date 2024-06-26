using UnityEngine;
using System.Collections;

public class camswi : MonoBehaviour {
	public Transform target;
	public Transform cam;
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	    if(FPSControls.instance.camsw==true)
		{   
			
		    //transform.position=new Vector3(-1.86f,0.07951601f,17f);
			//transform.eulerAngles=new Vector3(0,26.75726f,0f);
             //transform.position=Vector3.MoveTowards(transform.position,new Vector3(target.position.x,target.position.y,target.position.z-3),8*Time.deltaTime);
			// transform.LookAt(target);
			 //if(Vector3.Distance(transform.position,target.position)<=3.1f)
			 //FPSControls.instance.camsw=false;
		}
	}
	
}
