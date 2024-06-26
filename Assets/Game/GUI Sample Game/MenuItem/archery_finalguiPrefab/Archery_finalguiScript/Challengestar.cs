using UnityEngine;
using System.Collections;

public class Challengestar : MonoBehaviour {

	// Use this for initialization
	public ScreenManager screenmanagerscript;
	public Transform ScreenObject;
	public string lodingprefab;
	public bool onetimecall;
	void Start () 
	{
	   
		/////screenmanagerscript=ScreenObject.GetComponent("ScreenManager")as ScreenManager;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	   //   screenmanagerscript=ScreenObject.GetComponent("ScreenManager")as ScreenManager;
		//if(Input.GetMouseButtonDown(0)&& onetimecall==false)
			
		//{
			
		//	screenmanagerscript.LoadScreen(lodingprefab);
		//	challenge_mode_gui.instances.gameplaystart=true;
		//	challenge_mode_gui.instances.showstringTimelimit=Time.time;
		//	audioManager.instances._currentaudio.audio.clip=audioManager.instances._audioclip[19];
		//	audioManager.instances.playcurrentaudio();
			// onetimecall=true;
		//}
		
	}
}
