using UnityEngine;
using System.Collections;

public class LevelHandler : MonoBehaviour {
	
	
	
	public Rect plusRect;
	
	public float hsliderValue;
	
	///public Transform ragDoll;
	//public Rect minusRect;
	// Use this for initialization
	
	void Start () {
		////ragDoll=(Transform)ragDoll.transform;
	   plusRect=ResolutionHelper(plusRect);
	}
	
	void Update()
	{
	  //// ragDoll.position=new Vector3(ragDoll.position.x,ragDoll.position.y,hsliderValue);	
		
	}
	
	// Update is called once per frame
	void OnGUI() {
	
		//hsliderValue=GUI.HorizontalSlider(plusRect,hsliderValue,-5,7);
		
		
		
	}
	
	
	Rect ResolutionHelper(Rect rect)
	{
		
	   rect.x=rect.x*Screen.width/480.0f;
		
	   rect.y=rect.y*Screen.height/320.0f;
		
	   rect.width=rect.width*Screen.width/480.0f;
		
	   rect.height=rect.height*Screen.height/320.0f;
		
		return rect;
		
	}
	
	
}
