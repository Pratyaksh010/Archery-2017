using UnityEngine;
using System.Collections;

public class ScrollMenuItemManager : ScrollAndPaging
{
	
	void Start () 
	{
		base.InitScroll();
	}
	
	public override void OnSelectedEvent(GUIItem item)
	{
		//ON CALL BACK FROM THE BUTTONS
		//Debug.Log("------- IN derived Class.. GUI item selected : " + item.name);
		Application.OpenURL("http://www.google.com");
	}
	
}
