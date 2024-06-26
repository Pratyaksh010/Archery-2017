/*
using UnityEngine;
using System.Collections;

public class recreateJoysticks : MonoBehaviour 
{   
	public float joystickslatetime;
	public int joystickssize;
	public float joystickscreationtime;
    public GameObject[] josticks;
	public static recreateJoysticks instance;
	public bool onetimecreate;
	// Use this for initialization
	void Start ()
	{
	    instance=this;
	}
	
	// Update is called once per frame
	void Update () 
	{
	    if(onetimecreate==true)
		{
			
			if(Time.time-joystickslatetime>joystickscreationtime)
			{   
				onetimecreate=false;
				jostickSetactive();
			}
			
		}
	}
	public void jostickSetactive()
	{
		for(int i=0;i<joystickssize;i++)
		{
		   	josticks[i].gameObject.SetActive(true);
		}
	}
	public void joystickDesactive()
	{
		for(int i=0;i<joystickssize;i++)
		{
		   	josticks[i].gameObject.SetActive(false);
		}
	}
}
*/