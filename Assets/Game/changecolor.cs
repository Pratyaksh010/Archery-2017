using UnityEngine;
using System.Collections;

public class changecolor : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
		//transform.renderer.material.color = new Color (.9361702f,1f,.5106382f,1f);
		transform.GetComponent<Renderer>().sharedMaterial.color = new Color (.9361702f,1f,.5106382f,1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
