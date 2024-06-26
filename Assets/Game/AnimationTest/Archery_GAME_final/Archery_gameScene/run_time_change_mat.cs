using UnityEngine;
using System.Collections;

public class run_time_change_mat : MonoBehaviour {

	// Use this for initialization
	public Texture[] runtime;
	public Transform Obj;
	public Transform Obj1;
	int i=0;
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnGUI()
	{
		
		if(GUI.Button(new Rect(0,200,100,100),"+"))
		{
			
			if(i>8)
			{
				i=8;
				
			}
			Obj.GetComponent<Renderer>().material.mainTexture=runtime[i];
			Obj1.GetComponent<Renderer>().material.mainTexture=runtime[i];
			i=i+1;
		}
		
		if(GUI.Button(new Rect(0,300,100,100),"-"))
		{
			i=i-1;
			if(i<1)
			{
				i=0;
				
			}
			Obj.GetComponent<Renderer>().material.mainTexture=runtime[i];
			Obj1.GetComponent<Renderer>().material.mainTexture=runtime[i];
		}
	}
}
