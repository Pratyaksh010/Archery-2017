using UnityEngine;
using System.Collections;

public class scoreloading : GUIItem {
	
	public static scoreloading instances;
	// Use this for initialization
	void Awake() {
	instances=this;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	public void d()
	{
		if(_guiItemsManager !=null)
		_guiItemsManager.OnSelectedEvent(this);
	}
	
}
