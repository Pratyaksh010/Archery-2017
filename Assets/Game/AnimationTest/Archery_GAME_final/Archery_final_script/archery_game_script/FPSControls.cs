// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class FPSControls : MonoBehaviour
{
	

public GUITexture speedMeter;

public SpeedThumb speedThumb;

public GameObject arrow;

public GameObject bow;

public GameObject cam;
//public RandomShake randomshake;
//public FIXME_VAR_TYPE leftArm;

public randomNewHnadshake randomhandshake;

public GameObject[] josticks;

public SmoothLookAtCS smoothLookAt;

public float distance=0.6f;
///public GameObject plane;
//public Transform arrowMesh;

public float minSpeed;

public float maxSpeed;

public float minDistance;

public float maxDistance;

public float currentSpeed; 
//private  string label;
private bool  isCollision;
//private float height=0.4f;
//private float camFollowDist=1;
public GameObject human;

public Rect crossHairRect;

public Texture crossHair;

private float widthFactor;

private float heightFactor;

public float arrowReleaseTime;

public float followDelay;

public Ray rayToCheck;

public GameObject hand;

public GameObject stringlts;
///public GameObject thread;
//public Transform threadLook;
//////public RagDollAnimation animateChar;
///private Vector3 rotationCenter;
private float hitTime;
////private float loadTime;
public TrailRenderer trail;

private RotationLimit[] rtLimit;

private bool released;

public static FPSControls instance;
//public GameObject Secondraycam;
//public DestroyArrowparrent destroy;
public controll destroy;

public float speedtime;

public float minrange;

public float minhandrange;

public float maxhandrange;
/////private Vector3 directioncam;
public bool resetArrow;

public  RaycastHit hitDir;

public bool camsw;

public float timecam;

public float targetangel;

public float arrowvelocity;

public float camFieldView;

public float Cammaxfieldofview;

public float camminfieldofview;

public bool onetimecamvel;

public float boardpostion;

	
public GameObject frontboard;

public bool rotcamstop;

public float resetgameplay;

public float timedelay;

public GameObject crosshairobject;

public Ray crossray;

public Vector3 projectionpoint;// store the crosshairobject projection point

public float decratefieldview;

public bool onetimescorecall;
//false var
public bool isHeld;

public GameObject ground;
	
public float currentvelocity;
	
public bool outdoor1;
	
public bool chanllge;
	
public challenge_Controll challengeScript;

public Transform Arrowchild;
	
public GameObject Lefthand;
	
public GameObject Recurve_bow1;
	
public GameObject Object0031;
	
public float Playeraddforce;

public GUIText skiptoactive;
 
public bool showskipactive;
	
public float taptoskiptimedelay;
	
public bool onetimetapcall;
	
public Transform cloneobject;
	
private bool checkdivce;
	
float _joystickforceValue ;
	

//public Transform _renderarrow;
//public Material bowmaterial;
void  Start ()
{  
		
	 controll.instance.changelayer(0);
    isHeld=true;
	 _joystickforceValue = 0f ;
	BoardScore.instances._arrowmultiplier = 1 ;	
	
//    if(Application.platform==RuntimePlatform.IPhonePlayer&&(iPhone.generation==iPhoneGeneration.iPad3Gen))
	if(Application.platform == RuntimePlatform.Android)
	{
			 checkdivce=true;       
    }
		    	
   hitTime=0f;
//   print ("size=="+Screen.width+"++"+Screen.height);
  Playeraddforce=PlayerPrefs.GetFloat("powervalue");
  instance=this;
  
  camsw=false;// camera switching stop
 
  crosshairobject=GameObject.Find("crosshair")as GameObject;
  
  skiptoactive=GameObject.Find("Taptoskip").GetComponent<GUIText>();
 
  skiptoactive.transform.gameObject.SetActive(false);	
 
  showskipactive=false;	
  
  //destroy=GameObject.Find("GameHandler").GetComponent("DestroyArrowparrent")as DestroyArrowparrent;// clone create ArrowParrent
  destroy=GameObject.Find("GameHandler").GetComponent("controll")as controll;
  
  speedMeter=GameObject.Find("SPEEDTHUMB").GetComponent<GUITexture>();
  
  speedThumb=GameObject.Find("SPEEDTHUMB").GetComponent("SpeedThumb")as SpeedThumb;
  
  bow=GameObject.Find("bow")as GameObject;
 // bowmaterial=bow.transform.renderer.material;
 // bowmaterial.mainTexture=store_currentStatus.instances.currentbowtexture;
  cam=GameObject.Find("Main Camera")as GameObject;
 
  Lefthand=GameObject.Find("Left_Hand")as GameObject;
  //randomshake=cam.GetComponent("RandomShake")as RandomShake;
  randomhandshake=cam.GetComponent("randomNewHnadshake")as randomNewHnadshake;
 
  hand=GameObject.Find("Right_Hand")as GameObject;
  //hand.renderer.enabled=true;
  Object0031=GameObject.Find("Object003")as GameObject;
  stringlts=GameObject.Find("String_ctrl")as GameObject;
  
  widthFactor=Screen.width/698f;//517.0f;
  
  heightFactor=Screen.height/524f;//388.0f;
  
  crossHairRect=ResolutionHelper(crossHairRect);
  
  Recurve_bow1=GameObject.Find("Recurve_bow")as  GameObject;
  ////loadTime=Time.time;
  
  rtLimit = (RotationLimit[])FindObjectsOfType(typeof(RotationLimit));
  
  human=GameObject.Find("HUMAN")as GameObject;
  
  //Secondraycam=GameObject.Find("point")as GameObject;
  
  smoothLookAt=cam.GetComponent("SmoothLookAtCS")as SmoothLookAtCS;
  
  smoothLookAt.reset();
  //smoothLookAt.smooth=true;
  smoothLookAt.enabled=false;	
  
  josticks[0]=GameObject.Find("RightJoystick")as GameObject;
  josticks[1]=GameObject.Find("RightPad")as GameObject;
  josticks[2]=GameObject.Find("SPEEDTHUMB")as GameObject;
  josticks[3]=GameObject.Find("LeftJoystick")as GameObject;
  josticks[4]=GameObject.Find("LeftPad")as GameObject;
  store_currentStatus.instances.joystickactive = true ;
  cam.GetComponent<Camera>().fieldOfView=45;
 // Secondraycam.transform.renderer.enabled=true;
  
  rtLimit[0].enabled=true;
  
  rtLimit[1].enabled=true;
  
  timecam=.75f;
 
 arrowvelocity=45f;
 
 onetimecamvel=false;

 frontboard	=GameObject.Find("Main Archery")as GameObject;
 
 boardpostion=frontboard.transform.position.z;
	
 rotcamstop=false;
 
 released=false;
 
 onetimescorecall=true;
		
chanllge=controll.instance.challenge_mode;

if(controll.instance.state==0 &&chanllge==false)
{
		followDelay=.18f;	
}
if(controll.instance.state==1 && chanllge==false)
{
		followDelay=.25f;//.33f;//.22f;	
}
if(controll.instance.state==2 && chanllge== false)
{
		followDelay=.35f;	
		
}
		
if(controll.instance.outdoor==false&& chanllge==false)
{
	ground=GameObject.Find("Ground");
	currentvelocity=controll.instance.camvelocitymuli;		
}

if(controll.instance.outdoor==true&& chanllge==false)
{
	
   ground=GameObject.Find("Ground001");
   
   currentvelocity=controll.instance.camvelocitymuli;	// assign current velocity		
}

if(chanllge==true)
{
	challengeScript=GameObject.Find("GameHandler").GetComponent("challenge_Controll")as challenge_Controll;	
			
	if(challengeScript.challengeState==0)
    {
		followDelay=.18f;	
    }

	if(challengeScript.challengeState==1)
    {
		followDelay=.27f;//.33f;//.22f;	
     }
    if(challengeScript.challengeState==2)
     {
		followDelay=.33f;	
		
     } 
			
	if(challengeScript.currentChallengeNumber==1||challengeScript.currentChallengeNumber==6||challengeScript.currentChallengeNumber==8)
	{
		ground=GameObject.Find("Ground001");		
	}
    if(challengeScript.currentChallengeNumber==2||challengeScript.currentChallengeNumber==3||challengeScript.currentChallengeNumber==4||challengeScript.currentChallengeNumber==5||challengeScript.currentChallengeNumber==7||challengeScript.currentChallengeNumber==9||challengeScript.currentChallengeNumber==10||challengeScript.currentChallengeNumber==11||challengeScript.currentChallengeNumber==12||challengeScript.currentChallengeNumber==13||challengeScript.currentChallengeNumber==14||challengeScript.currentChallengeNumber==15||challengeScript.currentChallengeNumber==16)
	{
		ground=GameObject.Find("Ground001");		
	}
}
		
outdoor1=controll.instance.outdoor;
		
if(outdoor1==true&& chanllge==true)
{
	currentvelocity=challenge_Controll.instances.camvelocitymuli1;		// assign current velocity to arrow
}

}


float Linear ( float currentSpd)
{
    float requiredDist;
  
    requiredDist=((maxDistance-minDistance)/(maxSpeed-minSpeed))*(currentSpd-minSpeed)+minDistance;
  
    return requiredDist;

}

float LinearSpeed ( float x1 ,  float x2 ,  float y1 ,  float y2 ,  float currentX  )
{

   float valueToReturn;
   
   valueToReturn=((y2-y1)/(x2-x1))*(currentX-x1)+y1; 
   
   return valueToReturn;

}

 Rect ResolutionHelper ( Rect rect  )
{
    
   return (new Rect(rect.x*widthFactor,rect.y*heightFactor,rect.width*widthFactor,rect.height*heightFactor));
}

void  Update ()
{
   // crossray=new Ray(crosshairobject.transform.position,crosshairobject.transform.forward);
		 //Debug.DrawLine(crosshairobject.transform.position,crosshairobject.transform.forward,Color.green);
		
		if(chanllge==true&&challengeScript.challenge_mode_guiscript.resultfuncall==true)
		{
			  bow.GetComponent<Renderer>().enabled=false;
			
			// Arrowchild.renderer.enabled=false;
			  Arrowchild.gameObject.SetActive(false);
			 //_renderarrow.renderer.enabled=false;
			  hand.GetComponent<Renderer>().enabled=false;
			
			 Lefthand.GetComponent<Renderer>().enabled=false;
			
			 Recurve_bow1.GetComponent<Renderer>().enabled=false;
			
			 Object0031.GetComponent<Renderer>().enabled=false;
			// skiptoactive.transform.gameObject.SetActive(false);
			skiptoactive.material.color=new Color(1,1,1,0);
			 
		}
		
        Ray ray=new Ray(transform.position,transform.forward);
   
		if(released==true&& arrow.GetComponent<Rigidbody>().isKinematic==false&&controll.instance.outdoor==true)
		{
			arrow.GetComponent<Rigidbody>().velocity=arrow.GetComponent<Rigidbody>().velocity+(controll.instance.windobject.up)*controll.instance.windmagnitude;
		}
		if(released==true&& arrow.GetComponent<Rigidbody>().isKinematic==false&& chanllge==true)
		{
			arrow.GetComponent<Rigidbody>().velocity=arrow.GetComponent<Rigidbody>().velocity+(challenge_Controll.instances.challegeWindObject.up)*challenge_Controll.instances.challengewindmagnitude;
		}
		
   //Debug.DrawLine(ray.origin,transform.forward,Color.red);
       
   RaycastHit hit;
	  
   if((isCollision )|| (Physics.Raycast(ray.origin,transform.forward,out hit,.3f) && hit.distance<.1f) ||(transform.position.z> (boardpostion-.12f))||transform.position.y<=ground.transform.position.y )//&& hit.distance<.2f
               
   {  
			
       trail.enabled=false;

	   if(isCollision)
		            
	   {
			     
	      Physics.Raycast(ray.origin,transform.forward,out hit,.3f);// after hit 
		            
	    }
            
	    if(hitTime==0)
              
	      hitTime=Time.time;
         
             
	      arrow.GetComponent<Rigidbody>().isKinematic=true; 
		  cam.GetComponent<Rigidbody>().isKinematic=true;      
		 
			
		  smoothLookAt.smooth=false;
		   
		  if(onetimescorecall==true)
		 {
           BoardScore.boardsc.showScore(new Vector2(arrow.transform.position.x,arrow.transform.position.y ));
		  
		  Arrowchild.GetComponent<Animation>().Play("arrowhit");
		  Arrowchild.GetComponent<Animation>()["arrowhit"].speed= Arrowchild.GetComponent<Animation>()["arrowhit"].speed*4f;
		  audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[3];
		  audioManager.instances.playcurrentaudio();
		  Transform t1=Instantiate(cloneobject.transform,transform.position, Quaternion.identity) as Transform;
		   //print (score_calculation.instances.scorecall);
		   onetimescorecall=false;
		 }
	}// iscollision
	        
   if(arrow.GetComponent<Rigidbody>().isKinematic)
            
   {
    
        rayToCheck=Camera.main.ScreenPointToRay(new Vector3(crossHairRect.x+crossHairRect.width/2,Screen.height-crossHairRect.y-crossHairRect.height/2,0));
       // if(Physics.Raycast(rayToCheck.origin,rayToCheck.direction,out hit,Mathf.Infinity))
        //label=hit.collider.name+","+hit.distance.ToString();
   }
 
   if(showskipactive==true&&Time.time-taptoskiptimedelay>.1f)
		{
			 
		  if(stringlts.transform.parent!=null)
			            
		  {//10
				          
			stringlts.transform.parent=null;
			             
		   }//10
			          
		  if(stringlts.transform.parent==null)
			           
		   {//11
			      
				isHeld=false;
				
				if(chanllge==false)// select the standrad indoor or outdoor game
			    {
				   destroy.destroy=true;
			       controll.instance.pausedis.gameObject.gameObject.SetActive(true); 
				   controll.instance.powerup.gameObject.SetActive(true);
				   controll.instance.setgravity(0);
				   destroy_object.instances._enableclone=true;
				   DestroyObject(transform.gameObject);
					
				}
				if(chanllge==true)
				{
					challengeScript.destroychallenge=true;
					if(challenge_mode_gui.instances.showgameresult==false)
					
				   {
				    challenge_Controll.instances.pausebutton.gameObject.gameObject.SetActive(true);
					challenge_Controll.instances.powerup.gameObject.SetActive(true);
										
				   }
					challenge_Controll.instances.setgravity(0);
					destroy_object.instances._enableclone=true;
					DestroyObject(transform.gameObject);
				}
			 showskipactive=false;
		}

		}
     // Unparrent();
  
   
  if(!arrow.GetComponent<Rigidbody>().isKinematic&&bow.transform.parent==null&&human.transform.parent==null&& stringlts.transform.parent==null)//&&hand.transform.parent==null
            
  {
       arrow.transform.forward=arrow.GetComponent<Rigidbody>().velocity.normalized;
            
       Vector3 cameraPosition;
             
	   if(Time.time-arrowReleaseTime>=followDelay&&onetimecamvel==false)
				
      {
           cam.GetComponent<Rigidbody>().isKinematic=false;
           if(outdoor1==true)//||chanllge==true)//controll.instance.outdoorcontroll.instance.outdoor
		{
	      cam.GetComponent<Rigidbody>().velocity= cam.transform.forward.normalized*(arrow.GetComponent<Rigidbody>().velocity.magnitude*currentvelocity);//controll.instance.camvelocitymuli);//arrow.transform.forward*directioncam
				
		} 
	    if(outdoor1==false)
		{
			 cam.GetComponent<Rigidbody>().velocity= cam.transform.forward.normalized*(arrow.GetComponent<Rigidbody>().velocity.magnitude*currentvelocity);		
		}
		if(outdoor1==true&&chanllge==true)
		{
			 cam.GetComponent<Rigidbody>().velocity= cam.transform.forward.normalized*(arrow.GetComponent<Rigidbody>().velocity.magnitude*currentvelocity);		
		}
		
		  //smoothLookAt.target=transform.gameObject;
		  
		  smoothLookAt.enabled=true;
				
		  
		 
		  onetimecamvel=true;
      }
	
     for(int i=0;i<josticks.Length;i++)
             
		josticks[i].gameObject.SetActive(false);
			
     }
       
	if((released && arrow.GetComponent<Rigidbody>().isKinematic&& transform.position.y<=ground.transform.position.y)&&showskipactive==false)
	{
		     
		     //skiptoactive.transform.gameObject.SetActive(true);
			
			// skiptoactive.material.color=new Color(1,1,1,1);
			
			if(onetimetapcall==false)
			{
				taptoskipactive();
				
				onetimetapcall=true;
				
			}
			
			if(cam.GetComponent<Camera>().fieldOfView>controll.instance.camfield&&chanllge==false)
					   
	     {
		 
		     cam.GetComponent<Camera>().fieldOfView=cam.GetComponent<Camera>().fieldOfView-decratefieldview;
		 
		  }
		  if(chanllge==true&&cam.GetComponent<Camera>().fieldOfView>challenge_Controll.instances.camfieldchallenge)
					   
	     {
		 
		     cam.GetComponent<Camera>().fieldOfView=cam.GetComponent<Camera>().fieldOfView-decratefieldview;
		 
		  }
		  if(Time.time-(hitTime+.15f)>=timecam)
		  {
			
			     if(stringlts.transform.parent!=null)
		        {//10
				          
			        stringlts.transform.parent=null;
			             
		        }//10
			          
		        if( stringlts.transform.parent==null)
			           
		       {//11
			      
				isHeld=false;
				  
					if(chanllge==false)// select the standrad indoor or outdoor game
			      
					{
				       destroy.destroy=true;
			           controll.instance.pausedis.gameObject.gameObject.SetActive(true);  
					   controll.instance.powerup.gameObject.SetActive(true);
		
		               controll.instance.setgravity(0);
					   destroy_object.instances._enableclone=true;
					   DestroyObject(transform.gameObject);
					}
					if(chanllge==true)
					{
						challengeScript.destroychallenge=true;
						if(challenge_mode_gui.instances.showgameresult==false)
					
				        {
				          challenge_Controll.instances.pausebutton.gameObject.gameObject.SetActive(true);
						  challenge_Controll.instances.powerup.gameObject.SetActive(true);
										
				        }
						challenge_Controll.instances.setgravity(0);
						destroy_object.instances._enableclone=true;
						DestroyObject(transform.gameObject);
					}
					
		       }//11	
			
		}
			
	}
		
		
     if(released && arrow.GetComponent<Rigidbody>().isKinematic&& transform.position.y>ground.transform.position.y&&showskipactive==false)
	        
	 {//1
			///skiptoactive.transform.gameObject.SetActive(true);
			
			//skiptoactive.material.color=new Color(1,1,1,1);
			
			if(onetimetapcall==false)
			{
				taptoskipactive();
				
				onetimetapcall=true;
				
			}
			
		if(cam.GetComponent<Rigidbody>().isKinematic==false)
		{
			cam.GetComponent<Rigidbody>().isKinematic=true;	
		}
		if(arrow.transform.parent!=null) 
			     
	  {//2
		      cam.transform.RotateAround(arrow.transform.position,Vector3.up,30*Time.deltaTime);
				   
				  
			  if(cam.transform.eulerAngles.y>targetangel)
				  
		    {//3
				if((hitTime!=0 && Time.time-hitTime>=timecam)||(transform.position.z>(boardpostion-.12f)))
		              
			  {//Application.LoadLevel(Application.loadedLevel);4
						   
			      print (transform.eulerAngles.y+"e");
			    if(stringlts.transform.parent!=null)
			            
		        {//5
				    stringlts.transform.parent=null;
			    }//5
			   if( stringlts.transform.parent==null)
			               
	            {//6
					isHeld=false;
			        if(chanllge==false)// select the standrad indoor or outdoor game
			      
					{
				       destroy.destroy=true;
			           controll.instance.pausedis.gameObject.gameObject.SetActive(true); 
					   controll.instance.powerup.gameObject.SetActive(true);
					   controll.instance.setgravity(0);
					   destroy_object.instances._enableclone=true;
					   DestroyObject(transform.gameObject);
					}
					if(chanllge==true)
					{
						challengeScript.destroychallenge=true;
					    if(challenge_mode_gui.instances.showgameresult==false)
					
				      {
				         challenge_Controll.instances.pausebutton.gameObject.gameObject.SetActive(true);
						 challenge_Controll.instances.powerup.gameObject.SetActive(true);
										
				      }
						challenge_Controll.instances.setgravity(0);
						destroy_object.instances._enableclone=true;
						DestroyObject(transform.gameObject);
					}
			    }///6
			
		      }//4	
	           
		}//3
				
				
   }//2
   else
			
	{//7
		
     if(rotcamstop==false)
				   
	 {
	    resetgameplay=Time.time; 
	   //resetgameplay=Time.time;       
		if(cam.transform.eulerAngles.y<targetangel+5)
	   {
	   cam.transform.RotateAround(arrow.transform.position,Vector3.up,30*Time.deltaTime);
	   }			   
	   if(cam.GetComponent<Camera>().fieldOfView>controll.instance.camfield&& chanllge==false)
					   
	   {
		 
		  cam.GetComponent<Camera>().fieldOfView=cam.GetComponent<Camera>().fieldOfView-decratefieldview;
		 
		}
					
	   if(cam.GetComponent<Camera>().fieldOfView>challenge_Controll.instances.camfieldchallenge&& chanllge==true)
					   
	   {
		 
		  cam.GetComponent<Camera>().fieldOfView=cam.GetComponent<Camera>().fieldOfView-decratefieldview;
		 
		}			   
	  }
				       
  
			 // 	print ("co");
				
   if(cam.transform.eulerAngles.y>targetangel)
				
  {//8
					  
	 if((hitTime!=0 && Time.time-hitTime>=timecam))//||(transform.position.z>(boardpostion+.1f)))
    {
	    if(cam.GetComponent<Camera>().fieldOfView<=controll.instance.camfield&&chanllge==false)
	    {
	      rotcamstop=true;
	    }	
		if(cam.GetComponent<Camera>().fieldOfView<=challenge_Controll.instances.camfieldchallenge&&chanllge==true)
	    {
	      rotcamstop=true;
	    }				
	    if(Time.time- resetgameplay>=timedelay) 
	    {///timedelay
		   if(stringlts.transform.parent!=null)
			            
		  {//10
				          
			stringlts.transform.parent=null;
			             
		   }//10
			          
		  if(stringlts.transform.parent==null)
			           
		   {//11
			      
				isHeld=false;
				
				if(chanllge==false)// select the standrad indoor or outdoor game
			    {
				   destroy.destroy=true;
			       controll.instance.pausedis.gameObject.gameObject.SetActive(true); 
				   controll.instance.powerup.gameObject.SetActive(true);
				   controll.instance.setgravity(0);
				   destroy_object.instances._enableclone=true;
				   DestroyObject(transform.gameObject);
					
				}
				if(chanllge==true)
				{
					challengeScript.destroychallenge=true;
					if(challenge_mode_gui.instances.showgameresult==false)
					
				   {
				    challenge_Controll.instances.pausebutton.gameObject.gameObject.SetActive(true);
					challenge_Controll.instances.powerup.gameObject.SetActive(true);
										
				   }
					challenge_Controll.instances.setgravity(0);
					destroy_object.instances._enableclone=true;
					DestroyObject(transform.gameObject);
				}
		    }//11
		}///timedelay
			
	}//9
  }//8
  
		 
} //7 
			
		if(skiptoactive.gameObject.active==true&&Input.GetMouseButtonDown(0)&&skiptoactive.material.color.a==1)
			{
				
				showskipactive=true;
				taptoskiptimedelay=Time.time;
			}
			
}//1


	}
	public void  ReleaseArrow ()
{
	 
	 // Secondraycam.transform.renderer.enabled=false;
		  arrow.transform.parent=null;
    
	      arrow.GetComponent<Rigidbody>().isKinematic=false;
     
	      distance=Linear(currentSpeed);
     
	      arrowReleaseTime=Time.time;
	       
	      released=true;
      
		  
		
		 Vector3 velocityDir=new Vector3();
	  
		
		Vector3 projectPoint2D=Camera.main.WorldToScreenPoint(crosshairobject.transform.position);
		
		crossray=Camera.main.ScreenPointToRay(projectPoint2D);
		
      if(Physics.Raycast(crossray.origin,crossray.direction ,out hitDir,Mathf.Infinity))
	
      {
          arrow.transform.localRotation=new Quaternion (0,arrow.transform.localRotation.y,arrow.transform.localRotation.z,0);
          velocityDir=(hitDir.point- arrow.transform.position).normalized;
		  store_currentStatus.instances.resetarrowvalue = 0 ;
	     if(chanllge==false)
		{
		  arrow.GetComponent<Rigidbody>().isKinematic=false;
		   
		  arrow.GetComponent<Rigidbody>().velocity =velocityDir.normalized*controll.instance.veloc;//*currentSpeed;
				
		}
		
		if(chanllge==true)
		{
		  arrow.GetComponent<Rigidbody>().isKinematic=false;
		  if(outdoor1==false)
		  {
		    arrow.GetComponent<Rigidbody>().velocity =(velocityDir.normalized*(45f+ Playeraddforce));//controll.instance.veloc;	
		  }
		  if(outdoor1==true)
		  {
			 arrow.GetComponent<Rigidbody>().velocity =velocityDir.normalized*(challengeScript.challengeconVel+_joystickforceValue);
						
		   }
		}
	
		
		
	}
			
	
     
	      rtLimit[0].enabled=false;
	 
	      rtLimit[1].enabled=false;
	
	   
		  randomhandshake.startshaking=false;
		
		 
 }
	
public void  MoveHand(int fingerid)
{
       
		if(fingerid>=0)
		
		{ 
			if(checkdivce==false)
			{
			transform.Translate(0,0,Input.GetTouch(fingerid).deltaPosition.y*0.075f*Time.deltaTime);
			}
			if(checkdivce==true)
			{
			transform.Translate(0,0,Input.GetTouch(fingerid).deltaPosition.y*0.045f*Time.deltaTime);
			}
			
			camFieldView=((((camminfieldofview-Cammaxfieldofview)/(SpeedThumb.instance.minlengthCrosshear-SpeedThumb.instance.maxlengthCrosshear))*(SpeedThumb.instance.ypos1-SpeedThumb.instance.maxlengthCrosshear))+Cammaxfieldofview);
			cam.GetComponent<Camera>().fieldOfView=camFieldView;
		   _joystickforceValue = ((45- camFieldView)/12.5f) ;
		   if(cam.GetComponent<Camera>().fieldOfView>Cammaxfieldofview)
		    {
			cam.GetComponent<Camera>().fieldOfView=45;
			
		    }
		  if(cam.GetComponent<Camera>().fieldOfView<camminfieldofview)
		    {
			cam.GetComponent<Camera>().fieldOfView=20;
			
				
		    }
			
	       
	       
	        if(transform.localPosition.z<minhandrange)
			{
	          transform.localPosition=new Vector3(transform.localPosition.x,transform.localPosition.y,minhandrange);
			  
			}
			if(transform.localPosition.z<=(minhandrange+.3f))
			{
				
				randomhandshake.startshaking=true;
			}
	        if(transform.localPosition.z>maxhandrange)
			{
			transform.localPosition=new Vector3(transform.localPosition.x,transform.localPosition.y,maxhandrange);
			}
			if(transform.localPosition.z>(minhandrange+.3f))
			{
			
				randomhandshake.startshaking=false;
			}
		}
				


}

void  OnCollisionEnter (Collision other)
{
	 print ("//collide");
    //  arrow.rigidbody.isKinematic=true;
      //cam.rigidbody.isKinematic=true;
      isCollision=true;
 
}


public void Unparrent()
{
	  
	  notDestroy.instances._activeArrowPopUp = false ;	
	
	  bow.transform.parent=null;
		
      human.transform.parent=null;
	  
	//  hand.transform.parent=null;
	  
	  stringlts.transform.parent=null;
	  if(bow.transform.parent==null&& human.transform.parent==null&&stringlts.transform.parent==null)//&&hand.transform.parent==null
	 {
			 ReleaseArrow ();
			 controll.instance.pausedis.gameObject.gameObject.SetActive(false);
			 challenge_Controll.instances.pausebutton.gameObject.gameObject.SetActive(false);
			 controll.instance.powerup.gameObject.SetActive(false);
			 challenge_Controll.instances.powerup.gameObject.SetActive(false);
			 controll.instance.changelayer(1);
			 if(chanllge==true)
			{
				if(BoardScore.instances._arrowmultiplier==2)
				{
					challenge_Controll.instances._arrow2XCount = challenge_Controll.instances._arrow2XCount+1 ;
				}
				if(BoardScore.instances._arrowmultiplier==4)
				{
					challenge_Controll.instances._arrow4XCount = challenge_Controll.instances._arrow4XCount+1 ;
				}
				if(BoardScore.instances._arrowmultiplier==6)
				{
					challenge_Controll.instances._arrow6XCount = challenge_Controll.instances._arrow6XCount+1 ;
				}
			}
	 }
	 	
}
 



public void taptoskipactive()
{
	
	        skiptoactive.transform.gameObject.SetActive(true);
			
			skiptoactive.material.color=new Color(1,1,1,1);
}
	
}