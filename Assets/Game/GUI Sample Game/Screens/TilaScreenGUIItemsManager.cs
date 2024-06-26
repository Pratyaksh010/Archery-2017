using UnityEngine;
using System.Collections;

public class TilaScreenGUIItemsManager : GUIItemsManager
{

	// Use this for initialization
	void Start () 
	{
		base.Init();
	}
	
	public override void OnSelectedEvent(GUIItem item)
	{
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			//Debug.Log("----- In Derived class event handle : " + item.name);
			if(item.name == "PauseButton")
				_screenManager.LoadScreen("GUI_HomeScreen");
			
		}
	}
}
