using UnityEngine;
using System.Collections;

public class PauseScreenGUIItemsManager : GUIItemsManager
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
			Debug.Log("----- In Derived class event handle : " + item.name);
			_screenManager.LoadScreen("GUI_Settings");
		}

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
