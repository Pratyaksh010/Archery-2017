using UnityEngine;
using System.Collections;

public class change_texture : MonoBehaviour {
	public Texture t1;
	// Use this for initialization
	void Start ()
	{
		if(PlayerPrefs.GetInt("bowselected")!=0)
		transform.GetComponent<Renderer>().material.mainTexture=store_currentStatus.instances.currentbowtexture;
	   if(PlayerPrefs.GetInt("bowselected")==0)
		transform.GetComponent<Renderer>().material.mainTexture=t1;
	}
	
		
	
}
