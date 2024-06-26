using UnityEngine;
using System.Collections;

public class challenge_Controll : MonoBehaviour 
{
	public int _arrow2XCount ;
	public int _arrow4XCount ;
	public int _arrow6XCount ;
	public int _noOffhitBullEyes  ;
	
	public DestroyArrowparrent destroyArrowChallengescript;
	
	public notDestroy notdestroyScript;
	
	private int selectChallenge;
	
	public bool destroychallenge;// destroy arrow and recreate ;
	
	public challenge_mode_gui challenge_mode_guiscript;
	
	public Transform challenge_modegamegui;
	
	public static challenge_Controll instances;
	
	//public Transform windobject;
	
	//public rotatewind rotatewindChallengescript;
	
	public int numberOfArrow;
	
	public int firstChallengeMaxArrow;
	
	public int currentChallengeNumber;
	
	public float camfield1=10f;
	
	public bool starttargetChallenge;
	
	public int noArrow=12;
	
	public bool showgui;
	
	public bool resetbutton;
	
	public Time_Show time_showScript;
	
	public int challege6timelimit;
	
	public int challenge6maxscore;
	
	public int challenge1maxscore;
	
	public bool stopcontrolling;
	
	public flashcontrolling flashcontrollingscript;
	
	public int challenge8MaxArrow;  // challenge 6 show the max number of arrow
	
	public int challenge8MaxScore;
	
	public targetboarddistance targetChallengeScript;
	
	public float challengeconVel;
	
	private RotationLimit[] rtLimit1;
	
	public float gravity0Y1;
	
	public float gravity1Y1;
	
	public float gravity2Y1;
	
	public float gravity3Y1;
	
	public float rotationlimitmaxX01;
	
	public float rotationlimitminX01;
	
	public float rotationlimitminY01;
	
	public float rotationlimitmaxY01;
	
	public float rotationlimitmax11;
	
	public float rotationlimitminX11;
	
	public float rotationlimitminY11;
	
	public float rotationlimitmaxY11;
	
	public float rotationlimitmaxX21;
	
	public float rotationlimitminX21;
	
	public float rotationlimitminY21;
	
	public float rotationlimitmaxY21;
	
	public float rotationlimitmaxX31;
	
	public float rotationlimitminX31;
	
	public float rotationlimitminY31;
	
	public float rotationlimitmaxY31;
	
	public float camvelocitymuli1;
	
	public float camfieldchallenge=8f;   // change the field of view according to distance
	
	public int challengeState;
	
	public int challenge2maxscore;
	
	public int currentcountdowntime;//  assign according challenge time in Time show script
	
	public int challenge2Timelimit;
	
	public float challengewindmagnitude;
	//public int currentscore;
	public float challengewindmultipler;
	
	public Transform challegeWindObject;
	
	public int challenge3maxscore;//  show challenge 3 max score
	
	public int[] challengenumberofarrow;
	
	public int thirdChallengeMaxArrow;// show third challenge max arrow
	
	public rotatewind rotatewindscript;// according select change the wind value
	
	public int challenge5maxscore;//48
	
	public int fiveChallengeMaxArrow;
	
	public int fourChallengeMaxArrow;
	
	public int nineChallengeMaxArrow;
	
	public int[] challengeScoreSave;// save the score each hit arrow
	
	public int challengeScoreSaveSize;// create the size according challenge
	
	public int i;
	//targetseript=gameObject.GetComponent("targetboarddistance")as targetboarddistance;
	
	public bool pause;
	
	
	public Transform pausebutton;
	
	//public flashcontrolling flsahscript;
	
	public SpeedThumb speedThumbscript;
	
	public Transform joy;
	
	public CircularJoyStick cirjoystick;
	
	public Transform circu;
	
	public Transform showtime;  // enable or disable time according select challenge
	
	public Transform showscore; // according selected challenge showscore object disable or enable
	
	public Transform showarrow;// according selected challenge showarrow object disable or enable
	
	public GUIText windvalue;
	
	public Transform cam;
	
	public CamRotations camro;
	
	public Transform windvalueObject;
	
	//public controll controlscript;
	public Transform powerup;
	
	public Transform secondpowerup;
	
	//public Transform Aiscoreprefab;
	
	public bool outdoor;
	
	
	public Transform playerscoreObject;// this object show playerscore
	
	public Transform aiscoreObject;// this object show aiscore
	
	public int challenge7noarrow=0;
	
	public int _challenge7maxnooffarrow;
	
	public int setno;
	
	public bool setcomplet;
	
	public int enemyScoresum;
	
	public Transform bow;
	public float joysticktimeset;
	public bool _joystickfirsttimecreate;
	public enum ArcheryChallenge     // create ArcheryChallenge enum
 { 
		
	challenge1 = 0,
	challenge2,
	challenge3,
	challenge4,
	challenge5,
	challenge6,
	challenge7,
	challenge8,
	challenge9,
	challenge10,
	challenge11,
	challenge12,
	challenge13,
	challenge14,
	challenge15,
    challenge16
 
 }
	
	 public ArcheryChallenge currentChallenge;
	 public float first_typegra;
	 public float second_typegra;
	 public float third_typegra;
	
	 public int countsetscore;
	
	 public enemy_score enemyScript;
	
	 public bool showend1;
	
	 public bool showend2;
	
	 public bool showend3;
	
	 public bool showend4;
	
	 public int firstendsum;
	
	 public int secondendsum;
	
	public int thirdendsum;
	
	public int fourendsum;
	
	public int totalsum;
	
	public Transform objec;
	
	public Transform recurebow;
	
	public bool _restartjoystick;
	
	public bool _callshowlabel;
	
	public float _callshowtime;
	
	public int _tenChallengeMaxScore ;
	
	public int _tenMAxArrow ;
	
	public int _challenge11MaxArrow ;
	
	public int _elevenChallengeMaxScore ;
	
	public int _tweleMaxArrow ;
	
	public int _thirteenMaxArrow ;
	
	public int _thirteenMaxScore ;
	
	public int _fourteenMaxArrow ;
	
	public int _fourteenMaxScore ;
	
	public int _fifteenMaxArrow ;
	
	public int _sixteenMaxArrow ;
	
	public int _sixteenMaxScore ;
	
	public bool checkChallenge ;
	void Awake()
	
	{
		instances=this;
		_callshowtime=Time.time;
		destroyArrowChallengescript=gameObject.transform.GetComponent("DestroyArrowparrent")as DestroyArrowparrent;
		
		
		//rotatewindChallengescript=windobject.transform.gameObject.GetComponent("rotatewind")as rotatewind;
		
		time_showScript=gameObject.GetComponent("Time_Show")as Time_Show;
		
		flashcontrollingscript=gameObject.GetComponent("flashcontrolling")as flashcontrolling;
		
		notdestroyScript=GameObject.Find("Nondestroy").GetComponent("notDestroy")as notDestroy;// access the first scene object;
		
		rotatewindscript=challegeWindObject.transform.gameObject.GetComponent("rotatewind")as rotatewind;
		
		speedThumbscript=joy.gameObject.GetComponent("SpeedThumb")as SpeedThumb;
		
		cirjoystick=circu.gameObject.GetComponent("CircularJoyStick")as CircularJoyStick;
		
		camro=cam.GetComponent("CamRotations")as CamRotations;
		
		challenge_mode_guiscript=challenge_modegamegui.transform.GetComponent("challenge_mode_gui")as challenge_mode_gui;
		//store_currentStatusScript.resetscene=store_currentStatusScript.currentscene;
		//flsahscript=gameObject.GetComponent("flashcontrolling")as flashcontrolling;
		
		//joystickscript=joy.GetComponent("Joystick")as Joystick;
		
		//camrotaScript=maincam.GetComponent("CamRotations")as CamRotations;
		 first_typegra=store_currentStatus.instances.first_typeGravity;
		 second_typegra=store_currentStatus.instances.second_typeGravity;
		 third_typegra=store_currentStatus.instances.third_typeGravity;
		checkChallenge = notdestroyScript.checkchallengemode ;
		if(notdestroyScript.checkchallengemode==true)
		
		{
			showgui=notdestroyScript.checkchallengemode;
			selectChallenge=notdestroyScript.challengeSelect;
		    currentChallengeNumber =notdestroyScript.challengeSelect;
			targetChallengeScript=gameObject.GetComponent("targetboarddistance")as targetboarddistance;
			//targetChallengeScript=gameObject.GetComponent("targetboarddistance")as targetboarddistance;
		    store_currentStatus.instances._rewards();
		    //targetChallengeScript.Settargetboard(notdestroyScript.targetdistance);
		
		switch ( selectChallenge )
		{
		    case 1:
			
			currentChallenge=ArcheryChallenge.challenge1;
			
			noArrow=12 ;
			firstChallengeMaxArrow = noArrow ;
				//challengenumberofarrow[0];//12
			targetChallengeScript.SettargetboardChallenge(notdestroyScript.targetdistance);
			showtime.gameObject.SetActive(false);  // enable or disable time according select challenge
			//targetChallengeScript.SettargetboardChallenge(0);
			rotatewindscript.minmagtude1=2f;
			rotatewindscript.maxmagtude1=4f;
			showscore.gameObject.SetActive(true);
			showarrow.gameObject.SetActive(true);
			
			
			break;
			
		    case 2:
		    
			currentChallenge=ArcheryChallenge.challenge2;
			
		    currentcountdowntime=challenge2Timelimit;
		 
		    targetChallengeScript.SettargetboardChallenge(notdestroyScript.targetdistance);
				
			rotatewindscript.minmagtude1=1f;
				
			rotatewindscript.maxmagtude1=3f;
				
			showtime.gameObject.SetActive(true);
				
			showscore.gameObject.SetActive(true);
				
			showarrow.gameObject.SetActive(false);
			break;
			
		    case 3:
			
			currentChallenge=ArcheryChallenge.challenge3;
				
			noArrow=challengenumberofarrow[1];//10 arrow
				
			targetChallengeScript.SettargetboardChallenge(notdestroyScript.targetdistance);
			
			rotatewindscript.minmagtude1=2f;
				
			rotatewindscript.maxmagtude1=4f;
				
			 showtime.gameObject.SetActive(false);
				
			showscore.gameObject.SetActive(true);
				
			showarrow.gameObject.SetActive(true);
			break;
			
		    case 4:
			
			currentChallenge=ArcheryChallenge.challenge4;
				
			noArrow=challengenumberofarrow[4];
			
			targetChallengeScript.SettargetboardChallenge(notdestroyScript.targetdistance);
				
			rotatewindscript.minmagtude1=1f;
				
			rotatewindscript.maxmagtude1=3f;
				
			challengeScoreSaveSize=4;
				
			 showtime.gameObject.SetActive(false);
				
			 showscore.gameObject.SetActive(true);
				
			showarrow.gameObject.SetActive(true);
			break;
			
		    case 5:
		    
			currentChallenge=ArcheryChallenge.challenge5;
			
			noArrow=challengenumberofarrow[3];
			
			targetChallengeScript.SettargetboardChallenge(notdestroyScript.targetdistance);
				
			rotatewindscript.minmagtude1=1f;
				
			rotatewindscript.maxmagtude1=3f;
				
			 showtime.gameObject.SetActive(false);
				
			showscore.gameObject.SetActive(true);
				
			showarrow.gameObject.SetActive(true);
			
			break;
			
		    case 6:
			
			currentChallenge=ArcheryChallenge.challenge6;
			
			currentcountdowntime=challege6timelimit;
			showtime.gameObject.SetActive(true);
				
			showscore.gameObject.SetActive(true);
				
			showarrow.gameObject.SetActive(false);
			targetChallengeScript.SettargetboardChallenge(notdestroyScript.targetdistance);
			break;
			
			case 7:
			
			currentChallenge=ArcheryChallenge.challenge7;
			
			showtime.gameObject.SetActive(false);
				
			showscore.gameObject.SetActive(false);
				
			showarrow.gameObject.SetActive(false);
				
			playerscoreObject.gameObject.SetActive(true);
				
			aiscoreObject.gameObject.SetActive(true);
				
		   
				
			enemyScript=gameObject.GetComponent("enemy_score")as enemy_score;
			targetChallengeScript.SettargetboardChallenge(notdestroyScript.targetdistance);
			rotatewindscript.minmagtude1=2f;
				
			rotatewindscript.maxmagtude1=4f;
				
			break;
			
		    case 8:
		    
			currentChallenge=ArcheryChallenge.challenge8;
			noArrow=challengenumberofarrow[2];
				
			 showtime.gameObject.SetActive(false);
				
			showscore.gameObject.SetActive(true);
				
			showarrow.gameObject.SetActive(true);
			//targetChallengeScript.SettargetboardChallenge(0);
			break;
			
		    case 9:
			
			currentChallenge=ArcheryChallenge.challenge9;
		    
			noArrow=challengenumberofarrow[5];
				
			targetChallengeScript.SettargetboardChallenge(notdestroyScript.targetdistance);
				
			rotatewindscript.minmagtude1=2f;
				
			rotatewindscript.maxmagtude1=4f;
				
			challengeScoreSaveSize=8;
				
			 showtime.gameObject.SetActive(false);
				
			 showscore.gameObject.SetActive(true);
				
			showarrow.gameObject.SetActive(true);
			break;
				
			case 10:
				 
				currentChallenge=ArcheryChallenge.challenge10 ;
				
			    noArrow=challengenumberofarrow[6];//10 arrow
				
			    targetChallengeScript.SettargetboardChallenge(notdestroyScript.targetdistance);
			
			    rotatewindscript.minmagtude1=2f;
				
			    rotatewindscript.maxmagtude1=4f;
				
			    showtime.gameObject.SetActive(false);
				
			    showscore.gameObject.SetActive(true);
				
			    showarrow.gameObject.SetActive(true);
			break;
				
			case 11:
				currentChallenge=ArcheryChallenge.challenge11 ;
				noArrow=challengenumberofarrow[7];//10 arrow
			   _challenge11MaxArrow = noArrow ;
				targetChallengeScript.SettargetboardChallenge(notdestroyScript.targetdistance);
				rotatewindscript.minmagtude1=2f;
				rotatewindscript.maxmagtude1=4f;
			    showtime.gameObject.SetActive(false);
			    showscore.gameObject.SetActive(true);
			    showarrow.gameObject.SetActive(true);
				
			break;
				
			case 12:
				
				currentChallenge=ArcheryChallenge.challenge12 ;
				noArrow=challengenumberofarrow[8];//10 arrow
			   _tweleMaxArrow = noArrow ;
				targetChallengeScript.SettargetboardChallenge(notdestroyScript.targetdistance);
				rotatewindscript.minmagtude1=2f;
				rotatewindscript.maxmagtude1=4f;
				showtime.gameObject.SetActive(false);
				showscore.gameObject.SetActive(true);
				showarrow.gameObject.SetActive(true);
			break;
				
			case 13:
				currentChallenge=ArcheryChallenge.challenge13 ;
				noArrow=challengenumberofarrow[9];
			   _thirteenMaxArrow = noArrow ;
				targetChallengeScript.SettargetboardChallenge(notdestroyScript.targetdistance);
				rotatewindscript.minmagtude1=2f;
				rotatewindscript.maxmagtude1=4f;
				showtime.gameObject.SetActive(false);
				showscore.gameObject.SetActive(true);
				showarrow.gameObject.SetActive(true);
			break ;
			case 14:
				currentChallenge=ArcheryChallenge.challenge14 ;
				noArrow=challengenumberofarrow[10];
			   _fourteenMaxArrow = noArrow ;
				targetChallengeScript.SettargetboardChallenge(notdestroyScript.targetdistance);
				rotatewindscript.minmagtude1=2f;
				rotatewindscript.maxmagtude1=4f;
				showtime.gameObject.SetActive(false);
				showscore.gameObject.SetActive(true);
				showarrow.gameObject.SetActive(true);
			break ;
			case 15:
				currentChallenge=ArcheryChallenge.challenge15 ;
				noArrow=challengenumberofarrow[11];
			   _fifteenMaxArrow = noArrow ;
				targetChallengeScript.SettargetboardChallenge(notdestroyScript.targetdistance);
				rotatewindscript.minmagtude1=1f;
				rotatewindscript.maxmagtude1=3f;
				showtime.gameObject.SetActive(false);
				showscore.gameObject.SetActive(true);
				showarrow.gameObject.SetActive(true);
			break ;
			case 16:
				currentChallenge=ArcheryChallenge.challenge16 ;
				noArrow=challengenumberofarrow[12];
			    _sixteenMaxArrow= noArrow ;
				targetChallengeScript.SettargetboardChallenge(notdestroyScript.targetdistance);
				rotatewindscript.minmagtude1=1f;
				rotatewindscript.maxmagtude1=3f;
				showtime.gameObject.SetActive(false);
				showscore.gameObject.SetActive(true);
				showarrow.gameObject.SetActive(true);
			break ;
			
			}
			
			
			// assign the distance according challenge
			if(showscore.gameObject.active==true)
			{
			
				challenge_mode_guiscript.score=GameObject.Find("score").GetComponent<GUIText>();
				
			}
			
			if(showarrow.gameObject.active==true)
			{
			
				challenge_mode_guiscript.numberofarrow=GameObject.Find("playerName1").GetComponent<GUIText>();
				
			}
			
			if(showtime.gameObject.active==true)
			{
				time_showScript.minute=GameObject.Find("minute").GetComponent<GUIText>();
				time_showScript.second=GameObject.Find("second").GetComponent<GUIText>();
			}
			rtLimit1=(RotationLimit[])FindObjectsOfType(typeof(RotationLimit));
			
		
			if(notdestroyScript.checkchallengemode==true)
			{
				
				
				if(outdoor==true&&targetChallengeScript.checklimit==0)
				{
					challengeState=0;
					
					
					
					rtLimit1[0].max=rotationlimitmaxY01;//-.48f;
			    
				    rtLimit1[0].min=rotationlimitminY01;//-3.0f;
		        
				    rtLimit1[1].max=rotationlimitmaxX01;//1.0f;
		        
				    rtLimit1[1].min=rotationlimitminX01;//
					
					camvelocitymuli1=(1f/1.2f);
		   	    
				    camfieldchallenge=8f;
			   // Physics.gravity=new Vector3 (0,-2.8f,0f);
				    Physics.gravity=new Vector3(0f,gravity0Y1,0f);
				}
				  if(targetChallengeScript.checklimit==1)
		        {
				   challengeState=1;
					
			       rtLimit1[0].max=rotationlimitmaxY11;
			 
			       rtLimit1[0].min=rotationlimitminY11;
			 
			       rtLimit1[1].max=rotationlimitmax11;
			 
			       rtLimit1[1].min=rotationlimitminX11;
		     
			       camvelocitymuli1=1f;
			 
			       camfieldchallenge=8f;
		
			       Physics.gravity=new Vector3(0f,gravity1Y1,0f);
			
		        }
				
			   if(targetChallengeScript.checklimit==2)
		  
		        {   
			        challengeState=2;
		     
			        rtLimit1[0].max=rotationlimitmaxY21;//-1.255f;
			 
			        rtLimit1[0].min=rotationlimitminY21;//-2.5f;
			 
			        rtLimit1[1].max=rotationlimitmaxX21;//.45f;
			 
			        rtLimit1[1].min=rotationlimitminX21;//-.90f;
			 
			        camvelocitymuli1=.9f;
		     
			        camfieldchallenge=7f;
			        
					Physics.gravity=new Vector3 (0f,gravity2Y1,0f);
			 
		          }
		          if(targetChallengeScript.checklimit==3)
		  
		          {
			
			        challengeState=3;
		     
			         rtLimit1[0].max=rotationlimitmaxY31;//-1.255f;
			
			         rtLimit1[0].min=rotationlimitminY31;//-2.5f;
			
			         rtLimit1[1].max=rotationlimitmaxX31;//.45f;
			
			         rtLimit1[1].min=rotationlimitminX31;//-.90f;
			
			         camvelocitymuli1=.9f;
		    
			         camfieldchallenge=6f;
			
			         Physics.gravity=new Vector3 (0f,gravity3Y1,0f);
			
		       }
			
			}
	  }
		
	}
	
	

	// Use this for initialization
	void Start () 
	{
		// challenge_mode_guiscript=challenge_modegamegui.transform.GetComponent("challenge_mode_gui")as challenge_mode_gui;
		   
		// challenge_mode_guiscript.showChallengelabeltext();
	   
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		        if(Time.time-joysticktimeset>.3f&&_restartjoystick==true&& _joystickfirsttimecreate==false)
		       {
			      _joystickfirsttimecreate=true;
		       }
	             if(Time.time-_callshowtime>.5f&&_callshowlabel==false)
		        {
			      challenge_mode_guiscript.showChallengelabeltext();
			     _callshowlabel=true;
		       }
		
		          if(currentChallenge==ArcheryChallenge.challenge6||currentChallenge==ArcheryChallenge.challenge2)
		         
		          {
			             if(time_showScript.timecomplete==true)
			             
			             {
				             
				            if(Application.platform!=RuntimePlatform.Android)
				           {
				            flashcontrollingscript.enabled=false;
				           } 
				            if(Application.platform==RuntimePlatform.Android)
				           {
				            
					        speedThumbscript.timestop=true;
					         
					        camro.notrotatecam=true;
					        bow.GetComponent<Renderer>().enabled=false;
					        objec.GetComponent<Renderer>().enabled=false;
					        recurebow.GetComponent<Renderer>().enabled=false;
				           } 
			             }
		           
		           }
	                 
		            
		          if(notdestroyScript.checkchallengemode==true)
		
                   {	
		
		                 if(currentChallenge==ArcheryChallenge.challenge1)
		                      
			             {
			
			                  if(destroychallenge==true)
				                   
				             {
					              numberOfArrow=numberOfArrow+1;
				                  noArrow=noArrow-1;
					              if(numberOfArrow<=firstChallengeMaxArrow)
					              {
						            destroyArrowChallengescript.recreate();
						                    
						             rotatewindscript.onetime=false;
						
					               }
					                    
					                    destroychallenge=false;
					
				               }
			
		                   }
		
		                   if(currentChallenge==ArcheryChallenge.challenge2)
		                   {
			                   
				              
			                    if(destroychallenge==true)
				              
				               {
					                numberOfArrow=numberOfArrow+1;
					                
					               if(time_showScript.timecomplete==false&&time_showScript.showtimestart==true)
					               
					              {
						               
					                   if(time_showScript.restSeconds!=0)
						              
							           destroyArrowChallengescript.recreate();
						                    
						               rotatewindscript.onetime=false;            
						
					              }
					               destroychallenge=false;
				               }
			
		                   }
		
		                   if(currentChallenge==ArcheryChallenge.challenge3)
		                   {
			
				             if(destroychallenge==true)
				                   
				             {
					              numberOfArrow=numberOfArrow+1;
				                  
					              noArrow=noArrow-1;
					              
					             if(numberOfArrow<=thirdChallengeMaxArrow)
					              {
						            destroyArrowChallengescript.recreate();
						                    
						             rotatewindscript.onetime=false;
						
					               }
					                    
					                    destroychallenge=false;
					
				               }
			
			
			
		                    }
		
		                   if(currentChallenge==ArcheryChallenge.challenge4)
		                    {
			
			                     if(destroychallenge==true)
				                   
				               {
					              numberOfArrow=numberOfArrow+1;
				                  
					              noArrow=noArrow-1;
					              
					             if(numberOfArrow<=fourChallengeMaxArrow)
					              {
						            destroyArrowChallengescript.recreate();
						                    
						            rotatewindscript.onetime=false;
						
					               }
					                    
					                    destroychallenge=false;
					
				               }
			
		                    }
		
		                   if(currentChallenge==ArcheryChallenge.challenge5)
		                    {
			
			                    if(destroychallenge==true)
				                   
				               {
					              numberOfArrow=numberOfArrow+1;
				                  
					              noArrow=noArrow-1;
					              
					             if(numberOfArrow<=fiveChallengeMaxArrow)
					              {
						            destroyArrowChallengescript.recreate();
						                    
						             rotatewindscript.onetime=false;
						
					               }
					                    
					                    destroychallenge=false;
					
				               }
			
		                    }
		
		                   if(currentChallenge==ArcheryChallenge.challenge6)
		                    {
			
			                    if(destroychallenge==true)
				                   
				                {
					               numberOfArrow=numberOfArrow+1;
					               
					                noArrow=noArrow-1;
				                  // noArrow=noArrow-1;
					               if(time_showScript.timecomplete==false&&time_showScript.showtimestart==true)
					               {
						              if(time_showScript.restSeconds!=0)
						              
							           destroyArrowChallengescript.recreate();
						                    
						               rotatewindscript.onetime=false;
						                   /// stop the controlling when complete the time
						                     
						                     
					                }
					                    
					                destroychallenge=false;
					
				                 }
			
		                     }
		
			               
			
	                      	if(currentChallenge==ArcheryChallenge.challenge7&&setcomplet==false)
		                      {
				
				
			                    if(destroychallenge==true)
				              {
			                    
					             
			                     challenge7noarrow=challenge7noarrow+1;
				                 
					            if(challenge7noarrow<4)
				               
				                {
					
					               destroyArrowChallengescript.recreate();
					                
				                     
						           enemyScript.enemY_sco(challenge_mode_gui.instances._total[countsetscore-1]/enemy_score.instances._eneMyScoremultiplier);
					               
						           rotatewindscript.onetime=false;
					
				                 }
				                 
					            if( challenge7noarrow>3)
					              {
						
						            //setno=setno+1;
						             challenge_mode_gui.instances.setno= challenge_mode_gui.instances.setno+1;
						        
						             if(challenge_mode_gui.instances.setno<4)
					              {
						             challenge_mode_gui.instances.showlabeltext();
					              }
						
						         if(challenge_mode_gui.instances.setno==4)
					              {
						            setcomplet=true;
							
							        challenge_mode_gui.instances.showResult(currentChallenge);
					              }
				
					            }
					
					            
					              
					
				                  destroychallenge=false;
				               }
				
		                      }
		 
		                     if(currentChallenge==ArcheryChallenge.challenge8)
		                      {
			
			                         if(destroychallenge==true)
				                   
				                    {
					                    numberOfArrow=numberOfArrow+1;
				                  
					                    noArrow=noArrow-1;
					              
					                    if(numberOfArrow<=challenge8MaxArrow)
					                   
					                    {
						           
						                    destroyArrowChallengescript.recreate();
						                    
						                    rotatewindscript.onetime=false;
						
					                     }
					                    
					                    destroychallenge=false;
					
				                   }
			
			
		                       }
		
		                     if(currentChallenge==ArcheryChallenge.challenge9)
		                      {
			
			                     if(destroychallenge==true)
				                   
				                    {
					                    numberOfArrow=numberOfArrow+1;
				                  
					                    noArrow=noArrow-1;
					              
					                    if(numberOfArrow<=nineChallengeMaxArrow)
					                   
					                    {
						           
						                    destroyArrowChallengescript.recreate();
						                    
						                    rotatewindscript.onetime=false;
						
					                     }
					                    
					                    destroychallenge=false;
					
				                   }
			                 
		                      }
			
			                  if(currentChallenge==ArcheryChallenge.challenge10)
			                  {
				                    if(destroychallenge==true)
				                    {
					                      numberOfArrow=numberOfArrow+1;
				                  
					                      noArrow=noArrow-1;
					              
					                      if(numberOfArrow<=_tenMAxArrow)
					                      {
						           
						                      destroyArrowChallengescript.recreate();
						                    
						                      rotatewindscript.onetime=false;
						
					                      }
					                    
					                      destroychallenge=false;
					
				                     }
			                   }
			                 if(currentChallenge==ArcheryChallenge.challenge11)
			                  {
				                    if(destroychallenge==true)
				                    {
					                      numberOfArrow=numberOfArrow+1;
				                  
					                      noArrow=noArrow-1;
					              
					                      if(numberOfArrow<=_challenge11MaxArrow)
					                      {
						           
						                      destroyArrowChallengescript.recreate();
						                    
						                      rotatewindscript.onetime=false;
						
					                      }
					                    
					                      destroychallenge=false;
					
				                     }
			                   }
			                   if(currentChallenge==ArcheryChallenge.challenge12)
			                  {
				                    if(destroychallenge==true)
				                    {
					                      numberOfArrow=numberOfArrow+1;
				                  
					                      noArrow=noArrow-1;
					              
					                      if(numberOfArrow<=_tweleMaxArrow)
					                      {
						           
						                      destroyArrowChallengescript.recreate();
						                    
						                      rotatewindscript.onetime=false;
						
					                      }
					                    
					                      destroychallenge=false;
					
				                     }
			                   }
			                  if(currentChallenge==ArcheryChallenge.challenge13)
			                  {
				                    if(destroychallenge==true)
				                    {
					                      numberOfArrow=numberOfArrow+1;
				                  
					                      noArrow=noArrow-1;
					              
					                      if(numberOfArrow<=_thirteenMaxArrow)
					                      {
						           
						                      destroyArrowChallengescript.recreate();
						                    
						                      rotatewindscript.onetime=false;
						
					                      }
					                    
					                      destroychallenge=false;
					
				                     }
			                   }
			                  if(currentChallenge==ArcheryChallenge.challenge14)
			                  {
				                    if(destroychallenge==true)
				                    {
					                      numberOfArrow=numberOfArrow+1;
				                  
					                      noArrow=noArrow-1;
					              
					                      if(numberOfArrow<=_fourteenMaxArrow)
					                      {
						           
						                      destroyArrowChallengescript.recreate();
						                    
						                      rotatewindscript.onetime=false;
						
					                      }
					                    
					                      destroychallenge=false;
					
				                     }
			                   }
			                  if(currentChallenge==ArcheryChallenge.challenge15)
			                  {
				                    if(destroychallenge==true)
				                    {
					                      numberOfArrow=numberOfArrow+1;
				                  
					                      noArrow=noArrow-1;
					              
					                      if(numberOfArrow<=_fifteenMaxArrow)
					                      {
						           
						                      destroyArrowChallengescript.recreate();
						                    
						                      rotatewindscript.onetime=false;
						
					                      }
					                    
					                      destroychallenge=false;
					
				                     }
			                   }
			                  if(currentChallenge==ArcheryChallenge.challenge16)
			                  {
				                    if(destroychallenge==true)
				                    {
					                      numberOfArrow=numberOfArrow+1;
				                  
					                      noArrow=noArrow-1;
					              
					                      if(numberOfArrow<=_sixteenMaxArrow)
					                      {
						           
						                      destroyArrowChallengescript.recreate();
						                    
						                      rotatewindscript.onetime=false;
						
					                      }
					                    
					                      destroychallenge=false;
					
				                     }
			                   }
		
		
		
	              }
		
}

public void Challengegameplaystart()
{
	
		if(currentChallenge==ArcheryChallenge.challenge6||currentChallenge==ArcheryChallenge.challenge2)
		
		{
			time_showScript.countDownSeconds=currentcountdowntime;
			
			time_showScript.startTime=Time.time;
			
			time_showScript.showtimestart=true;
		}
		
		destroyArrowChallengescript.recreate();
		
		flashcontrollingscript.gameplaystart=true;
		
		rotatewindscript.showwind=true;
		
		numberOfArrow=numberOfArrow+1;
		
		rotatewindscript.onetime=false;
		
	    challenge7noarrow=challenge7noarrow+1;
		
		resetbutton=true;
		
		_restartjoystick=true;
		joysticktimeset=Time.time;
}
	
public void showChallengescoreset(int currentscore)
{
		if(currentChallenge==ArcheryChallenge.challenge9)
		{
			challengeScoreSave[i]=currentscore;
			
			i=i+1;
		}
		if(currentChallenge==ArcheryChallenge.challenge4)//||currentChallenge==ArcheryChallenge.challenge9)
		{
			challengeScoreSave[i]=currentscore;
			
			i=i+1;
		}
	    if(currentscore==11)
		{
			currentscore=10;
		}
		
		challenge_mode_guiscript.PlayerTotalScore=challenge_mode_guiscript.PlayerTotalScore+currentscore;
		
		
}

public void setchallengefirstscene()
{
	notdestroyScript.checkchallengemode=false;	
}
	
void OnGUI()
	
{
		
   if(checkChallenge==true&&(currentChallenge==ArcheryChallenge.challenge6||currentChallenge==ArcheryChallenge.challenge1||currentChallenge==ArcheryChallenge.challenge2||currentChallenge==ArcheryChallenge.challenge3||currentChallenge==ArcheryChallenge.challenge5||currentChallenge==ArcheryChallenge.challenge9||currentChallenge==ArcheryChallenge.challenge4||currentChallenge==ArcheryChallenge.challenge7||currentChallenge==ArcheryChallenge.challenge10||currentChallenge==ArcheryChallenge.challenge11||currentChallenge==ArcheryChallenge.challenge12||currentChallenge==ArcheryChallenge.challenge13||currentChallenge==ArcheryChallenge.challenge14||currentChallenge==ArcheryChallenge.challenge15||currentChallenge==ArcheryChallenge.challenge16))
		
   {     if(challegeWindObject.GetComponent<Renderer>().enabled==false)
			{
			
				windvalueObject.gameObject.SetActive(false);
			}
		if(challegeWindObject.GetComponent<Renderer>().enabled==true)
	     {
			windvalueObject.gameObject.SetActive(true);
		   
			windvalue.text=""+(challengewindmultipler).ToString("F2");
				
			}
	
   }
}

public void setgravity(int setvalue)
	
{
	if(notDestroy.instances.checkchallengemode==true&&outdoor==true)
	{
			
			if(targetChallengeScript.checklimit==0)
			{
				if(setvalue==0)
				{
				 Physics.gravity=new Vector3(0f,gravity0Y1,0f);
				}
				if(setvalue==1)
				{
				 Physics.gravity=new Vector3(0f,gravity0Y1+first_typegra,0f);
				}
				if(setvalue==2)
				{
				  Physics.gravity=new Vector3(0f,gravity0Y1+second_typegra,0f);
				}
				if(setvalue==3)
				{
				  Physics.gravity=new Vector3(0f,gravity0Y1+third_typegra,0f);
				}
			}
			if(targetChallengeScript.checklimit==1)
			{
				if(setvalue==0)
				{
				 Physics.gravity=new Vector3(0f,gravity1Y1,0f);
				}
				if(setvalue==1)
				{
				 Physics.gravity=new Vector3(0f,gravity1Y1+first_typegra,0f);
				}
				if(setvalue==2)
				{
				 Physics.gravity=new Vector3(0f,gravity1Y1+second_typegra,0f);
				}
				if(setvalue==3)
				{
				  Physics.gravity=new Vector3(0f,gravity1Y1+third_typegra,0f);
				} 
				
			}
			if(targetChallengeScript.checklimit==2)
			{
				if(setvalue==0)
				{
				Physics.gravity=new Vector3 (0f,gravity2Y1,0f);
				}
				if(setvalue==1)
				{
				 Physics.gravity=new Vector3 (0f,gravity2Y1+first_typegra,0f);
				}
				if(setvalue==2)
				{
				 Physics.gravity=new Vector3 (0f,gravity2Y1+second_typegra,0f);
				}
				if(setvalue==3)
				{
				  Physics.gravity=new Vector3 (0f,gravity2Y1+third_typegra,0f);
				} 
				
			}
			if(targetChallengeScript.checklimit==3)
			{
				if(setvalue==0)
				{
				 Physics.gravity=new Vector3 (0f,gravity3Y1,0f);
				}
				if(setvalue==1)
				{
				 Physics.gravity=new Vector3 (0f,gravity3Y1+first_typegra,0f);
				}
				if(setvalue==2)
				{
				 Physics.gravity=new Vector3 (0f,gravity3Y1+second_typegra,0f);
				}
				if(setvalue==3)
				{
				  Physics.gravity=new Vector3 (0f,gravity3Y1+third_typegra,0f);
				} 
				
			}
		
	}
	
}

	
public void showscoreset(int currentsc) // this function show the sum of score
	
{
	  
	if(outdoor==true)
   
	{
	  
	   challenge_mode_guiscript._total[countsetscore]=currentsc;
	  
	   challenge_mode_guiscript._sum=challenge_mode_guiscript._sum+ challenge_mode_guiscript._total[countsetscore];
	
	  if(countsetscore<=2)
		
		{
			firstendsum=firstendsum+currentsc;
		    totalsum= challenge_mode_guiscript._sum;
			showend1=true;
		}
		if(countsetscore>2&&countsetscore<=5)
		
		{
		  secondendsum=secondendsum+currentsc;
		  totalsum= challenge_mode_guiscript._sum;
		  showend2=true;
			
		}
		if(countsetscore>5&&countsetscore<=8)
		
		{
		  thirdendsum=thirdendsum+currentsc;
		  totalsum= challenge_mode_guiscript._sum;
			
			showend3=true;
		}
		if(countsetscore>8&&countsetscore<=11)
		
		{
		 fourendsum=fourendsum+currentsc;	
		 totalsum= challenge_mode_guiscript._sum;
			
	     showend4=true;
		}
	     
	  
		countsetscore=countsetscore+1;
			
		}
	 
}

	
	
}
