using UnityEngine;
using System.Collections;

public class flashcontrolling : MonoBehaviour 
{
	//public float camfieldruntime;
	//public float arrowmaxfieldview;
	//public float arrowminfieldview;
	public float arrowcurrentpostion;
	
	public Transform secondaryboard;
	
	public Transform point;
	
	public float mincamfieldofview;//18
	
	public bool pauseone;
	
	public Transform playerScoreObject;
	
public Transform AiscoreObject;
	
public float playerpos;
	
public float Aiscorepos;
	
public bool outdoorchek;
	
public bool challengemode;
	
public bool comeback;
	
public Transform challengescorObject;
	
public Transform challengeArrowObject;

public float challengescorObjectX;
	
public float challengeArrowObjectX;

public bool gameplaystart;
	
public GUITexture pause;
	
public GUITexture powerup;
	
public int currentchallenge;
//public static flashcontrolling instances;
	
//public bool checkhitarea;
	
	
	
void Start()
	{
		//instances=this;
		playerpos=playerScoreObject.position.x;;
		
		 Aiscorepos=AiscoreObject.position.x;
		
		challengeArrowObjectX=challengeArrowObject.position.x;
		
	    challengescorObjectX=challengescorObject.position.x;
		outdoorchek=controll.instance.outdoor;
		
	    challengemode=controll.instance.challenge_mode;	
		
		currentchallenge=notDestroy.instances.challengeSelect;
	
		
	}
	//public bool afterpausenotwork;
	// Update is called once per frame
void Update () 
{
	 
		
	  if(Application.platform!=RuntimePlatform.Android && store_currentStatus.instances.offcontrolling==false&&gameplaystart==true&&pauseone==false&&Input.GetMouseButton(0)&&FPSControls.instance.isHeld==true)//&&pause.HitTest(Input.mousePosition,Camera.main)==false&&powerup.HitTest(Input.mousePosition,Camera.main)==false)
		
	 {
			 
			FPSControls.instance.cam.GetComponent<Camera>().fieldOfView=FPSControls.instance.cam.GetComponent<Camera>().fieldOfView-1;
		
			if(FPSControls.instance.cam.GetComponent<Camera>().fieldOfView<=mincamfieldofview)
			
			{
				
			  FPSControls.instance.cam.GetComponent<Camera>().fieldOfView=mincamfieldofview;
				
			   if(Input.GetAxis("Mouse X")==0&&Input.GetAxis("Mouse Y")==0)
				
			   {
				
				  randomNewHnadshake.instances.startshaking=true;
				
			   }
				
			}
			 
			arrowcurrentpostion=(((FPSControls.instance.minhandrange-FPSControls.instance.maxhandrange)/(mincamfieldofview-45))*(FPSControls.instance.cam.GetComponent<Camera>().fieldOfView-45))+FPSControls.instance.maxhandrange;
		    
			FPSControls.instance.transform.localPosition=new Vector3(FPSControls.instance.transform.localPosition.x,FPSControls.instance.transform.localPosition.y,arrowcurrentpostion);
		    
			secondaryboard.transform.GetComponent<Renderer>().material.color=new Color( secondaryboard.transform.GetComponent<Renderer>().material.color.r, secondaryboard.transform.GetComponent<Renderer>().material.color.g, secondaryboard.transform.GetComponent<Renderer>().material.color.b,Mathf.MoveTowards(secondaryboard.transform.GetComponent<Renderer>().material.color.a,1f,Time.deltaTime*4f));
		    
			point.transform.GetComponent<Renderer>().material.color=new Color( point.transform.GetComponent<Renderer>().material.color.r, point.transform.GetComponent<Renderer>().material.color.g, point.transform.GetComponent<Renderer>().material.color.b,Mathf.MoveTowards(point.transform.GetComponent<Renderer>().material.color.a,1f,Time.deltaTime*4f));
		  
			if(outdoorchek==true&&challengemode==false)
				{
		        playerScoreObject.position=new Vector3(Mathf.MoveTowards( playerScoreObject.position.x,playerpos-1f,Time.deltaTime*1.5f), playerScoreObject.position.y, playerScoreObject.position.z);
				
		        AiscoreObject.position=new Vector3(Mathf.MoveTowards( AiscoreObject.position.x,Aiscorepos-1f,Time.deltaTime*1.5f), AiscoreObject.position.y, AiscoreObject.position.z);
			    comeback=false;	
			}
			
			if(challengemode==true)
				{
					
					if(challengescorObject.gameObject.active==true)
					{
						challengescorObject.position=new Vector3(Mathf.MoveTowards( challengescorObject.position.x,challengescorObjectX-1f,Time.deltaTime*1.5f), challengescorObject.position.y, challengescorObject.position.z);
				
		               
					}
				
				    if(playerScoreObject.gameObject.active==true)
				    {
					 playerScoreObject.position=new Vector3(Mathf.MoveTowards( playerScoreObject.position.x,playerpos-1f,Time.deltaTime*1.5f), playerScoreObject.position.y, playerScoreObject.position.z);
				
		             AiscoreObject.position=new Vector3(Mathf.MoveTowards( AiscoreObject.position.x,Aiscorepos-1f,Time.deltaTime*1.5f), AiscoreObject.position.y, AiscoreObject.position.z);
			      	
				    }
				
				    
					if(challengeArrowObject.gameObject.active==true)
					{
						challengeArrowObject.position=new Vector3(Mathf.MoveTowards( challengeArrowObject.position.x, challengeArrowObjectX-1f,Time.deltaTime*1.5f), challengeArrowObject.position.y, challengeArrowObject.position.z);
					}
				  comeback=false;	
				
		}
	}
	    if(comeback==true)
		{
			  if(outdoorchek==true&&challengemode==false&&controll.instance.gameovercom==false)
				{
		          playerScoreObject.position=new Vector3(Mathf.MoveTowards( playerScoreObject.position.x,playerpos,Time.deltaTime*1.5f), playerScoreObject.position.y, playerScoreObject.position.z);
				
		          AiscoreObject.position=new Vector3(Mathf.MoveTowards( AiscoreObject.position.x,Aiscorepos,Time.deltaTime*1.5f), AiscoreObject.position.y, AiscoreObject.position.z);
				}
			
			  if(controll.instance.gameovercom==true&&challengemode==false)
			
		       {
			
				 playerScoreObject.position=new Vector3(Mathf.MoveTowards( playerScoreObject.position.x,playerpos-1f,Time.deltaTime*1.5f), playerScoreObject.position.y, playerScoreObject.position.z);
				
		        AiscoreObject.position=new Vector3(Mathf.MoveTowards( AiscoreObject.position.x,Aiscorepos-1f,Time.deltaTime*1.5f), AiscoreObject.position.y, AiscoreObject.position.z);
			    
			
		       }
				
			if(challengemode==true)
				{
					
					if(challengescorObject.gameObject.active==true)//&&controll.instance.gameovercom==false)
					{
						challengescorObject.position=new Vector3(Mathf.MoveTowards( challengescorObject.position.x,challengescorObjectX,Time.deltaTime*1.5f), challengescorObject.position.y, challengescorObject.position.z);
				
		               
					}
					if(challengeArrowObject.gameObject.active==true)//&&controll.instance.gameovercom==false)
					{
						challengeArrowObject.position=new Vector3(Mathf.MoveTowards( challengeArrowObject.position.x, challengeArrowObjectX,Time.deltaTime*1.5f), challengeArrowObject.position.y, challengeArrowObject.position.z);
					}
					
				   
				   if(playerScoreObject.gameObject.active==true)//&&controll.instance.gameovercom==false)
				  {
					 playerScoreObject.position=new Vector3(Mathf.MoveTowards( playerScoreObject.position.x,playerpos,Time.deltaTime*1.5f), playerScoreObject.position.y, playerScoreObject.position.z);
				
		             AiscoreObject.position=new Vector3(Mathf.MoveTowards( AiscoreObject.position.x,Aiscorepos,Time.deltaTime*1.5f), AiscoreObject.position.y, AiscoreObject.position.z);
				 }
				
			
				}
		
		}
		if(gameplaystart==true&&Input.GetMouseButtonUp(0)&& Application.platform != RuntimePlatform.Android &&FPSControls.instance.isHeld==true)
		
		{       
			 comeback=true;
			secondaryboard.transform.GetComponent<Renderer>().material.color=new Color( secondaryboard.transform.GetComponent<Renderer>().material.color.r, secondaryboard.transform.GetComponent<Renderer>().material.color.g, secondaryboard.transform.GetComponent<Renderer>().material.color.b,0f);
		    
			point.transform.GetComponent<Renderer>().material.color=new Color( point.transform.GetComponent<Renderer>().material.color.r, point.transform.GetComponent<Renderer>().material.color.g, point.transform.GetComponent<Renderer>().material.color.b,0f);
			
			if(FPSControls.instance.cam.GetComponent<Camera>().fieldOfView<(mincamfieldofview+2))
			{
				FPSControls.instance.Unparrent();
				
				FPSControls.instance.isHeld=false;
				
				randomNewHnadshake.instances.startshaking=false;
				
				store_currentStatus.instances.realsearrow();
			}
			else
			{
				FPSControls.instance.cam.GetComponent<Camera>().fieldOfView=45;
				
			    FPSControls.instance.transform.localPosition=new Vector3(FPSControls.instance.transform.localPosition.x,FPSControls.instance.transform.localPosition.y,FPSControls.instance.maxhandrange);
			
			}
			
		
		}
		
		
		}
	
	

	bool CheckInsideRect(Rect rectToCheck) 
 {
   
   rectToCheck.y=Screen.height-rectToCheck.y-rectToCheck.height;   
   return rectToCheck.Contains(Input.mousePosition);
 }
//}
}
