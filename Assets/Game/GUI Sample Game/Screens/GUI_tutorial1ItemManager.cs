using UnityEngine;
using System.Collections;

public class GUI_tutorial1ItemManager : GUIItemsManager {

	void Start () 
	{
		base.Init();
	}
	
	public override void OnSelectedEvent(GUIItem item)
	{
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			Debug.Log("----- In Derived class event handle : " + item.name);
			if(item.name == "Play")
				_screenManager.closeScreenManager();
		}

	}
}
