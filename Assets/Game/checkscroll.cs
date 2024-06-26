using UnityEngine;
using System.Collections;

public class checkscroll : ScrollAndPaging  {

	// Use this for initialization
	void Start () {
	 base.InitScroll();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public override void OnSelectedEvent(GUIItem item)
	{				
		
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
		}
	}
}
