using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour {

	// Use this for initialization
	public static InputHandler instance;
	private bool isMobile;
	
	void Start () {
	
		if(Application.platform==RuntimePlatform.Android)
		    isMobile=true;
		
	}
	
	
	
	void Awake()
	{
	   instance=this;	
		
	}
	public bool isTouchBegan() 
	{
		
		    if(isMobile)
		    {
		        if(Input.touchCount==1 && Input.GetTouch(0).phase==TouchPhase.Began)
		         return true;
		         else
		         return false;
		        
		    }
		    
		    else
		      return Input.GetMouseButtonDown(0);
		    
	}
	
	
	public bool isTouchEnded() 
	{
		    if(isMobile)
		    {
		        if(Input.touchCount==1 && Input.GetTouch(0).phase==TouchPhase.Ended)
		         	return true;
		    	else
		         	return false;
		    }
		    
		    else
		      	return Input.GetMouseButtonUp(0);
	}
	
	public bool isTouchMoving() 
	{
		    if(isMobile)
		    {
		        if(Input.touchCount==1 && Input.GetTouch(0).phase==TouchPhase.Moved)
		         	return true;
		        else
		         	return false;    
		    }
		    
		    else if(Input.GetAxis("Mouse X")!=0 || Input.GetAxis("Mouse Y")!=0)
		      	return true;
   
		    else
		      	return false;
	}
	
	public bool isTouchStationary() 
	{
		
		   if(isMobile)
		   {
	       		if(Input.touchCount>=1)
		   			return true;
		       	else
		        	return false;
		   }
		   
		   else
		     return Input.GetMouseButton(0);
		
	}
	
	public Vector2 deltaXAndDeltaY() 
	{
		   Vector2 deltaPositions;

		    if(isMobile)
		       	deltaPositions=new Vector2(Input.GetTouch(0).deltaPosition.x,Input.GetTouch(0).deltaPosition.y);

		    else
		       	deltaPositions=new Vector2(Input.GetAxis("Mouse X"),Input.GetAxis("Mouse Y"));
    
		    return  deltaPositions;
	}
	
	
	public Vector3 touchPositions() 
	{
		    Vector3 touchPos;
		    
		    if(isMobile)
		     	touchPos=Input.GetTouch(0).position;
		    else 
		     	touchPos=Input.mousePosition;
		     
		    return touchPos;
	}
	
}
