using UnityEngine;
using System.Collections;

public class checkPlatform : MonoBehaviour {
	public GUITexture[] text;
	public int size;
	// Use this for initialization
	void Awake ()
	{
	
		if( Application.platform == RuntimePlatform.Android)
		{
			for(int i=0;i<size;i++)
			{
				text[i].color=new Color(text[i].color.r,text[i].color.g,text[i].color.b,1);
			}
		}
		else
		{
		   for(int i=0;i<size;i++)
			{
				text[i].color=new Color(text[i].color.r,text[i].color.g,text[i].color.b,0);
			}	
		}
		
		
	}

	// Update is called once per frame
	void fadeoutjoystick()
		
	{
		
		if( Application.platform == RuntimePlatform.Android && controll.instance.pause==true)
		{
			for(int i=0;i<size;i++)
			{
				text[i].color=new Color(text[i].color.r,text[i].color.g,text[i].color.b,0);
			}
		}
		
		
	}
	
	
	
	
}
