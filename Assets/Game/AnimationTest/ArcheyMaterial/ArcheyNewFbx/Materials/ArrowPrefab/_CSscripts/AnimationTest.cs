using UnityEngine;
using System.Collections;

public class AnimationTest : MonoBehaviour {
	
	
	public AnimationClip fullAnim;
	public Animation myAnimation;
	// Use this for initialization
	
	int k;
	void Start () {
	
		
	 for(int i=0;i<30;i++)
		{
		 myAnimation.AddClip(fullAnim,"a"+i.ToString(),i,i+1,true);
			
		}

        
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
	
		
		 if(k<30 && Input.GetMouseButtonDown(0))// && Input.GetAxis("Mouse X")>0)
		{
		     myAnimation.Play("a"+k.ToString());
			
			 k++;
			
		}
	}
	
	void OnGUI()
	{
		
	    if(GUI.Button(new Rect(Screen.width-100,0,100,100),"Restart"))
		{
		   Application.LoadLevel(Application.loadedLevel);
				
			
		}
	}
}
