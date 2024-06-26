using UnityEngine;
using System.Collections;

public class EventControll :GUIItemsManager
{
	


	// Use this for initialization
	void Start () 
	{
	   base.Init();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	public override void OnSelectedEvent(GUIItem item)
	{
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			
		}
		
	
	}
	

}