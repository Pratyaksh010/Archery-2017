using UnityEngine;
using System.Collections;

public class challenge_mode_gui : MonoBehaviour {
	
	public bool showString;
	
	public float showstringTimelimit;
	
	public Rect showArrow;
	
	public Rect homeRect;
	
	public Rect resetRect;
	
	public int PlayerTotalScore;
	
	public string showChallengText;
	
	public bool onetime;
	
	public bool challengeenable;
	
	public bool showgameresult;
	
	public bool resultfuncall;  // one time call result function call
	
	public Texture[] resulttexture;
	
	public Texture currentshowtexture;
	
	public Rect showResultRect;
	
	public int currentcheckscore;
	
	public bool chekcounchallenge;
	
	public GUIStyle styletext;
	
	public ScreenManager screemanagerScript;
	
	public Transform screenManager;
	
	public GUIText score;
	
	public GUIText numberofarrow;
	
	public static challenge_mode_gui instances;
	
	public Transform showArrowprefab;
	
	public Transform showplayerscoreprefab;
	
	public string loadingpause;
	
	public string loadingpausech;
	
	public Transform o;
	
	public animationplayer anscript;
	
	public Transform camanimation;
	
	public string startchallengeprefab;
	
	public bool gameplaystart;// after tap than game start
	
	public bool onlyonetimeprefabcreate;
	
	public GUIText taptoskip;
	
	public GUIText playerscoretext;// this text show player score
	
	public GUIText Aiscoretext;// this text show AIscore text
	
	public bool showchallenge7Set;
	
	private int _i;
	
	public GUITexture _showend;
	
	public Texture[] _endtexture;
	
	public float timeShowset;// show score prefab run time 
	
	
	public bool _firsttimestart;
	
	public float _timelimitcheck;
	
	public int _sum;
	
	public int[] _total;
	
	public int setno;
	
	public int _toatlscore;
	public GameObject _screenmanagercall;
	public screenmanagercall screenScript;
	// Use this for initialization
	void Awake()
	{
		
	}
	void Start () 
	{
	 
	 instances=this;
	 anscript=o.GetComponent("animationplayer")as animationplayer;
	 timeShowset=Time.time;
	// score=GameObject.Find("score").guiText;
		//numberofarrow=GameObject.Find("playerName").guiText;
	 showArrow=new Rect(0,80,120,30);
	 resetRect=new Rect(Screen.width-100,0,100,50);
	 homeRect=new Rect(0,0,100,50);
	 showResultRect=new Rect(Screen.width/2-150,Screen.height/2-50,300,100);
	 //screemanagerScript=screenManager.gameObject.GetComponent("ScreenManager")as ScreenManager;
	 screenScript=_screenmanagercall.GetComponent("screenmanagercall")as screenmanagercall;
	 if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge6)
		{
			 currentcheckscore=challenge_Controll.instances.challenge6maxscore;
		}
	if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge1)
		{
			 currentcheckscore=75 ;//challenge_Controll.instances.challenge1maxscore;
		}
	if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge2)
		{
			 currentcheckscore=challenge_Controll.instances.challenge2maxscore;
		}
	if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge3)
		{
			 currentcheckscore=challenge_Controll.instances.challenge3maxscore;
		}
	if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge4)
		{
			currentcheckscore=challenge_Controll.instances.challengeScoreSaveSize;
		}
	if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge5)
		{
			 currentcheckscore=challenge_Controll.instances.challenge5maxscore;
		}
	if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge8)
		{
			 currentcheckscore=challenge_Controll.instances.challenge8MaxScore;
		}
	if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge9)
		{
			 currentcheckscore=challenge_Controll.instances.challengeScoreSaveSize;
		}
	if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge10)	
		{
			 currentcheckscore=challenge_Controll.instances._tenChallengeMaxScore ;
		}
	if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge11)	
		{
			 currentcheckscore=challenge_Controll.instances._elevenChallengeMaxScore ;
		}
	if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge13)
		{
			 currentcheckscore=challenge_Controll.instances._thirteenMaxScore ;
		}
	if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge14)
		{
			 currentcheckscore=challenge_Controll.instances._fourteenMaxScore ;
		}
	if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge16)
		{
			 currentcheckscore=challenge_Controll.instances._sixteenMaxScore ;
		}
		
	if(controll.instance.outdoor==true&&controll.instance.challenge_mode==true&&challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge7)
		{
			playerscoretext=GameObject.Find("scoretext").GetComponent<GUIText>();
			
			Aiscoretext=GameObject.Find("Aiscoretext").GetComponent<GUIText>();
		}
		
	}
	
	// Update is called once per frame
	public void showChallengelabeltext()
	
	{
		showString=true;
		
		showstringTimelimit=Time.time;
	
	}
	
	void OnGUI()
	
	{
		
		
		
		if(Time.time-showstringTimelimit>1f&&gameplaystart==true)///.2f
		{
			challenge_Controll.instances.Challengegameplaystart();
			challenge_Controll.instances.starttargetChallenge=true;
			gameplaystart=false;
		}
		
		
		if(showString==true&&challenge_Controll.instances.showgui==true&&gameplaystart==false)
		
		{
			
			   
				if(controll.instance.outdoor==true&&onlyonetimeprefabcreate==false)
				{
				     screenScript.showIndoorPause(startchallengeprefab);
				 //screemanagerScript.showIndoorPause(startchallengeprefab);
				 onlyonetimeprefabcreate=true;
				}
				if(controll.instance.outdoor==false&&onlyonetimeprefabcreate==false)
				{
				
				 //screemanagerScript.showIndoorPause(startchallengeprefab);
				 screenScript.showIndoorPause(startchallengeprefab);
				 onlyonetimeprefabcreate=true;
				
				}
				showString=false;
			//}
			
		}
		
		
	   if(challenge_Controll.instances.showgui==true&&showgameresult==false)
		{
		      score.text=""+PlayerTotalScore;
			
			if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge4||challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge1||challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge8||challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge3||challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge8||challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge5||challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge9||challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge10||challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge11||challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge12||challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge13||challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge14||challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge15||challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge16)
		  {
			   numberofarrow.text=""+challenge_Controll.instances.noArrow;
		  }
	      
		
			
		}
		if(showgameresult==true)
			
		{
			showArrowprefab.gameObject.SetActive(false);
			
			showplayerscoreprefab.gameObject.SetActive(false);
			challenge_Controll.instances.showtime.gameObject.SetActive(false);
			challenge_Controll.instances.speedThumbscript.timestop=true;
			if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge7)
			{
			challenge_Controll.instances.playerscoreObject.gameObject.SetActive(false);
			challenge_Controll.instances.aiscoreObject.gameObject.SetActive(false);
			}
			challenge_Controll.instances.camro.notrotatecam=true;
		}
			

	   if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge1)
		{
			
			 
			 if(challenge_Controll.instances.noArrow==0&& resultfuncall==false) //challengenumberofarrow
			 {
				_toatlscore=PlayerTotalScore;
				showResult(challenge_Controll.instances.currentChallenge);
				resultfuncall=true;
			 }
			
			 
		}
		
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge2)
			
		{
			
			
			
			 if(challenge_Controll.instances.time_showScript.timecomplete==true&&challenge_Controll.instances.time_showScript.showtimestart==false&& resultfuncall==false)
			 {
				
				    if(challenge_Controll.instances.time_showScript.restSeconds==0)
				
				 {    _toatlscore=PlayerTotalScore;
				      showResult(challenge_Controll.instances.currentChallenge);
				 
					  resultfuncall=true;
					 
				 }
			 }
			
		}
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge3)
			
		{
			
			
			
			 if(challenge_Controll.instances.noArrow==0&& resultfuncall==false) //challengenumberofarrow
			 {
				_toatlscore=PlayerTotalScore;
				showResult(challenge_Controll.instances.currentChallenge);
				resultfuncall=true;
			 }
			
		}
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge4)
			
		{
			
		
			 if(challenge_Controll.instances.noArrow==0&& resultfuncall==false) //challengenumberofarrow
			 {
				_toatlscore=PlayerTotalScore;
				showResult(challenge_Controll.instances.currentChallenge);
				resultfuncall=true;
			 }
			
		}
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge5)
			
		{
			
			 
			
			 if(challenge_Controll.instances.noArrow==0&& resultfuncall==false) //challengenumberofarrow
			 {
				_toatlscore=PlayerTotalScore;
				showResult(challenge_Controll.instances.currentChallenge);
				resultfuncall=true;
			 }
			
		}
		
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge6)
		{
			 
			
			 if(challenge_Controll.instances.time_showScript.timecomplete==true&&challenge_Controll.instances.time_showScript.showtimestart==false&& resultfuncall==false)
			 {
				if(challenge_Controll.instances.time_showScript.restSeconds==0)
				{
					_toatlscore=PlayerTotalScore;
				 showResult(challenge_Controll.instances.currentChallenge);
				 
				 resultfuncall=true;
				}
			 }
		}
		
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge7)
		{
			
			if(Time.time-timeShowset>(_timelimitcheck+.2f))
				
			{
				  	
				 
				  playerscoretext.text=""+_sum;
					
				  Aiscoretext.text=""+challenge_Controll.instances.enemyScoresum;
				
			
			}
		}
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge7&&showchallenge7Set==true)
			
		{
			
			
			if(Time.time-timeShowset>(_timelimitcheck+.8f)&&setno<4)
				
			{
				  	
			
				
			     
				  challenge_Controll.instances.challenge7noarrow=0;
				
				  challenge_Controll.instances.destroychallenge=true;
				 
				 
				  screenScript.showPause("Inpausegui");
				 
			       controll.instance.controllwork=true;
				
				   gamegui_play.instances.joystickrenderon();
				
				 	showchallenge7Set=false;
			}
			
			
			
			
		
			
		}
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge8)
		{
			
			 if(challenge_Controll.instances.noArrow==0&& resultfuncall==false)
			 
			{
				_toatlscore=PlayerTotalScore;
				showResult(challenge_Controll.instances.currentChallenge);
				
				resultfuncall=true;
			 }
		}
		
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge9)
			
		{
			
			
			if(challenge_Controll.instances.noArrow==0&& resultfuncall==false)
			 
			{
				_toatlscore=PlayerTotalScore;
				showResult(challenge_Controll.instances.currentChallenge);
				
				resultfuncall=true;
			 }
		}
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge10)
		{
			 if(challenge_Controll.instances.noArrow==0&& resultfuncall==false) //challengenumberofarrow
			 {
				_toatlscore=PlayerTotalScore;
				showResult(challenge_Controll.instances.currentChallenge);
				resultfuncall=true;
			 }
		}
	   if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge11)
		{
			if(challenge_Controll.instances.noArrow==0&& resultfuncall==false) //challengenumberofarrow
			 {
				_toatlscore=PlayerTotalScore;
				showResult(challenge_Controll.instances.currentChallenge);
				resultfuncall=true;
			 }
		}
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge12)
		{
			if(challenge_Controll.instances.noArrow==0&& resultfuncall==false) //challengenumberofarrow
			 {
				_toatlscore=PlayerTotalScore;
				showResult(challenge_Controll.instances.currentChallenge);
				resultfuncall=true;
			 }
		}
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge13)
		{
			if(challenge_Controll.instances.noArrow==0&& resultfuncall==false) //challengenumberofarrow
			 {
				_toatlscore=PlayerTotalScore;
				showResult(challenge_Controll.instances.currentChallenge);
				resultfuncall=true;
			 }
		}
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge14)
		{
			if(challenge_Controll.instances.noArrow==0&& resultfuncall==false) //challengenumberofarrow
			 {
				_toatlscore=PlayerTotalScore;
				showResult(challenge_Controll.instances.currentChallenge);
				resultfuncall=true;
			 }
		}
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge15)
		{
			if(challenge_Controll.instances.noArrow==0&& resultfuncall==false) //challengenumberofarrow
			 {
				_toatlscore=PlayerTotalScore;
				showResult(challenge_Controll.instances.currentChallenge);
				resultfuncall=true;
			 }
		}
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge16)
		{
			if(challenge_Controll.instances.noArrow==0&& resultfuncall==false) //challengenumberofarrow
			 {
				_toatlscore=PlayerTotalScore;
				showResult(challenge_Controll.instances.currentChallenge);
				resultfuncall=true;
			 }
		}
	
	}
	
	public void showResult(challenge_Controll.ArcheryChallenge o1)
	{
		  challenge_Controll.instances.powerup.gameObject.SetActive(false);
		  audioManager.instances._bgsound.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[21];
		  audioManager.instances._bgsound.volume=1f;     
		
	      audioManager.instances.playbackgroundsound();
		
		  taptoskip.material.color=new Color(1,1,1,0);
		
		if(o1==challenge_Controll.ArcheryChallenge.challenge16)
		 {
			  camanimation.gameObject.SetActive(true);
			 if(PlayerTotalScore>currentcheckscore)
			  {
					screenScript.showresultcom();
				    PlayerPrefs.SetInt("challenge15",1);
				    anscript.startanimaton("Winning");
				    audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[22];
				    audioManager.instances.playcurrentaudio();
				    chekcounchallenge=true;
			  }
			else
			{
				screenScript.showresultnotcom();
				anscript.startanimaton("Losing");
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[23];
				audioManager.instances.playcurrentaudio();
			   
			}
			
			    showgameresult=true;
		 }
		  if(o1==challenge_Controll.ArcheryChallenge.challenge15)
		 {
			  camanimation.gameObject.SetActive(true);
			 if(challenge_Controll.instances._noOffhitBullEyes>=3&&challenge_Controll.instances._arrow6XCount ==3)
			  {
					screenScript.showresultcom();
				    PlayerPrefs.SetInt("challenge13",1);
				   // PlayerPrefs.SetInt("challenge14",1);
				    anscript.startanimaton("Winning");
				    audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[22];
				    audioManager.instances.playcurrentaudio();
				    chekcounchallenge=true;
			  }
			else
			{
				screenScript.showresultnotcom();
				anscript.startanimaton("Losing");
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[23];
				audioManager.instances.playcurrentaudio();
			   
			}
			
			    showgameresult=true;
		 }
		 if(o1==challenge_Controll.ArcheryChallenge.challenge14)
		 {
			camanimation.gameObject.SetActive(true);
			if(PlayerTotalScore>currentcheckscore&&challenge_Controll.instances._arrow2XCount==4)
			{     
				 screenScript.showresultcom();
				 PlayerPrefs.SetInt("challenge12",1);
				 //PlayerPrefs.SetInt("challenge13",1);
				 anscript.startanimaton("Winning");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[22];
				 audioManager.instances.playcurrentaudio();
			}
			else
			{
				 screenScript.showresultnotcom();
				 anscript.startanimaton("Losing");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[23];
				 audioManager.instances.playcurrentaudio();
			}
			 showgameresult=true;
			
		 }
		  if(o1==challenge_Controll.ArcheryChallenge.challenge13)
		 {
			camanimation.gameObject.SetActive(true);
			if(PlayerTotalScore==currentcheckscore&&challenge_Controll.instances._arrow6XCount ==2)
			{     
				 screenScript.showresultcom();
				 PlayerPrefs.SetInt("challenge10",1);
				 anscript.startanimaton("Winning");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[22];
				 audioManager.instances.playcurrentaudio();
			}
			else
			{
				 screenScript.showresultnotcom();
				 anscript.startanimaton("Losing");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[23];
				 audioManager.instances.playcurrentaudio();
			}
			 showgameresult=true;
		 }
		 if(o1==challenge_Controll.ArcheryChallenge.challenge12)
		 { 
			camanimation.gameObject.SetActive(true);
			if(PlayerTotalScore==0)
			{ 
				screenScript.showresultcom();
				PlayerPrefs.SetInt("challenge6",1);
				//PlayerPrefs.SetInt("challenge9",1);
				anscript.startanimaton("Winning");
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[22];
				audioManager.instances.playcurrentaudio();
				print ("11111111");
			}
			else
			{
				 screenScript.showresultnotcom();
				 anscript.startanimaton("Losing");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[23];
				 audioManager.instances.playcurrentaudio();
				
			}
			showgameresult=true;
			
		 }
		  if(o1==challenge_Controll.ArcheryChallenge.challenge11)
		  {
			  camanimation.gameObject.SetActive(true);
			 if(PlayerTotalScore==currentcheckscore)
			{     
				 screenScript.showresultcom();
				 PlayerPrefs.SetInt("challenge7",1);
				 anscript.startanimaton("Winning");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[22];
				 audioManager.instances.playcurrentaudio();
			}
			else
			{
				 screenScript.showresultnotcom();
				 anscript.startanimaton("Losing");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[23];
				 audioManager.instances.playcurrentaudio();
			}
			 showgameresult=true;
		  }
		  if(o1==challenge_Controll.ArcheryChallenge.challenge10)
		  {
			  camanimation.gameObject.SetActive(true);
			  
			 if(PlayerTotalScore>60&&PlayerTotalScore<65)
			  {
					screenScript.showresultcom();
				    PlayerPrefs.SetInt("challenge5",1);
				    anscript.startanimaton("Winning");
				    audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[22];
				    audioManager.instances.playcurrentaudio();
			  }
			else
			{
				    screenScript.showresultnotcom();
				    anscript.startanimaton("Losing");
				    audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[23];
				    audioManager.instances.playcurrentaudio();
			}
			 showgameresult=true;
		  }
		  if(o1==challenge_Controll.ArcheryChallenge.challenge1)
		  {
			  camanimation.gameObject.SetActive(true);
			  if(PlayerTotalScore>currentcheckscore)
			  {
				//screemanagerScript.showresultcom();
				PlayerPrefs.SetInt("challenge1",1);
				 screenScript.showresultcom();
				anscript.startanimaton("Winning");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[22];
				 audioManager.instances.playcurrentaudio();
			  }
			  if(PlayerTotalScore<=currentcheckscore)
			  {
				//screemanagerScript.showresultnotcom();
				 screenScript.showresultnotcom();
				anscript.startanimaton("Losing");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[23];
				 audioManager.instances.playcurrentaudio();
			  }
			
			  showgameresult=true;
		  }
		
		  if(o1==challenge_Controll.ArcheryChallenge.challenge2)
		  {
			 camanimation.gameObject.SetActive(true);
			  if(PlayerTotalScore>currentcheckscore)
			  {
				PlayerPrefs.SetInt("challenge2",1);
				//screemanagerScript.showresultcom();
				 screenScript.showresultcom();
				anscript.startanimaton("Winning");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[22];
				 audioManager.instances.playcurrentaudio();
			  }
			  if(PlayerTotalScore<=currentcheckscore)
			  {
				//screemanagerScript.showresultnotcom();
				
				screenScript.showresultnotcom();
				anscript.startanimaton("Losing");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[23];
				 audioManager.instances.playcurrentaudio();
			  }
			
			  showgameresult=true;
		  }
		
		  if(o1==challenge_Controll.ArcheryChallenge.challenge3)
		  {
			  camanimation.gameObject.SetActive(true);
			  if(PlayerTotalScore>currentcheckscore)
			  {
				//screemanagerScript
			     PlayerPrefs.SetInt("challenge3",1);
					screenScript.showresultcom();
				anscript.startanimaton("Winning");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[22];
				 audioManager.instances.playcurrentaudio();
			  }
			  if(PlayerTotalScore<=currentcheckscore)
			  {
				//screemanagerScript
			     screenScript.showresultnotcom();
				 anscript.startanimaton("Losing");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[23];
				 audioManager.instances.playcurrentaudio();
			  }
			
			  showgameresult=true;
		  }
		 if(o1==challenge_Controll.ArcheryChallenge.challenge4)
		{
			 camanimation.gameObject.SetActive(true);
			for(int i=0;i<currentcheckscore;i++)
			{
				if(challenge_Controll.instances.challengeScoreSave[i]==7&&i<=1)
				{
					if(challenge_Controll.instances.challengeScoreSave[i+1]==7)
					{
						if(challenge_Controll.instances.challengeScoreSave[i+2]==7)
						{
							//screemanagerScript
								screenScript.showresultcom();
							PlayerPrefs.SetInt("challenge14",1);
							//PlayerPrefs.SetInt("challenge11",1);
							anscript.startanimaton("Winning");
							 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[22];
				             audioManager.instances.playcurrentaudio();
							
							chekcounchallenge=true;
						}
					}
				}
			
			}
			if(chekcounchallenge==false)
			{
				//screemanagerScript
				screenScript.showresultnotcom();
				anscript.startanimaton("Losing");
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[23];
				audioManager.instances.playcurrentaudio();
			}
			 showgameresult=true;
		}
		if(o1==challenge_Controll.ArcheryChallenge.challenge5)
		  {
			 camanimation.gameObject.SetActive(true);
			  if(PlayerTotalScore==currentcheckscore)
			  {
				//screemanagerScript
				screenScript.showresultcom();
				PlayerPrefs.SetInt("challenge9",1);
				//////PlayerPrefs.SetInt("challenge6",1);
				anscript.startanimaton("Winning");
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[22];
				audioManager.instances.playcurrentaudio();
			  }
			  if(PlayerTotalScore!=currentcheckscore)
			  {
				//screemanagerScript
					screenScript.showresultnotcom();
				anscript.startanimaton("Losing");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[23];
				 audioManager.instances.playcurrentaudio();
			  }
			
			  showgameresult=true;
		  }
		   if(o1==challenge_Controll.ArcheryChallenge.challenge6)
		  {
			 camanimation.gameObject.SetActive(true);
			  if(PlayerTotalScore>80&&PlayerTotalScore<90)
			  {
				//screemanagerScript
				screenScript.showresultcom();
				PlayerPrefs.SetInt("challenge4",1);
				anscript.startanimaton("Winning");
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[22];
				audioManager.instances.playcurrentaudio();
			  }
			 // if(PlayerTotalScore<=currentcheckscore)
			 else
			  {
				//screemanagerScript
					screenScript.showresultnotcom();
				anscript.startanimaton("Losing");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[23];
				 audioManager.instances.playcurrentaudio();
			  }
			
			  showgameresult=true;
		  }
		
		  if(o1==challenge_Controll.ArcheryChallenge.challenge7)
		  {
			 camanimation.gameObject.SetActive(true);
			_toatlscore=_sum;
			  if(_sum<=challenge_Controll.instances.enemyScoresum)
			{
				//screemanagerScript
				
					screenScript.showresultnotcom();
				anscript.startanimaton("Losing");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[23];
				 audioManager.instances.playcurrentaudio();
			}
			  if(_sum>challenge_Controll.instances.enemyScoresum)
			{
				//screemanagerScript
					screenScript.showresultcom();
				PlayerPrefs.SetInt("challenge8",1);
				anscript.startanimaton("Winning");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[22];
				 audioManager.instances.playcurrentaudio();
			}
			 showgameresult=true;
		  }
		  if(o1==challenge_Controll.ArcheryChallenge.challenge8)
		 
		  {
			 camanimation.gameObject.SetActive(true);
			
		      if(PlayerTotalScore>currentcheckscore)
			  {
				//screemanagerScript
					screenScript.showresultcom();
				PlayerPrefs.SetInt("challenge8",1);
				anscript.startanimaton("Winning");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[22];
				 audioManager.instances.playcurrentaudio();
			  }
			  if(PlayerTotalScore<=currentcheckscore)
			  {
				//screemanagerScript
					screenScript.showresultnotcom();
				anscript.startanimaton("Losing");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[23];
				 audioManager.instances.playcurrentaudio();
			  }
			  showgameresult=true;
		  }
		 if(o1==challenge_Controll.ArcheryChallenge.challenge9)
		
		 {
			 camanimation.gameObject.SetActive(true);
			//for(int i=0;i<currentcheckscore;i++)
			//{
				//if(challenge_Controll.instances.challengeScoreSave[i]==11&&i<=8)
				//{
				//	if(challenge_Controll.instances.challengeScoreSave[i+1]==11)
				//	{
						//if(challenge_Controll.instances.challengeScoreSave[i+2]==11)
						//{
							//screemanagerScript
			                 if(challenge_Controll.instances._noOffhitBullEyes>=5)
			                {
								screenScript.showresultcom();
				                PlayerPrefs.SetInt("challenge11",1);
				                /////////PlayerPrefs.SetInt("challenge12",1);
							    anscript.startanimaton("Winning");
							    audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[22];
				                audioManager.instances.playcurrentaudio();
							    chekcounchallenge=true;
			               }
						//}
					//}
				//}
			//}
			if(chekcounchallenge==false)
			{
				//screemanagerScript.showresultnotcom();
				screenScript.showresultnotcom();
				anscript.startanimaton("Losing");
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[23];
				 audioManager.instances.playcurrentaudio();
			}
		    showgameresult=true;
		 }
		
		
		if(PlayerPrefs.GetInt("reviewscom")==0)
					{
				       PlayerPrefs.SetInt("reviewspoint",  PlayerPrefs.GetInt("reviewspoint")+1);
					 
					}
				    if(PlayerPrefs.GetInt("reviewspoint")>3&&PlayerPrefs.GetInt("reviewscom")==0)
					{
						   ExternalInterfaceHandler.Instance.SendRequest(eEXTERNAL_REQ_TYPE.RateApplication," ",checkReviews1);
				    }
					if(PlayerPrefs.GetInt("reviewspoint")>3&&PlayerPrefs.GetInt("reviewscom")==0)
					{
						   PlayerPrefs.SetInt("reviewspoint", 0);
					}
		
		
		
		
		
		
	}
	
	
	public void showlabeltext()
		
	{
		controll.instance.controllwork=false;
		
		showchallenge7Set=true;
		
		taptoskip.material.color=new Color(1,1,1,0);
		
		if(_i<4)
			
	    {
			_showend.texture=_endtexture[_i];
			
	    }
		   //screemanagerScript
			screenScript.showscorepanael();
		  _i=_i+1;
			timeShowset=Time.time;
	      gamegui_play.instances.joystickrenderoff();
	}
	
	public void checkReviews1(eEXTERNAL_REQ_TYPE requestType,string requestedID,string result)
	{
		if(result == "true")
		{
			//PlayerPrefs.SetInt("ShowAdds",1);
			
			
			switch(requestType)
			{
				
			    case eEXTERNAL_REQ_TYPE.RateApplication:
				
				       PlayerPrefs.SetInt("reviewscom",1);
				break;
			}
		}
	}
   
}
