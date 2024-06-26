using UnityEngine;
using System.Collections;

public class HomeScrenGUIItemsManager : GUIItemsManager 
{
	
	void Start()
	{
		base.Init();
	}
	
	public override void OnSelectedEvent(GUIItem item)
	{
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			//Debug.Log("----- In Derived class event handle : " + item.name);
			if(item.name == "MenuItem2")
				_screenManager.LoadScreen("GUI_Settings");
			else if(item.name == "MenuItem1")
				_screenManager.LoadScreen("GUI_Settings");
			else if(item.name == "MenuItem3")
				_screenManager.closeScreenManager();
		}
	}
}
