using UnityEngine;
using System.Collections;

public class textureAlpha : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	 
	transform.GetComponent<GUITexture>().color=new Color(1f,1f,1f,0f);
	}
}
