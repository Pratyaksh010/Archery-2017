using UnityEngine;
using System.Collections;

public class ResulutionHelper : MonoBehaviour {
	
	
	
	private float widthFactor;
	private float heightFactor;
	
	public static ResulutionHelper instance;
	// Use this for initialization
	void Start () {
	
		
		//Debug.Log((float)Screen.width/Screen.height);
		if((float)Screen.width/Screen.height>1.0f)
		{
			
		  widthFactor=Screen.width/480.0f;
			
		  heightFactor=Screen.height/320.0f;
		}
		
		else
		{
		  widthFactor=Screen.width/320.0f;
		
		  heightFactor=Screen.height/480.0f;
			
		}
	}
	
	void Awake()
	{
	   instance=this;	
	}
	
	// Update is called once per frame
	public Rect SetResulution(Rect rect) {
	
		
		rect=new Rect(rect.x*widthFactor,rect.y*heightFactor,rect.width*widthFactor,rect.height*heightFactor);
		
		return rect;
	}
}
