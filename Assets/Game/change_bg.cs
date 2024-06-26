using UnityEngine;
using System.Collections;

public class change_bg : MonoBehaviour {

	// Use this for initialization
	
	public Texture[] te1;
	int i;
	
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		 if (GUI.Button(new Rect(Screen.width-50, Screen.height-50,50,50),"BG"))
		{
			if(i>3)
			{
				i=0;
			}
			transform.GetComponent<Renderer>().material.mainTexture=te1[i];
			i=i+1;
		}
	}
}
