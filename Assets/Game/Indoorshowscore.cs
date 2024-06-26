using UnityEngine;
using System.Collections;

public class Indoorshowscore : MonoBehaviour {

	// Use this for initialization
	public GUIText[] text;
	
	
	void Start () 
	{
	   controll.instance.pause=true;
	
	
	if(controll.instance.showend1)
		{
			text[0].text=""+controll.instance.firstendsum;
			
		
		}
		if(controll.instance.showend2)
		{
			text[1].text=""+controll.instance.secondendsum;
			
		}
		
		if(controll.instance.showend3)
		{
			text[2].text=""+controll.instance.thirdendsum;
			
		}
		
		if(controll.instance.showend4)
		{
			text[3].text=""+controll.instance.fourendsum;
			
		}
		  
		  text[4].text=""+controll.instance.totalsum;
		  
		  
			
	
}
}