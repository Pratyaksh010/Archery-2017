using UnityEngine;
using System.Collections;

public class CamRotations : MonoBehaviour 
{
	
	
     public CircularJoyStick leftJoystick;
     public float senstivityX;
     public float senstivityY;
	 public float falshsenX;
	 public float falshsenY;
	 //public float camintialX;
	// public float camintialY;
	 public static CamRotations instance;
	 public Transform cam;
	 private bool controllStart;
	 private bool challengeStart;
	
	 public bool notrotatecam;// when pause click than not rotate camera
	// Use this for initialization
	void Awake () 
	{      
		   instance=this;
		   cam=transform;
	    // camintialX=transform.eulerAngles.x;
		 //camintialY=transform.eulerAngles.y;
	}
	void Start()
	{
		controllStart=controll.instance.starttarget;
		challengeStart=challenge_Controll.instances.starttargetChallenge;
	}

void Update () 
	{
           if( Application.platform==RuntimePlatform.Android && notrotatecam==false)
		   {
		   cam.Rotate(-leftJoystick.position.y*senstivityX*Time.deltaTime,leftJoystick.position.x*senstivityY*Time.deltaTime,0);
		   }
		   else{
		   if( (controll.instance.starttarget==true||challenge_Controll.instances.starttargetChallenge==true)&&FPSControls.instance.isHeld==true&&notrotatecam==false)
		   {
	       cam.Rotate(-Input.GetAxis("Mouse Y")*falshsenX*Time.deltaTime,Input.GetAxis("Mouse X")*falshsenY*Time.deltaTime,0);
		   }
		}
		   
           cam.eulerAngles=new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,0);
     }
}
