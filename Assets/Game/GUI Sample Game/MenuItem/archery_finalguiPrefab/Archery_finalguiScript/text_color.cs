using UnityEngine;
using System.Collections;

public class text_color : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	  transform.GetComponent<GUIText>().material.color=Color.black;
	}
	
	
}
