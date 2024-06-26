// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class SpeedThumb : MonoBehaviour {
	
	public GUITexture guione;
	public float difference;
	public float ypos; 
	public float defaultY;
	public float minY;
	public GUITexture rightpad;
	//Texture crossHair;
	//Rect crossHairRect;
	public static SpeedThumb instance;
	public Transform Secondarycam;
	public Transform point;
	public Transform secondaryboard;
	public float limitalpha;
	public float ypos1;
	public float minlengthCrosshear;
	public float maxlengthCrosshear;
	public float renderpoint;
	public Transform cam;
	public float camFieldView;
	public float Cammaxfieldofview;
	public float camminfieldofview;
	
	public bool timestop;
	
	public Transform playerScoreObject;
	
	public Transform AiscoreObject;
	
	public float playerpos;
	
	public float Aiscorepos;
	
	public bool outdoorchek;
	
	public bool challengemode;
	
	public Transform challengescorObject;
	
	public Transform challengeArrowObject;
	
	public float challengescorObjectX;
	
	public float challengeArrowObjectX;
	
	public float minsrosshearsize;
	
	public int checkdifference;
	
	public float _joystickForceValue ;
	
	
	void  Start ()
	{
		
		instance=this;
		_joystickForceValue = 0f ;
		//if(Application.platform==RuntimePlatform.IPhonePlayer&&(iPhone.generation==iPhoneGeneration.iPad3Gen))
		// {
		// checkdifference=800;          
		//}
		//else
		//{
		checkdifference=400;	
		//}
		minsrosshearsize=PlayerPrefs.GetFloat("acc_value");
		minlengthCrosshear=minlengthCrosshear-minsrosshearsize;
		challengeArrowObjectX=challengeArrowObject.position.x;
		
		challengescorObjectX=challengescorObject.position.x;
		
		guione=GetComponent< GUITexture >();
		
		defaultY=guione.pixelInset.y;
		
		minY=defaultY- checkdifference;//-400;
		
		playerpos=playerScoreObject.position.x;
		
		Aiscorepos=AiscoreObject.position.x;
		
		outdoorchek=controll.instance.outdoor;
		
		challengemode=controll.instance.challenge_mode;	
		//  print ("defaultY"+defaultY);
		//point.transform.renderer.enabled=false;
	}
	void  Update ()
	{    
		if(Application.platform==RuntimePlatform.Android)
		{
			
			if(store_currentStatus.instances.offcontrolling==true)
			{
				transform.GetComponent<GUITexture>().color=new Color(guione.color.r,guione.color.g,guione.color.b,0f);
				rightpad.color=new Color(rightpad.color.r,rightpad.color.g,rightpad.color.b,0f);
				
			}
			if(store_currentStatus.instances.offcontrolling==false)
			{
				transform.GetComponent<GUITexture>().color=new Color(guione.color.r,guione.color.g,guione.color.b,1f);
				rightpad.color=new Color(rightpad.color.r,rightpad.color.g,rightpad.color.b,1f);
			}
			
			
			if(controll.instance.pause==true)
			{
				secondaryboard.GetComponent<Renderer>().material.color=new Color( secondaryboard.GetComponent<Renderer>().material.color.r, secondaryboard.GetComponent<Renderer>().material.color.g, secondaryboard.GetComponent<Renderer>().material.color.b,Mathf.MoveTowards(secondaryboard.GetComponent<Renderer>().material.color.a,0f,Time.deltaTime*1.5f));
				
				point.GetComponent<Renderer>().material.color=new Color( point.GetComponent<Renderer>().material.color.r, point.GetComponent<Renderer>().material.color.g, point.GetComponent<Renderer>().material.color.b,Mathf.MoveTowards(point.GetComponent<Renderer>().material.color.a,0f,Time.deltaTime*1.5f));
			}//-150
			if(guione.pixelInset.y<=defaultY-200&&controll.instance.pause==false&&challenge_Controll.instances.time_showScript.timecomplete==false)
			{
				secondaryboard.GetComponent<Renderer>().material.color=new Color( secondaryboard.GetComponent<Renderer>().material.color.r, secondaryboard.GetComponent<Renderer>().material.color.g, secondaryboard.GetComponent<Renderer>().material.color.b,Mathf.MoveTowards(secondaryboard.GetComponent<Renderer>().material.color.a,1f,Time.deltaTime*1.5f));
				
				point.GetComponent<Renderer>().material.color=new Color( point.GetComponent<Renderer>().material.color.r, point.GetComponent<Renderer>().material.color.g, point.GetComponent<Renderer>().material.color.b,Mathf.MoveTowards(point.GetComponent<Renderer>().material.color.a,1f,Time.deltaTime*1.5f));
				//secondaryboard.transform.renderer.material.color=new Color( secondaryboard.transform.renderer.material.color.r, secondaryboard.transform.renderer.material.color.g, secondaryboard.transform.renderer.material.color.b,Mathf.MoveTowards(secondaryboard.transform.renderer.material.color.a,1f,Time.deltaTime*1.5f));
				//point.transform.renderer.material.color=new Color( point.transform.renderer.material.color.r, point.transform.renderer.material.color.g, point.transform.renderer.material.color.b,Mathf.MoveTowards(point.transform.renderer.material.color.a,1f,Time.deltaTime*1.5f));
				
				if(outdoorchek==true&&challengemode==false)
				{
					playerScoreObject.position=new Vector3(Mathf.MoveTowards( playerScoreObject.position.x,playerpos-1f,Time.deltaTime*2f), playerScoreObject.position.y, playerScoreObject.position.z);
					
					AiscoreObject.position=new Vector3(Mathf.MoveTowards( AiscoreObject.position.x,Aiscorepos-1f,Time.deltaTime*2f), AiscoreObject.position.y, AiscoreObject.position.z);
				}
				
				if(challengemode==true)
				{
					
					if(challengescorObject.gameObject.active==true)
					{
						challengescorObject.position=new Vector3(Mathf.MoveTowards( challengescorObject.position.x,challengescorObjectX-1f,Time.deltaTime*2f), challengescorObject.position.y, challengescorObject.position.z);
						
						//AiscoreObject.position=new Vector3(Mathf.MoveTowards( AiscoreObject.position.x,Aiscorepos-1f,Time.deltaTime*1.5f), AiscoreObject.position.y, AiscoreObject.position.z);
					}
					if(challengeArrowObject.gameObject.active==true)
					{
						challengeArrowObject.position=new Vector3(Mathf.MoveTowards( challengeArrowObject.position.x, challengeArrowObjectX-1f,Time.deltaTime*2f), challengeArrowObject.position.y, challengeArrowObject.position.z);
					}
					
					if(playerScoreObject.gameObject.active==true)
					{
						playerScoreObject.position=new Vector3(Mathf.MoveTowards( playerScoreObject.position.x,playerpos-1f,Time.deltaTime*2f), playerScoreObject.position.y, playerScoreObject.position.z);
						
						AiscoreObject.position=new Vector3(Mathf.MoveTowards( AiscoreObject.position.x,Aiscorepos-1f,Time.deltaTime*2f), AiscoreObject.position.y, AiscoreObject.position.z);
					}
				}
				
			}
			if(guione.pixelInset.y>defaultY-150)
			{
				secondaryboard.GetComponent<Renderer>().material.color=new Color( secondaryboard.GetComponent<Renderer>().material.color.r, secondaryboard.GetComponent<Renderer>().material.color.g, secondaryboard.GetComponent<Renderer>().material.color.b,Mathf.MoveTowards(secondaryboard.GetComponent<Renderer>().material.color.a,0f,Time.deltaTime*1.5f));
				point.GetComponent<Renderer>().material.color=new Color( point.GetComponent<Renderer>().material.color.r, point.GetComponent<Renderer>().material.color.g, point.GetComponent<Renderer>().material.color.b,Mathf.MoveTowards(point.GetComponent<Renderer>().material.color.a,0f,Time.deltaTime*1.5f));
				
				if(outdoorchek==true&&challengemode==false&&controll.instance.gameovercom==false)
				{
					playerScoreObject.position=new Vector3(Mathf.MoveTowards( playerScoreObject.position.x,playerpos,Time.deltaTime*2f), playerScoreObject.position.y, playerScoreObject.position.z);
					
					AiscoreObject.position=new Vector3(Mathf.MoveTowards( AiscoreObject.position.x,Aiscorepos,Time.deltaTime*2f), AiscoreObject.position.y, AiscoreObject.position.z);
				}
				if(outdoorchek==true&&challengemode==false&&controll.instance.gameovercom==true)
				{
					playerScoreObject.position=new Vector3(Mathf.MoveTowards( playerScoreObject.position.x,playerpos-1f,Time.deltaTime*2f), playerScoreObject.position.y, playerScoreObject.position.z);
					
					AiscoreObject.position=new Vector3(Mathf.MoveTowards( AiscoreObject.position.x,Aiscorepos-1f,Time.deltaTime*2f), AiscoreObject.position.y, AiscoreObject.position.z);
				}	
				
				if(challengemode==true)
				{
					
					if(challengescorObject.gameObject.active==true&&controll.instance.gameovercom==false)
					{
						challengescorObject.position=new Vector3(Mathf.MoveTowards( challengescorObject.position.x,challengescorObjectX,Time.deltaTime*2f), challengescorObject.position.y, challengescorObject.position.z);
						
						//AiscoreObject.position=new Vector3(Mathf.MoveTowards( AiscoreObject.position.x,Aiscorepos-1f,Time.deltaTime*1.5f), AiscoreObject.position.y, AiscoreObject.position.z);
					}
					if(challengeArrowObject.gameObject.active==true&&controll.instance.gameovercom==false)
					{
						challengeArrowObject.position=new Vector3(Mathf.MoveTowards( challengeArrowObject.position.x, challengeArrowObjectX,Time.deltaTime*2f), challengeArrowObject.position.y, challengeArrowObject.position.z);
					}
					if(challengescorObject.gameObject.active==true&&controll.instance.gameovercom==true)
					{
						challengescorObject.position=new Vector3(Mathf.MoveTowards( challengescorObject.position.x,challengescorObjectX-1f,Time.deltaTime*2f), challengescorObject.position.y, challengescorObject.position.z);
						
						//AiscoreObject.position=new Vector3(Mathf.MoveTowards( AiscoreObject.position.x,Aiscorepos-1f,Time.deltaTime*1.5f), AiscoreObject.position.y, AiscoreObject.position.z);
					}
					if(challengeArrowObject.gameObject.active==true&&controll.instance.gameovercom==true)
					{
						challengeArrowObject.position=new Vector3(Mathf.MoveTowards( challengeArrowObject.position.x, challengeArrowObjectX-1f,Time.deltaTime*2f), challengeArrowObject.position.y, challengeArrowObject.position.z);
					}
					if(playerScoreObject.gameObject.active==true)
					{
						playerScoreObject.position=new Vector3(Mathf.MoveTowards( playerScoreObject.position.x,playerpos,Time.deltaTime*2f), playerScoreObject.position.y, playerScoreObject.position.z);
						
						AiscoreObject.position=new Vector3(Mathf.MoveTowards( AiscoreObject.position.x,Aiscorepos,Time.deltaTime*2f), AiscoreObject.position.y, AiscoreObject.position.z);
					}
					
				}
				
				// point.transform.renderer.enabled=false;
			}
			// point.transform.renderer.enabled=true;
			// print (ypos1+"cam");
			if(challenge_Controll.instances.time_showScript.timecomplete==true)
			{
				secondaryboard.GetComponent<Renderer>().material.color=new Color( secondaryboard.GetComponent<Renderer>().material.color.r, secondaryboard.GetComponent<Renderer>().material.color.g, secondaryboard.GetComponent<Renderer>().material.color.b,Mathf.MoveTowards(secondaryboard.GetComponent<Renderer>().material.color.a,0f,Time.deltaTime*1.5f));
				point.GetComponent<Renderer>().material.color=new Color( point.GetComponent<Renderer>().material.color.r, point.GetComponent<Renderer>().material.color.g, point.GetComponent<Renderer>().material.color.b,Mathf.MoveTowards(point.GetComponent<Renderer>().material.color.a,0f,Time.deltaTime*1.5f));
				
			}
			ypos1=((((maxlengthCrosshear-minlengthCrosshear)/(-225f-minY)))*((guione.pixelInset.y*1.2f)-(minY)))+minlengthCrosshear;//-.1091596f;//-.28f;//-375
			//camFieldView=((((camminfieldofview-Cammaxfieldofview)/(minlengthCrosshear-maxlengthCrosshear))*(ypos1-maxlengthCrosshear))+Cammaxfieldofview);
			// cam.camera.fieldOfView=camFieldView;
			//   print("ypos1=="+ypos1);
			point.transform.localScale=new Vector3(ypos1,ypos1,ypos1);
			if(point.localScale.x<=minlengthCrosshear)
			{
				point.localScale=new Vector3(minlengthCrosshear,minlengthCrosshear,minlengthCrosshear);
			}
			if(point.localScale.x>=maxlengthCrosshear)
			{
				point.localScale=new Vector3(maxlengthCrosshear,maxlengthCrosshear,maxlengthCrosshear);
			}
			/*	
		if((guione.pixelInset.y>defaultY-200&&(guione.pixelInset.y<defaultY-250)))
		{
			FPSControls.instance.arrowvelocity=42f;
		}
		if((guione.pixelInset.y>=defaultY-250))
		{
			FPSControls.instance.arrowvelocity=43f;
		}
	   if((guione.pixelInset.y>=defaultY-300&&(guione.pixelInset.y<defaultY-250)))
		{
			FPSControls.instance.arrowvelocity=44f;
		}
	 if((guione.pixelInset.y>defaultY-350&&(guione.pixelInset.y<defaultY-300)))
		{
			FPSControls.instance.arrowvelocity=45f;
		}
		*/
		}
		
	}
	
	public void  sift(float touchY )//,  float minBoundry ,  float maxBoundry  )
	{
		
		if(timestop==false)	
			
		{
			guione.pixelInset=new Rect(guione.pixelInset.x,-(transform.position.y*Screen.height-touchY+difference),guione.pixelInset.width,guione.pixelInset.height);
			
			if(guione.pixelInset.y>defaultY)
				guione.pixelInset=new Rect(guione.pixelInset.x,defaultY,guione.pixelInset.width,guione.pixelInset.height);
			
			if(guione.pixelInset.y<minY)
			{
				guione.pixelInset=new Rect(guione.pixelInset.x,minY,guione.pixelInset.width,guione.pixelInset.height);
				
			}
			//gui.pixelInset.y=minBoundry
			
		}
		
	}		
}


