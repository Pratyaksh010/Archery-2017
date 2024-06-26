using UnityEngine;
using System.Collections;

public class CURRENTCHALLENGE : MonoBehaviour {

	// Use this for initialization
	
	public int currentchallenge;
	void Start ()
	{
	   currentchallenge=notDestroy.instances.challengeSelect;
		 transform.GetComponent<GUIText>().text=""+"CHALLENGE"+" "+currentchallenge;
	}
	
	// Update is called once per frame
	void Update ()
	{
	  
	}
}
