using UnityEngine;
using System.Collections;

public class TutorialScreenGUIManager : GUIItemsManager
{
	public GameObject ToggleButton;
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
			if(item.name == "NextButton" && ToggleButton != null)
			{
				////SetToggle button next
				ToggleButton.GetComponent<GUIToggleButton>().toggleNext();
				
			}
			else if(item.name == "Previous" && ToggleButton != null)
			{
				////SetToggle button next
				ToggleButton.GetComponent<GUIToggleButton>().togglePrevious();
			}
			
		}
	}
}
