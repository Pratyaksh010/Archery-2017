using UnityEngine;
using System.Collections;

public class movecam : MonoBehaviour {

	// Use this for initialization
	
	
	public float _intialpos;
	
	public float _finalpos;
	
	
	public Vector3 _leftpoint;
	
	public Vector3 _rightpoint;
	
	private bool moveleft;
	
	private bool moveright;
	//public Transform
	void Start ()
	{
	 moveleft=true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if( moveleft)
		{
			transform.position= Vector3.MoveTowards(transform.position,_leftpoint,1.5f*Time.deltaTime);
			
			if(Vector3.Distance(transform.position,_leftpoint)<.2f)
			{
				moveleft=false;
				moveright=true;
			}
		}
		if( moveright)
		{
			transform.position= Vector3.MoveTowards(transform.position,_rightpoint,1.5f*Time.deltaTime);
			
			if(Vector3.Distance(transform.position,_rightpoint)<.2f)
			{
				moveleft=true;
				moveright=false;
			}
		}
		
	}
}
