using UnityEngine;
using System.Collections;

public class GUIItemImage : GUIItem 
{
	// Use this for initialization
	void Start() 
	{
		meGUIItemType = eGUI_ITEM_TYPE.Image;
	}
	
	// Update is called once per frame
	void Update () 
	{
		UpdateSizeWithViewPort();
	}
}
