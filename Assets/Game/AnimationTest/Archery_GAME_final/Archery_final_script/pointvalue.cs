using UnityEngine;
using System.Collections;

public class pointvalue : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
		transform.localScale=new Vector3(transform.localScale.x-PlayerPrefs.GetFloat("acc_value"),transform.localScale.y-PlayerPrefs.GetFloat("acc_value"),transform.localScale.z-PlayerPrefs.GetFloat("acc_value"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
