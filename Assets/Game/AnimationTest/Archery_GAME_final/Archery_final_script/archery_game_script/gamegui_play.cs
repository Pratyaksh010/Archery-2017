using UnityEngine;
using System.Collections;

public class gamegui_play : MonoBehaviour
{
		public float timeShowset;
		public bool gameplaystart;
		public int setno;
		public int maxsetsize;
		public int persetnoofarrow;
		public Rect setshowrect;
		public bool showset;
		public Texture[] setnum;
		public Rect noshow;
		public float timelimit;
		public bool firsttimestart;
		public bool secondtimestart;
		public  bool gameover;
		public Texture Com;
		public Rect comrect;
		public int maxsetlimit;
		public int[] total;
		public int SUM;
		public GUITexture[] text;
		public int size;
		public Rect home;
		private Rect reset;
		private float aiheight;//
		private float palyerheight;//
		public bool chekmode;
		public Transform screenMa;
	
		public Transform _screenObject;
		public screenmanagercall screscript;
		public bool onetimeloadresult;
		public float timelimitcheck;
	
		public ScreenManager screenMaScript;
		public bool checkmode;
	
		public GUIText playerscoretext;// this text show player score
	
		public GUIText Aiscoretext;// this text show AIscore text
	
		public string pauseloading;
		public string pauseloadingForCashPlay;

	
		public string pauseloadingindoor;
	
		public Texture[] endtexture;
	
		public GUITexture showend;
	
		public Transform camanimation;
	
		public animationplayer anscript;
	
		public Transform o;
	
		int i = 0;
	
		public static gamegui_play instances;
	
		public GUIText taptoskip;
	
		private int xpscore;
	
		private bool drawmatchwin;
	
		private bool drawmatchlose;
	
		public Transform _joystickthumb ;
		public Transform _circulerjoystick ;
		public Transform _line ;
		public Transform _movingjoystick ;
		public Transform _powerThumb ;
		private ScreenManager _screenScript ;
		// Use this for initialization
		void Awake ()
		{

				instances = this;
				if (Application.loadedLevel == 2) {
						_screenScript = _powerThumb.GetComponent<ScreenManager> ();
				}
		
				if (Application.platform == RuntimePlatform.Android) {
						for (int i=0; i<size; i++) {
								text [i].color = new Color (text [i].color.r, text [i].color.g, text [i].color.b, 0);
						}
				} else {
						for (int i=0; i<size; i++) {
								text [i].color = new Color (text [i].color.r, text [i].color.g, text [i].color.b, 0);
						}	
				}
		
				//aiheight=50f;//////////////////////////
		
				///palyerheight=80f;/////////////////////
				screscript = _screenObject.GetComponent ("screenmanagercall")as screenmanagercall;
				//screenMaScript=screenMa.gameObject.GetComponent("ScreenManager")as ScreenManager;
	
		}
		void Start ()
		{
				chekmode = controll.instance.challenge_mode;
				if (controll.instance.outdoor == true && controll.instance.challenge_mode == false) {
						playerscoretext = GameObject.Find ("scoretext").GetComponent<GUIText>();
						Aiscoretext = GameObject.Find ("Aiscoretext").GetComponent<GUIText>();
				}
		
				//showend=GameObject.Find("").guiTexture;
		
		}
		// Update is called once per frame
	
		public void OnGUI ()
		{
				///////////////////////////
				if (chekmode == false) {
	                 
	           
						if (controll.instance.outdoor == true && controll.instance.challenge_mode == false && Time.time - timeShowset > (timelimitcheck)) {
			
				
								playerscoretext.text = "" + SUM;
					
								Aiscoretext.text = "" + controll.instance.enemyScoresum;
				
						}
		
		
			
	   
	
						if (showset == true) {
		    
			
		  
								if (setno <= maxsetlimit) {
										//GUI.DrawTexture(setshowrect,setnum[setno]);
			
								}
			
								if (Time.time - timeShowset > (timelimitcheck) && firsttimestart == false) {
				
										if (checkmode == true) {
			            
						
												///screenMaScript.showPause(pauseloading);
												if (notDestroy.instances._emPlayMode == notDestroy.ePlayMode.PlayForNormal)
														screscript.showPause (pauseloading);
												else
														screscript.showPause (pauseloadingForCashPlay);

					 
					
										}
										if (checkmode == false) {
												// screenMaScript.showIndoorPause(pauseloadingindoor);
												screscript.showIndoorPause (pauseloadingindoor);
										}
				
										controll.instance.gameplaystart ();
										//firsttimestart=true;
										controll.instance.controllwork = true;
										joystickrenderon ();
										showset = false;
								}
			
								if (Time.time - timeShowset > (timelimitcheck + .8f) && firsttimestart == true) {//timelimit
				
				
										controll.instance.noofarrow = 0;
				
										controll.instance.destroy = true;
										controll.instance._checkhandshow = false;
										if (checkmode == true) {
												////screenMaScript.showPause(pauseloading);
												if (notDestroy.instances._emPlayMode == notDestroy.ePlayMode.PlayForNormal)
														screscript.showPause (pauseloading);
												else
														screscript.showPause (pauseloadingForCashPlay);					
										}
					
										showset = false;
				
										controll.instance.controllwork = true;
				
										joystickrenderon ();
				
								}
			
						}
		
						if (gameover == true && onetimeloadresult == false) {
				
				
								if (checkmode == true) {
										anscript = o.GetComponent ("animationplayer")as animationplayer;
			
					
										if (SUM == controll.instance.enemyScoresum) {
						
												if (BoardScore.instances._playerTargetbull >= enemy_score.instances._bulltarget) {
														drawmatchwin = true;
												}
												if (BoardScore.instances._playerTargetbull < enemy_score.instances._bulltarget) {
														drawmatchlose = true;
												}
						
					
										}
					
										if (SUM < controll.instance.enemyScoresum || drawmatchlose == true) {
												taptoskip.material.color = new Color (1, 1, 1, 0);
				
												controll.instance.powerup.gameObject.SetActive(false);	
				
												store_currentStatus.instances._playerscore = SUM;
						
						
												///screenMaScript.losematch();
												GamePlugin.ShowChatBoost ();
												if (notDestroy.instances._emPlayMode == notDestroy.ePlayMode.PlayForNormal) {
														screscript.losematch ();

												} else {
														screscript.CashPlay ();

												}
												camanimation.gameObject.SetActive(true);
				
												anscript.startanimaton ("Losing");
												audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [23];
												audioManager.instances.playcurrentaudio ();
												audioManager.instances._bgsound.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [21];
												audioManager.instances._bgsound.volume = 1f;
												audioManager.instances.playbackgroundsound ();
										}
			
			
						
		
				
					
										if (SUM > controll.instance.enemyScoresum || drawmatchwin == true) {    
												taptoskip.material.color = new Color (1, 1, 1, 0);
					
												controll.instance.powerup.gameObject.SetActive(false);
					
												camanimation.gameObject.SetActive(true);
												store_currentStatus.instances._playerscore = SUM;
												xpscore = PlayerPrefs.GetInt ("XpScore");
												if (SUM > 50 && SUM < 70) {
														xpscore = xpscore + 500;
						
												}
							
												if (SUM > 70 && SUM < 90) {
														xpscore = xpscore + 1000;	
						
												}
						
												if (SUM > 90 && SUM < 100) {
														xpscore = xpscore + 1500;		
												}
												if (SUM > 100) {
														xpscore = xpscore + 2000;		
												}
					
												if (xpscore <= 9999999) {
														PlayerPrefs.SetInt ("XpScore", xpscore);
												}
												//screenMaScript.winmatch();
												GamePlugin.ShowChatBoost ();
												if (notDestroy.instances._emPlayMode == notDestroy.ePlayMode.PlayForNormal) {
														screscript.winmatch ();
												} else {
														screscript.CashPlay ();

												}
												anscript.startanimaton ("Winning");
						
												audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [22];
												audioManager.instances.playcurrentaudio ();
												audioManager.instances._bgsound.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [21];
												audioManager.instances._bgsound.volume = 1f;
												audioManager.instances.playbackgroundsound ();
												if (PlayerPrefs.GetInt ("reviewscom") == 0) {
														PlayerPrefs.SetInt ("reviewspoint", PlayerPrefs.GetInt ("reviewspoint") + 1);
					 
												}
												if (PlayerPrefs.GetInt ("reviewspoint") > 3 && PlayerPrefs.GetInt ("reviewscom") == 0) {
														ExternalInterfaceHandler.Instance.SendRequest (eEXTERNAL_REQ_TYPE.RateApplication, " ", checkReviews);
												}
												if (PlayerPrefs.GetInt ("reviewspoint") > 3 && PlayerPrefs.GetInt ("reviewscom") == 0) {
														PlayerPrefs.SetInt ("reviewspoint", 0);
												}
				  
										}
										onetimeloadresult = true;
			
		
			
					

					
								}
						}
		
		
				}

			
		
		}
		public void showlabeltext ()
		{
				controll.instance.controllwork = false;
		
				showset = true;
		
				if (checkmode == true && controll.instance.challenge_mode == false) {
						taptoskip.material.color = new Color (1, 1, 1, 0);
		 
						if (i < 4) {
			
								showend.texture = endtexture [i];
			
						}
		    
						//screenMaScript.showscorepanael();
						screscript.showscorepanael ();
						i = i + 1;
				}
				if (checkmode == false) {
						///screenMaScript.showIndoorscorepanael();
				}
				timeShowset = Time.time;
		
				joystickrenderoff ();
		}
		public void setcompl ()
		{
				controll.instance.gameovercom = true;
		
				gameover = true;
		
		}
		public void joystickrenderoff ()
		{
		
				if (Application.platform == RuntimePlatform.Android) {
						for (int i=0; i<size; i++) {
								text [i].color = new Color (text [i].color.r, text [i].color.g, text [i].color.b, 0);
						}
				}
		
	
		}
		public void joystickrenderon ()
		{
				if (Application.platform == RuntimePlatform.Android) {
						for (int i=0; i<size; i++) {
								text [i].color = new Color (text [i].color.r, text [i].color.g, text [i].color.b, 1);
						}
				}
		
		}
	
		public void changelevel ()
		{
				if (Application.loadedLevel == 2) {
						if (notDestroy.instances._emPlayMode == notDestroy.ePlayMode.PlayForNormal) {
								_screenScript.LoadScreen ("arrowpopup");
						}
				}
				_joystickthumb.gameObject.layer = 0;
				_circulerjoystick.gameObject.layer = 0;
				_movingjoystick.gameObject.layer = 0;
				_line.gameObject.layer = 0;
		}
	
		public void checkReviews (eEXTERNAL_REQ_TYPE requestType, string requestedID, string result)
		{
				if (result == "true") {
						//PlayerPrefs.SetInt("ShowAdds",1);
			
			
						switch (requestType) {
				
						case eEXTERNAL_REQ_TYPE.RateApplication:
				
								PlayerPrefs.SetInt ("reviewscom", 1);
								break;
						}
				}
		}
}
