using UnityEngine;
using System.Collections;

public class SettingScreenGUIHandler : GUIItemsManager
{

	// Use this for initialization
	public Vector2 scrollPosition;
	public string longString = "This is a long-ish string";
	public Camera mMainCamera = null;
	void Start () 
	{
		base.Init();
	}
	
	public override void OnSelectedEvent(GUIItem item)
	{
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			Debug.Log("----- In Derived class event handle : " + item.name);
			if(item.name == "MenuItem2")
				_screenManager.LoadScreen("GUI_PauseScreen");
			else if(item.name == "MenuItem1")
				_screenManager.LoadScreen("GUI_HomeScreen");
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
//	void OnGUI() 
//	{
//        scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Width( 455), GUILayout.Height(315));
//        if (GUILayout.Button("Clear"))
//            longString = "";
//        GUILayout.Label(longString);
//        GUILayout.EndScrollView();
//        if (GUILayout.Button("Add More Text"))
//            longString += "Here is another line\n";
//	}
}
