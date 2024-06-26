using UnityEngine;
using System.Collections;

public class showTimeChallenge : MonoBehaviour 
{
	
	public Transform _minute ;
	
	// Use this for initialization
	void Start ()
	{
	   
	}
	
	// Update is called once per frame
	void Update () 
	{
	   _minute.GetComponent<GUIText>().text = ""+Time_Show.instances.displayMinutes ;
	}
}
