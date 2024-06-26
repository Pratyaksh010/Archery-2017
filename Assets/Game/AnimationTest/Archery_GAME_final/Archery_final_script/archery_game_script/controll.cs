using UnityEngine;
using System.Collections;

public class controll : MonoBehaviour 
{
	public GameObject _windtext ;
    public GameObject _winddirection ;
    public GameObject _windspeedtext ;
	///GameObject mIntermediateObj;
	public DestroyArrowparrent destroyArrowscript;
	
	public gamegui_play gameguiscript;
	//public archerygameplay archerygamescript;
	public Transform gameguiObject;
	
	public  bool gamestart;
	
	public bool stay;
	
	public int maxsetsize;
	
	public static controll instance;
	
	public int noofarrow;
	
	public int numberofset;
	
	public bool destroy;
	
	public bool controllwork;
	
	public int arrowlimit;
	
	public notDestroy notdesScript;
	
	public store_currentStatus store_currentStatusScript;
	
	public Transform notdes;
	
	public targetboarddistance targetseript;
	
	public float veloc;
	
	public float maxdistance;
	
	private RotationLimit[] rtLimit;
	///public Transform cam;
	public float camvelocitymuli;
	
	public int posnum;
	
	public rotatewind rotatewindscript;
	
	public Transform windobject;
	
	public float camfield;
	
	public float windmagnitude;
	//public int currentscore;
	public float windmultipler;
	
	public int countsetscore;
	
	public bool starttarget;
	
	public int state;
	
	public bool outdoor;
	
	public bool resetbutton;
	
	public Transform ground;
	
	public MirrorReflection reflection;

	public float gravity0Y;
	
	public float gravity1Y;
	
	public float gravity2Y;
	
	public float gravity3Y;
	
	public float rotationlimitmaxX0;
	
	public float rotationlimitminX0;
	
	public float rotationlimitminY0;
	
	public float rotationlimitmaxY0;
	
	public float rotationlimitmax1;
	
	public float rotationlimitminX1;
	
	public float rotationlimitminY1;
	
	public float rotationlimitmaxY1;
	
	public float rotationlimitmaxX2;
	
	public float rotationlimitminX2;
	
	public float rotationlimitminY2;
	
	public float rotationlimitmaxY2;
	
	public float rotationlimitmaxX3;
	
	public float rotationlimitminX3;
	
	public float rotationlimitminY3;
	
	public float rotationlimitmaxY3;
	
	public int eachsetnoofarrow;
	
	public int maxnuSet;//4
	
	public float[] distance;
	
	public enemy_score enemyScript;
	
	public int enemyScoresum;//
	
	public bool challenge_mode;/// <summary>
	
	public bool pause;
	
	public flashcontrolling flsahscript;
	
	public Joystick joystickscript;
	
	public GameObject joy;
	
	public CamRotations camrotaScript;
	
	public GameObject maincam;
	
	public int firstendsum;
	
	public int secondendsum;
	
	public int thirdendsum;
	
	public int fourendsum;
	
	public int totalsum;
	
	public Transform screenMa;
	
	public ScreenManager screenMaScript;
	
	public bool showend1;
	
	public bool showend2;
	
	public bool showend3;
	
	public bool showend4;
	
	public bool gameovercom;
	
	public Transform pausedis;// when realse arrow than pause disable
	
	public Transform timeshowobject;
	
	public Transform showscore;
	
	public Transform showarrow;
	
	public GUIText windvalue;
	
	public Transform windvalueObject;
	

	public Transform playerscoreObject;
	
	public Transform aiscoreObject;
	
	public float firsttypegra;
	
	public float secondtypegra;
	
	public float thirdtypegra;
	
	public Transform powerup;
	
	public Transform secondpowerup;
	
	public bool _checkhandshow;
	
	public bool _startjoystick;
	
	public bool _chekshowlabel;
	public float Timeshowlabel;
	public float joystickgentime;
	public bool _joystickfirsttimecreate;
	//public GUITexture 
	//public SpeedThumb speedThumbscript;
	//public Transform speedobject;
	///public float scoreshowtime;
	/// Awake this instance.
	/// </summary>/// <summary>
	/// Awake this instance.
	/// </summary>/// <summary>
	/// Awake this instance.
	/// </summary>/// <summary>
	/// Awake this instance.
	/// </summary>//
	// Use this for initialization
	void Awake() 
	{		
	    instance=this;
		 Timeshowlabel=Time.time;
		
	    destroyArrowscript=gameObject.transform.GetComponent("DestroyArrowparrent")as DestroyArrowparrent;
		//archerygamescript=gameObject.transform.GetComponent("archerygameplay")as archerygameplay;
		gameguiscript=gameguiObject.transform.GetComponent("gamegui_play")as gamegui_play;
		
		notdesScript=GameObject.Find("Nondestroy").GetComponent("notDestroy")as notDestroy;
		//addAudio.instances.
		//GameObject s1=GameObject.Find("Nondestroy")as GameObject;
		store_currentStatusScript = GameObject.Find("Nondestroy").GetComponent("store_currentStatus")as store_currentStatus;
		store_currentStatusScript.resetscene=store_currentStatusScript.currentscene;
		challenge_mode=notdesScript.checkchallengemode;
			
		targetseript=gameObject.GetComponent("targetboarddistance")as targetboarddistance;
		
		enemyScript=gameObject.GetComponent("enemy_score")as enemy_score;
		
		flsahscript=gameObject.GetComponent("flashcontrolling")as flashcontrolling;
		
		joystickscript=joy.GetComponent("Joystick")as Joystick;
		
		camrotaScript=maincam.GetComponent("CamRotations")as CamRotations;
		
		screenMaScript=screenMa.gameObject.GetComponent("ScreenManager")as ScreenManager;
		
		//speedThumbscript=speedobject.GetComponent("SpeedThumb")as 
		
		firsttypegra=store_currentStatus.instances.first_typeGravity;
		
		secondtypegra=store_currentStatus.instances.second_typeGravity;
		
		thirdtypegra=store_currentStatus.instances.third_typeGravity;
		if(outdoor==false&&challenge_mode==false)
		{
			audioManager.instances._bgsound.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[1];
			audioManager.instances._bgsound.volume=.85f;
		}
		if(outdoor==true&&challenge_mode==false)
		{
			audioManager.instances._bgsound.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[2];
		audioManager.instances._bgsound.volume=.80f;
		}
		if(outdoor==false&&challenge_mode==true)
		{
			audioManager.instances._bgsound.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[25];
			audioManager.instances._bgsound.volume=.85f;
		}
		if(outdoor==true&&challenge_mode==true)
		{
			audioManager.instances._bgsound.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[25];
		    audioManager.instances._challengeback.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[26];
			audioManager.instances._challengeback.volume=.80f;
			audioManager.instances._challengesoundplay();
		   audioManager.instances._bgsound.volume=.85f;
		}
		
		audioManager.instances.playbackgroundsound();
		if(outdoor==true&& challenge_mode==false)
		
		{
		     
			 targetseript.Settargetboard(store_currentStatusScript.currentdistances);
			
			   
			 timeshowobject.gameObject.SetActive(false);
			
			 showscore.gameObject.SetActive(false);
			
			 showarrow.gameObject.SetActive(false);
			
			playerscoreObject.gameObject.SetActive(true);
			
			aiscoreObject.gameObject.SetActive(true);
		
			
		}
		
		
		if(outdoor==false&& challenge_mode==false)
		
		{
			
			targetseript.Settargetboard(0);
			timeshowobject.gameObject.SetActive(false);
			showscore.gameObject.SetActive(false);
			showarrow.gameObject.SetActive(false);
		}
		
		//gameguiscript.showlabeltext();
		
		rtLimit=(RotationLimit[])FindObjectsOfType(typeof(RotationLimit));
		
		posnum=targetseript.checklimit;
		
		rotatewindscript=windobject.transform.gameObject.GetComponent("rotatewind")as rotatewind;
	    
		if(Application.platform==RuntimePlatform.Android && outdoor==false&&challenge_mode==false)
		
		{
			
			reflection=ground.GetComponent("MirrorReflection")as MirrorReflection;
			
			reflection.enabled=true;
		}
		
		if(outdoor==false)
		
		{
			
			// camfield=10f;
			/// Physics.gravity=new Vector3 (0f,-3f,0f);
		
		}
	    if(outdoor==false)
			
		{
			   // rtLimit[0].max=1.85f;
			    
				//rtLimit[0].min=-1.6f;
		        
				//rtLimit[1].max=1.3f;
		        
				//rtLimit[1].min=-2.3f;
			    rtLimit[0].max=rotationlimitmaxY0;//-.48f;
			    
				rtLimit[0].min=rotationlimitminY0;//-3.0f;
		        
				rtLimit[1].max=rotationlimitmaxX0;//1.0f;
		        
				rtLimit[1].min=rotationlimitminX0;//-1.6f;
			    
				camvelocitymuli=(1f/1.2f);
		   	    
				camfield=8f;
			   // Physics.gravity=new Vector3 (0,-2.8f,0f);
				Physics.gravity=new Vector3(0f,gravity0Y,0f);
		}
		
		if(outdoor==true&& challenge_mode==false)
		
		{
		  
			if(targetseript.checklimit==0)
		  
			{
			    state=0;
			   
				rtLimit[0].max=rotationlimitmaxY0;//-.48f;
			    
				rtLimit[0].min=rotationlimitminY0;//-3.0f;
		        
				rtLimit[1].max=rotationlimitmaxX0;//1.0f;
		        
				rtLimit[1].min=rotationlimitminX0;//-1.6f;
			    
				camvelocitymuli=(1f/1.2f);
		   	    
				camfield=8f;
			   // Physics.gravity=new Vector3 (0,-2.8f,0f);
				Physics.gravity=new Vector3(0f,gravity0Y,0f);
		  //   Time.fixedDeltaTime=.01f;
			//targetinY=1;
		  }
		 
		  if(targetseript.checklimit==1)
		  {
			 state=1;
			 
			 rtLimit[0].max=rotationlimitmaxY1;
			 
			 rtLimit[0].min=rotationlimitminY1;
			 
			 rtLimit[1].max=rotationlimitmax1;
			 
			 rtLimit[1].min=rotationlimitminX1;
		     
			 camvelocitymuli=(1f/1.2f);
			 
			 camvelocitymuli=.955f;
			 
			 camfield=8f;
		
			 //Physics.gravity=new Vector3(0f,gravity1Y,0f);
			 float y1= (((-1.55f-(-2.8f))/(distance[1]-distance[0]))*(10f))+(-2.8f);//(distance[1]-distance[0])
			 Physics.gravity=new Vector3 (0,y1,0f);//-2.3f
		  }
		  
		  if(targetseript.checklimit==2)
		  
		{   
			 state=2;
		     
			 rtLimit[0].max=rotationlimitmaxY2;//-1.255f;
			 
			 rtLimit[0].min=rotationlimitminY2;//-2.5f;
			 
			 rtLimit[1].max=rotationlimitmaxX2;//.45f;
			 
			 rtLimit[1].min=rotationlimitminX2;//-.90f;
			 
			 camvelocitymuli=1.05f;
		     
			 camfield=7f;
			// Physics.gravity=new Vector3 (0,-1.7f,0f); gravity2Y
			  Physics.gravity=new Vector3 (0f,gravity2Y,0f);
			 //float y2= (((-.65f-(-2.8f))/(distance[2]-distance[0]))*(20f))+(-2.8f);//(distance[2]-distance[0])
			 //Physics.gravity=new Vector3 (0,y2,0f);
			//// Physics.gravity=new Vector3 (0,-1.3f,0f);
		  }
			
		  if(targetseript.checklimit==3)
		  
		{
			
			state=2;
		     
			rtLimit[0].max=rotationlimitmaxY3;//-1.255f;
			
			rtLimit[0].min=rotationlimitminY3;//-2.5f;
			
			rtLimit[1].max=rotationlimitmaxX3;//.45f;
			
			rtLimit[1].min=rotationlimitminX3;//-.90f;
			
			camvelocitymuli=.9f;
		    
			camfield=6f;
			//Physics.gravity=new Vector3 (0,-1.7f,0f);
			Physics.gravity=new Vector3 (0f,gravity3Y,0f);
			
		  }
		
	  }
	  
	 
		
		
	}
	
	
void Start()
		
	{
		
	}
	// Update is called once per frame
void Update () 
{
		if(_startjoystick==true&&Time.time-joystickgentime>=.3f&&_joystickfirsttimecreate==false)
		{
			_joystickfirsttimecreate=true;
		}
		
	   if(Time.time-Timeshowlabel>.5f&&_chekshowlabel==false)
		{
			gameguiscript.showlabeltext();
			_chekshowlabel=true;
			
		}
		
	if(pause==true)
	{
		if(Application.platform!=RuntimePlatform.Android)
			{
		flsahscript.pauseone=true;
			}
			
		if(Application.platform==RuntimePlatform.Android)
				
	      {
		     joystickscript.pauseone=true;
				
					
		  }
			
	     	camrotaScript.notrotatecam=true;
			
	
	}
		
	if(pause==false)
	{
		if(Application.platform!=RuntimePlatform.Android)
			{
		flsahscript.pauseone=false;
			}	
		if(Application.platform==RuntimePlatform.Android)
				
	      {
		     joystickscript.pauseone=false;
				
		  }
		camrotaScript.notrotatecam=false;
	}
	   	
	if(destroy==true&&challenge_mode==false)//&& _checkhandshow==false)
		
	{
		
		
	  if(outdoor==true)
	
  {			
		noofarrow=noofarrow+1;
		
			
		if(noofarrow<arrowlimit)
			
		{
			destroyArrowscript.recreate();
			
			enemyScript.enemY_sco(gameguiscript.total[countsetscore-1]/enemy_score.instances._eneMyScoremultiplier);
			
			starttarget=true;
				
			rotatewindscript.onetime=false;
		}
			
		
		if(noofarrow>eachsetnoofarrow)//3
			
	   {
				
		 gameguiscript.setno=gameguiscript.setno+1;
				
				
		if(gameguiscript.setno<4)
				
		{
				    
			gameguiscript.firsttimestart=true;
					
			gameguiscript.showlabeltext();
				//_checkhandshow=true;
				
		}
				
	  
		if(gameguiscript.setno==maxnuSet&&outdoor==true)
				
		{
					
			gameguiscript.setcompl();
				
		}
				
	}
				
}
		//destroy=false;
				
		
  if(outdoor==false)
{
	destroyArrowscript.recreate();	
	starttarget=true;
				
	rotatewindscript.onetime=false;

}

	destroy=false;		
		
}	


  
	
}
	
public void gameplaystart()
	
{
		
  destroyArrowscript.recreate();
		
  flsahscript.gameplaystart=true;
		
  rotatewindscript.showwind=true;
		
  starttarget=true;
		
  noofarrow=noofarrow+1;
		
  rotatewindscript.onetime=false;
	    
  resetbutton=true;
		
 _startjoystick=true;
  joystickgentime=Time.time;
  gamegui_play.instances.changelevel();
}
void OnGUI()
	
{
		
   if(outdoor==true&&challenge_mode==false)
		
   {
			
			if(windobject.GetComponent<Renderer>().enabled==false)
	
				{
					windvalueObject.gameObject.SetActive(false);
				}
				if(windobject.GetComponent<Renderer>().enabled==true)
				{
				   windvalueObject.gameObject.SetActive(true);
				 
	               windvalue.text=""+(windmultipler).ToString("F2");
				
					
				}
	
   }
}

public void showscoreset(int currentsc) // this function show the sum of score
	
{
	  
	if(outdoor==true)
   
	{
	   gameguiscript.total[countsetscore]=currentsc;
	  
	   gameguiscript.SUM= gameguiscript.SUM+ gameguiscript.total[countsetscore];
	
	  if(countsetscore<=2)
		
		{
			firstendsum=firstendsum+currentsc;
		    totalsum=gameguiscript.SUM;
			showend1=true;
		}
		if(countsetscore>2&&countsetscore<=5)
		
		{
		  secondendsum=secondendsum+currentsc;
		  totalsum=gameguiscript.SUM;
			showend2=true;
			
		}
		if(countsetscore>5&&countsetscore<=8)
		
		{
		  thirdendsum=thirdendsum+currentsc;
		  totalsum=gameguiscript.SUM;
			
			showend3=true;
		}
		if(countsetscore>8&&countsetscore<=11)
		
		{
		 fourendsum=fourendsum+currentsc;	
		 totalsum=gameguiscript.SUM;
			
	     showend4=true;
		}
	     
	  
		countsetscore=countsetscore+1;
			
		}
	 
}
	
	
	public void setgravity(int setvalue)
	{
		  if(outdoor==false)	
		{
		   if(setvalue==0)
		   
		   {
			 Physics.gravity=new Vector3 (0f,gravity0Y,0f);
		   }
		  
		   if(setvalue==1)
		  
		   {
			Physics.gravity=new Vector3 (0f,-3f,0f);//+firsttypegra
		   }
		  
		   if(setvalue==2)
		  
		   {
			Physics.gravity=new Vector3 (0f,-3f,0f);//+secondtypegra
		   }
		  
		   if(setvalue==3)
		   {
			Physics.gravity=new Vector3 (0f,-3f,0f);//+thirdtypegra
		   }
		  
		}
		
	    if(outdoor==true&&challenge_mode==false)
		{ 
			if(setvalue==0)
		   
		   {
			if(targetseript.checklimit==0)
				{
			       Physics.gravity=new Vector3 (0f,gravity0Y,0f);
				}
		    if(targetseript.checklimit==1)
				{
			       Physics.gravity=new Vector3 (0f,gravity1Y,0f);//
				}
			if(targetseript.checklimit==2)
				{
			       Physics.gravity=new Vector3 (0f,gravity2Y,0f);//
				}
			if(targetseript.checklimit==3)
				{
			       Physics.gravity=new Vector3 (0f,gravity3Y,0f);//
				}
		   }
		  
		   if(setvalue==1)
		  
		   {
			if(targetseript.checklimit==0)
				{
			       Physics.gravity=new Vector3 (0f,gravity0Y+firsttypegra,0f);
				}
		    if(targetseript.checklimit==1)
				{
			       Physics.gravity=new Vector3 (0f,gravity1Y+firsttypegra,0f);
				}
			if(targetseript.checklimit==2)
				{
			       Physics.gravity=new Vector3 (0f,gravity2Y+firsttypegra,0f);
				}
			if(targetseript.checklimit==3)
				{
			       Physics.gravity=new Vector3 (0f,gravity3Y+firsttypegra,0f);
				}
		   }
		  
		   if(setvalue==2)
		  
		   {
			if(targetseript.checklimit==0)
				{
			       Physics.gravity=new Vector3 (0f,gravity0Y+secondtypegra,0f);
				}
		    if(targetseript.checklimit==1)
				{
			       Physics.gravity=new Vector3 (0f,gravity1Y+secondtypegra,0f);
				}
			if(targetseript.checklimit==2)
				{
			       Physics.gravity=new Vector3 (0f,gravity2Y+secondtypegra,0f);
				}
			if(targetseript.checklimit==3)
				{
			       Physics.gravity=new Vector3 (0f,gravity3Y+secondtypegra,0f);
				}
		   }
		  
		   if(setvalue==3)
		   {
			if(targetseript.checklimit==0)
				{
			       Physics.gravity=new Vector3 (0f,gravity0Y+thirdtypegra,0f);
				}
		    if(targetseript.checklimit==1)
				{
			       Physics.gravity=new Vector3 (0f,gravity1Y+thirdtypegra,0f);
				}
			if(targetseript.checklimit==2)
				{
			       Physics.gravity=new Vector3 (0f,gravity2Y+thirdtypegra,0f);
				}
			if(targetseript.checklimit==3)
				{
			       Physics.gravity=new Vector3 (0f,gravity3Y+thirdtypegra,0f);
				}
		   }
		  
		}
		
		
		
	}
	
public void changelayer(int i )
	{
		if(i == 0 && _windtext!=null&&_winddirection!=null&&_windspeedtext!=null)
		{
			
	        _windtext.transform.gameObject.layer = 0 ; 
            _winddirection.transform.gameObject.layer = 0 ; 
	        _windspeedtext.transform.gameObject.layer = 13 ; 
	
		}
		if(i == 1 && _windtext!=null&&_winddirection!=null&&_windspeedtext!=null)
		{
			 _windtext.transform.gameObject.layer = 31 ; 
            _winddirection.transform.gameObject.layer = 31 ; 
	        _windspeedtext.transform.gameObject.layer = 31 ; 
		}
	}
	
}
