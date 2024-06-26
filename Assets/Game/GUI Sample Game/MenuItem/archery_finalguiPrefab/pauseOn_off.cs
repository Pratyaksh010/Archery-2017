using UnityEngine;
using System.Collections;

public class pauseOn_off : MonoBehaviour 
{

	// Use this for initialization
	
	void Start () 
	{
	   controll.instance.pause=false;
	   challenge_Controll.instances.time_showScript.timestop=false;
	   challenge_Controll.instances.time_showScript._currenttime=Time.time;
	   challenge_Controll.instances.time_showScript.startTime=Time.time- challenge_Controll.instances.time_showScript.guiTime;
	   challenge_Controll.instances.pausebutton=transform;
	   controll.instance.pausedis=transform;
		if(controll.instance.secondpowerup!=null)
		{
	   controll.instance.secondpowerup.gameObject.SetActive(true);
		}
		if(challenge_Controll.instances.secondpowerup!=null)
		{
	   challenge_Controll.instances.secondpowerup.gameObject.SetActive(true);
		}
		if(challenge_Controll.instances.powerup!=null)
		{
	   challenge_Controll.instances.powerup.gameObject.SetActive(true);
		}
		if(controll.instance.powerup!=null)
		{
			controll.instance.powerup.gameObject.SetActive(true);
		}
	   
	}
	void Update()
	{

	}
}
