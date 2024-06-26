using UnityEngine;
using System.Collections;

public class ShowSecondTime : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		transform.GetComponent<GUIText>().text = ""+Time_Show.instances.displaySeconds ;
	
	}
}
