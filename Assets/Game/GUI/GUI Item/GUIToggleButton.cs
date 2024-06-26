using UnityEngine;
using System.Collections;

public class GUIToggleButton : GUIItem 
{
	public Texture[] _TextureForState;
	public string[] _StateNames;
	string mstrDefaultName;
	public int miCurrentSelectionIndex;
	bool miTouchActive = false;

	// Use this for initialization
	void Start () 
	{
		mstrDefaultName = gameObject.name;
		GUITexture tGUITexture = GetComponent<GUITexture>();
		if(_TextureForState == null && tGUITexture != null)
		{
			_TextureForState = new Texture2D[1];
			_TextureForState[0] = tGUITexture.texture;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		UpdateSizeWithViewPort();
        // how many fingers
        var touchCount = Input.touchCount;

//        if(touchCount > 0)
//		{
//		// update finger count
//	        for (int i = 0; i < touchCount; i++)
//	        {
//	            Touch touch = Input.GetTouch(i);
//	
//	            // check if the button is pressed
//	            if (touch.phase == TouchPhase.Began)
//	            {
//	                if (guiTexture.HitTest(touch.position, Camera.main))
//	                {
//	                    // change the texture and check that it is being pressed
//	                    guiTexture.texture = _texSelectedState;
//	                }
//	            }
//	
//	            // stop updating the button 
//	            else if (touch.phase == TouchPhase.Ended)
//	            {
//	                if (guiTexture.HitTest(touch.position, Camera.main))
//	                {
//	                    // switch the texture back to normal
//	                    guiTexture.texture = _texNormalState;
//	                }
//	            }
//	        }
//		}
//		else
		{
			if (Input.GetMouseButtonDown(0))
	            {
	                if (GetComponent<GUITexture>().HitTest(Input.mousePosition, Camera.main) && miTouchActive == false)
	                {
						miTouchActive = true;
						showNextToggleIndex();
	                }
	            }
	
	            // stop updating the button 
	            else if (Input.GetMouseButtonUp(0))
	            {
					if(miTouchActive == true)
					{
						miTouchActive = false;
		                if (GetComponent<GUITexture>().HitTest(Input.mousePosition, Camera.main))
						{
							miTouchActive = false;
							toggleButtonAction();
						}
						else
							toggleBackToNormalAction();
					}
				
	            }
	   	}
	}
	
	public void toggleNext()
	{
		int nextSelectionIndex = miCurrentSelectionIndex+1;
		nextSelectionIndex %= _TextureForState.Length;
		
		if(miCurrentSelectionIndex != nextSelectionIndex)
		{
			miCurrentSelectionIndex = nextSelectionIndex;
			if(miCurrentSelectionIndex >= _StateNames.Length)
				gameObject.name = mstrDefaultName;
			else
				gameObject.name = _StateNames[miCurrentSelectionIndex];
		
			GetComponent<GUITexture>().texture = _TextureForState[miCurrentSelectionIndex];
		}
		_guiItemsManager.OnSelectedEvent(this);
	}
	
	public void togglePrevious()
	{
		int nextSelectionIndex = miCurrentSelectionIndex-1;
		nextSelectionIndex %= _TextureForState.Length;
		
		if(miCurrentSelectionIndex != nextSelectionIndex)
		{
			miCurrentSelectionIndex = nextSelectionIndex;
			if(miCurrentSelectionIndex >= _StateNames.Length)
				gameObject.name = mstrDefaultName;
			else
				gameObject.name = _StateNames[miCurrentSelectionIndex];
		
			GetComponent<GUITexture>().texture = _TextureForState[miCurrentSelectionIndex];
		}
		_guiItemsManager.OnSelectedEvent(this);
	}
	
	public void toggleBackToNormalAction()
	{
		if(miCurrentSelectionIndex >= _StateNames.Length)
			gameObject.name = mstrDefaultName;
		else
			gameObject.name = _StateNames[miCurrentSelectionIndex];
		
		GetComponent<GUITexture>().texture = _TextureForState[miCurrentSelectionIndex];
	}
	
	public void toggleButtonAction()
	{
		int nextSelectionIndex = miCurrentSelectionIndex+1;
		nextSelectionIndex %= _TextureForState.Length;
		
		if(miCurrentSelectionIndex != nextSelectionIndex)
		{
			miCurrentSelectionIndex = nextSelectionIndex;
			if(miCurrentSelectionIndex >= _StateNames.Length)
				gameObject.name = mstrDefaultName;
			else
				gameObject.name = _StateNames[miCurrentSelectionIndex];
		
			GetComponent<GUITexture>().texture = _TextureForState[miCurrentSelectionIndex];
		}
		_guiItemsManager.OnSelectedEvent(this);
	}
	
	public void showNextToggleIndex()
	{
		int nextSelectionIndex = miCurrentSelectionIndex+1;
		nextSelectionIndex %= _TextureForState.Length;
		
		if(miCurrentSelectionIndex != nextSelectionIndex)
		{
			GetComponent<GUITexture>().texture = _TextureForState[nextSelectionIndex];
		}
	}
}