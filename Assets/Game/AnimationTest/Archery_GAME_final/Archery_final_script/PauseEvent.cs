using UnityEngine;
using System.Collections;

public class PauseEvent:GUIItemsManager
{
	
	// Use this for initialization
	public ScreenManager ScreenmanagerScript;
	public Transform ScreenMa;
	
	void Start ()
	{
	  ScreenmanagerScript=GameObject.Find("Game_manager").GetComponent("ScreenManager")as ScreenManager;
	  base.Init();  
	}
	
	// Update is called once per frame
		public override void OnSelectedEvent(GUIItem item)
	{
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			
			if(item.name == "backbutton")
			{
			
				 Debug.Log("----- In Derived class event handle : " + item.name);
				
				/// store_currentStatus.instances.current=store_currentStatus.currentplayarea.Challenges;
			//////	_pauseManager.LoadScreen("Archery_First_guiPage");
			//	 ScreenmanagerScript.closeScreenManager();
			    
				
			}
			
		}
	}
}
