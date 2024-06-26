using UnityEngine;
using System.Collections;

public class call_manager : MonoBehaviour {

	// Use this for initialization
	public notDestroy notdesScript1;
	
	public GameObject gamemanager1;
	 
	public GameObject gamemanager2;
	
	void Start () 
	{
	 notdesScript1=GameObject.Find("Nondestroy").GetComponent("notDestroy")as notDestroy;
		
     if(notdesScript1.checkchallengemode==true)
		{
			   //Instantiate (gamemanager1, Vector3.zero, Quaternion.identity);
		}
		 if(notdesScript1.checkchallengemode==false)
		{
			  // Instantiate (gamemanager2, Vector3.zero, Quaternion.identity);
		}
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
