using UnityEngine;
using System.Collections;

public class rightcammoving : MonoBehaviour {
	private int rotateaxis;
	public int speed;
	public float minrotlimit;
	public float maxrotlimit;
	public int x1;
	public int x2;
	// Use this for initialization
	void Start () 
	{
	   rotateaxis=1;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	
	// Use this for initialization
	
	// Update is called once per frame
	   
		if(transform.localEulerAngles.y<minrotlimit)
		{
			rotateaxis=x1;
		}
		if(transform.localEulerAngles.y>maxrotlimit)
		{
			rotateaxis=x2;
		}
		 
		 transform.RotateAround (transform.position, Vector3.up*rotateaxis, speed * Time.deltaTime);
		
	}
}
