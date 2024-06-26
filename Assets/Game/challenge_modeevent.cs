using UnityEngine;
using System.Collections;

public class challenge_modeevent :GUIItemsManager  {

	// Use this for initialization
	
	public notDestroy notdesScript1;
	
	void Start ()
	{
	
			base.Init();
		   
		    notdesScript1=GameObject.Find("Nondestroy").GetComponent("notDestroy")as notDestroy;
		   
		    notdesScript1.checkchallengemode=true;
	}
	
	// Update is called once per frame
		public override void OnSelectedEvent(GUIItem item)
	{
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			if(item.name == "backbutton")
			{
			  Debug.Log("----- In Derived class event handle : " + item.name);
				 
			  notdesScript1.checkchallengemode=false;
		      
			  _screenManager.LoadScreen("Archery_First_guiPage");//back_button menu page open
				
			}
			
			if(item.name=="challeng1")
			{
			   notdesScript1.challengeSelect=1;
				
			   store_currentStatus.instances.currentscene=3;
				
				_screenManager.LoadScreen("loading_bagground");
			}
			
			if(item.name=="challeng2")
			{
				notdesScript1.challengeSelect=2;
				
				notdesScript1.targetdistance=1;
				
				 store_currentStatus.instances.currentscene=2;
				
				_screenManager.LoadScreen("loading_bagground");
			}
			if(item.name=="challeng3")
			{
				  notdesScript1.challengeSelect=3;
				
			      notdesScript1.targetdistance=2;
				
				  store_currentStatus.instances.currentscene=2;
				
				_screenManager.LoadScreen("loading_bagground");
			}
			if(item.name=="challeng4")
			{
				 notdesScript1.challengeSelect=4;
				
				 notdesScript1.targetdistance=2;
				
				  store_currentStatus.instances.currentscene=2;
				
				_screenManager.LoadScreen("loading_bagground");
			}
			if(item.name=="challeng5")
			{
				notdesScript1.challengeSelect=5;
				
				notdesScript1.targetdistance=1;
				
				 store_currentStatus.instances.currentscene=2;
				
				_screenManager.LoadScreen("loading_bagground");
			}
			if(item.name=="challeng6")
			{
				notdesScript1.challengeSelect=6;
				
				 store_currentStatus.instances.currentscene=3;
				
				_screenManager.LoadScreen("loading_bagground");
			}
			if(item.name=="challeng7")
			{
				
			}
			if(item.name=="challeng8")
			{
				  notdesScript1.challengeSelect=8;
			 
				  store_currentStatus.instances.currentscene=3;
				
				_screenManager.LoadScreen("loading_bagground");
			}
			if(item.name=="challeng9")
			{
				 notdesScript1.challengeSelect=9;
				
				 notdesScript1.targetdistance=2;
				
				 store_currentStatus.instances.currentscene=2;
				
				_screenManager.LoadScreen("loading_bagground");
			}
			
			
		}
		
	}
}
