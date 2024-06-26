using UnityEngine;
using System.Collections;

public class leftcammoving : MonoBehaviour {
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
	   
		if(transform.eulerAngles.y<minrotlimit)
		{
			rotateaxis=x1;
		}
		if(transform.eulerAngles.y>maxrotlimit)
		{
			rotateaxis=x2;
		}
		 
		 transform.RotateAround (transform.position, Vector3.up*rotateaxis, speed * Time.deltaTime);
		
	
	
	


}
}
