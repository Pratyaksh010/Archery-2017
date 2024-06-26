using UnityEngine;
using System.Collections;

public class excibution_First_pageEvent :GUIItemsManager
{
		public int windcount = 0;
		public int distancecount = 0;
		public GameObject windtext;
		public GameObject distancetext;
		public int maxnumberofdistance;
		public int maxnumberofwindeffect;
		public GUITexture leftbutton;
	
		public GUITexture rightbutton;
	
		public GUITexture windleftbuuton;
	
		public GUITexture windrightbutton;
	
		bool onetimecall ;
	
		public Texture[] _selectedButton ;
		//private GUIItemButton _windLeftButton ;
	
		//private GUIItemButton _distanceLeftButton ;
		//private GUIItemButton _windRightButton ;
	
		//private GUIItemButton _distanceRightButton ;
		//public Texture2D _afterSelected ;
		//public Texture2D _rightButtonAfterSelected ;
		// Use this for initialization
	
		void Start ()
		{
				base.Init ();
		
				setwind ();
		
				//  _windLeftButton = windleftbuuton.GetComponent<GUIItemButton>();
				//  _distanceLeftButton = leftbutton.GetComponent<GUIItemButton>();
				// _windRightButton =     windrightbutton.GetComponent<GUIItemButton>();
				//_distanceRightButton =rightbutton.GetComponent<GUIItemButton>();
		
		}
	
		void Update ()
		{
				if (windtext.GetComponent<GUIText>().text == "EASY") {
						windleftbuuton.color = new Color (windleftbuuton.color.r, windleftbuuton.color.g, windleftbuuton.color.b, 0f);
						//windrightbutton.guiTexture.texture =  _selectedButton[1];
			
						// _windRightButton.guiTexture.texture = _rightButtonAfterSelected ;
				}
				if (windtext.GetComponent<GUIText>().text == "MEDIUM") {
						windleftbuuton.color = new Color (windleftbuuton.color.r, windleftbuuton.color.g, windleftbuuton.color.b, .5f);
						windrightbutton.color = new Color (windrightbutton.color.r, windrightbutton.color.g, windrightbutton.color.b, .5f);
						//windleftbuuton.guiTexture.texture = _selectedButton[0];
						//windrightbutton.guiTexture.texture =  _selectedButton[1];
			
						//  _windLeftButton.guiTexture.texture =_afterSelected ; 
				}
				if (windtext.GetComponent<GUIText>().text == "HARD") {
						windrightbutton.color = new Color (windrightbutton.color.r, windrightbutton.color.g, windrightbutton.color.b, 0f);
						//	windleftbuuton.guiTexture.texture = _selectedButton[0];
			
						//_windLeftButton.guiTexture.texture =_afterSelected ; 
				}
		
				if (distancetext.GetComponent<GUIText>().text == "30") {
						leftbutton.color = new Color (leftbutton.color.r, leftbutton.color.g, leftbutton.color.b, 0f);
						//rightbutton.guiTexture.texture = _selectedButton[1];
						///_distanceRightButton.guiTexture.texture = _rightButtonAfterSelected ;
				}
				if (distancetext.GetComponent<GUIText>().text == "50") {
						leftbutton.color = new Color (leftbutton.color.r, leftbutton.color.g, leftbutton.color.b, .5f);
						rightbutton.color = new Color (rightbutton.color.r, rightbutton.color.g, rightbutton.color.b, .5f);
						//leftbutton.guiTexture.texture = _selectedButton[0];
						//rightbutton.guiTexture.texture = _selectedButton[1];
						//_distanceLeftButton.guiTexture.texture =_afterSelected ; 
				}
				if (distancetext.GetComponent<GUIText>().text == "70") {
						rightbutton.color = new Color (rightbutton.color.r, rightbutton.color.g, rightbutton.color.b, 0f);
						//leftbutton.guiTexture.texture = _selectedButton[0];
						//_distanceLeftButton.guiTexture.texture =_afterSelected ;
				}


				if (Input.GetKeyUp (KeyCode.Escape)) 
				{
					_screenManager.LoadScreen ("Archery_First_guiPage");//back_button menu page open
					audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
					audioManager.instances.playcurrentaudio ();	
					changelayer ();
				}
		
		
		}
		public void setwind ()
		{
				if (store_currentStatus.instances.currentwin == store_currentStatus.currentChallengewind.current_windeasy) {
						windtext.GetComponent<GUIText>().text = "EASY";
			
						//windrightbutton.guiTexture.texture =  _selectedButton[1];
			
			
				}
				if (store_currentStatus.instances.currentwin == store_currentStatus.currentChallengewind.current_windMed) {
						windtext.GetComponent<GUIText>().text = "MEDIUM";
						windcount = 2;
			
						windleftbuuton.GetComponent<GUITexture>().color = new Color (windleftbuuton.color.r, windleftbuuton.color.g, windleftbuuton.color.b, 1f);
						windrightbutton.GetComponent<GUITexture>().color = new Color (windrightbutton.color.r, windrightbutton.color.g, windrightbutton.color.b, 1f);
						//windleftbuuton.guiTexture.texture = _selectedButton[0];
						//windrightbutton.guiTexture.texture =  _selectedButton[1];
				}
				if (store_currentStatus.instances.currentwin == store_currentStatus.currentChallengewind.current_windHard) {
						windtext.GetComponent<GUIText>().text = "HARD";
						windcount = 3;
						//windleftbuuton.guiTexture.texture = _selectedButton[0];
		
			
				}
				if (store_currentStatus.instances.currentchall == store_currentStatus.currentChallengedis.current_distance30) {
						distancetext.GetComponent<GUIText>().text = "30";
		
						//rightbutton.guiTexture.texture = _selectedButton[1];
				}
				if (store_currentStatus.instances.currentchall == store_currentStatus.currentChallengedis.current_distance50) {
						distancetext.GetComponent<GUIText>().text = "50";
						distancecount = 2;
						//leftbutton.guiTexture.texture = _selectedButton[0];
						//rightbutton.guiTexture.texture = _selectedButton[1];
			
				}
				if (store_currentStatus.instances.currentchall == store_currentStatus.currentChallengedis.current_distance70) {
						distancetext.GetComponent<GUIText>().text = "70";
						distancecount = 3;
						//leftbutton.guiTexture.texture = _selectedButton[0];
			
				}
				StartCoroutine (Example ());
		}
		public override void OnSelectedEvent (GUIItem item)
		{
				if (meState == eGUI_ITEMS_MANAGER_STATE.Settled) {
						Debug.Log ("----- In Derived class event handle : " + item.name);
						if (item.name == "back_button") {
								_screenManager.LoadScreen ("Archery_First_guiPage");//back_button menu page open
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
								audioManager.instances.playcurrentaudio ();	
								changelayer ();
						}
						if (item.name == "distance_rightButton" && rightbutton.color.a > .3f) {
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
								audioManager.instances.playcurrentaudio ();
								distancecount = distancecount + 1;
				
								if (distancecount >= maxnumberofdistance) {
										distancecount = maxnumberofdistance;
								}
				
								if (distancecount == 1) {
										distancetext.GetComponent<GUIText>().text = "30";
				
										store_currentStatus.instances.currentchall = store_currentStatus.currentChallengedis.current_distance30;
										store_currentStatus.instances.currentdistances = 0;
				
										//leftbutton.gameObject.SetActive(false);
					
				
								}
								if (distancecount == 2) {
										distancetext.GetComponent<GUIText>().text = "50";
										store_currentStatus.instances.currentchall = store_currentStatus.currentChallengedis.current_distance50;
										store_currentStatus.instances.currentdistances = 1;
				
					
								}
								if (distancecount == 3) {
										distancetext.GetComponent<GUIText>().text = "70";
										store_currentStatus.instances.currentchall = store_currentStatus.currentChallengedis.current_distance70;
										store_currentStatus.instances.currentdistances = 2;
			
					
								}
				
						}
						if (item.name == "DistanceLeftButton" && leftbutton.color.a > .3f) {
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
								audioManager.instances.playcurrentaudio ();
								//_screenManager.LoadScreen("Exhibition_First_menu 1");// DistanceLeftButton menu page open
								distancecount = distancecount - 1;
				
								if (distancecount <= 1) {
										distancecount = 1;
								}
				
								if (distancecount == 1) {
										distancetext.GetComponent<GUIText>().text = "30";
										store_currentStatus.instances.currentchall = store_currentStatus.currentChallengedis.current_distance30;	
										store_currentStatus.instances.currentdistances = 0;
				
										leftbutton.GetComponent<GUITexture>().color = new Color (leftbutton.color.r, leftbutton.color.g, leftbutton.color.b, 0f);
					
								}
								if (distancecount == 2) {
										distancetext.GetComponent<GUIText>().text = "50";
										store_currentStatus.instances.currentchall = store_currentStatus.currentChallengedis.current_distance50;
										store_currentStatus.instances.currentdistances = 1;
					
					
					
								}
								if (distancecount == 3) {
										distancetext.GetComponent<GUIText>().text = "70";
										store_currentStatus.instances.currentchall = store_currentStatus.currentChallengedis.current_distance70;
										store_currentStatus.instances.currentdistances = 2;
				
								}
				
						}
						if (item.name == "Play_button") {
								ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Deactivate;
								
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
								audioManager.instances.playcurrentaudio ();
								store_currentStatus.instances.currentscene = 2;
//				GamePlugin.ShowAddBanner(false,false);
								_screenManager.LoadScreen ("loading_bagground1");
								changelayer ();
								// Application.LoadLevel(2);// load the game play scene;
				
						}
						if (item.name == "shop_button") {
								//_screenManager.LoadScreen("Exhibition_First_menu 1");// record menu page open
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
								audioManager.instances.playcurrentaudio ();
						}
						if (item.name == "wind_leftbutton" && windleftbuuton.color.a > .3f) {
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
								audioManager.instances.playcurrentaudio ();
								windcount = windcount - 1;
				
								if (windcount <= 1) {
										windcount = 1;
								}
				
								if (windcount == 1) {
										windtext.GetComponent<GUIText>().text = "EASY";
				
										store_currentStatus.instances.currentwin = store_currentStatus.currentChallengewind.current_windeasy;
		      
								}
								if (windcount == 2) {
										windtext.GetComponent<GUIText>().text = "MEDIUM";
			
										store_currentStatus.instances.currentwin = store_currentStatus.currentChallengewind.current_windMed;
			
						
								}
								if (windcount == 3) {
										windtext.GetComponent<GUIText>().text = "HARD";
			
										store_currentStatus.instances.currentwin = store_currentStatus.currentChallengewind.current_windHard;
			
			  
								}
				
						}
						if (item.name == "wind_rightButton" && windrightbutton.color.a > .3f) {
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
								audioManager.instances.playcurrentaudio ();
								windcount = windcount + 1;
				
								if (windcount >= maxnumberofwindeffect) {
										windcount = maxnumberofwindeffect;
								}
				
								if (windcount == 1) {
										windtext.GetComponent<GUIText>().text = "EASY";
				
										store_currentStatus.instances.currentwin = store_currentStatus.currentChallengewind.current_windeasy;
										// windleftbuuton.gameObject.SetActive(false);
						
								}
								if (windcount == 2) {
										windtext.GetComponent<GUIText>().text = "MEDIUM";
				
										store_currentStatus.instances.currentwin = store_currentStatus.currentChallengewind.current_windMed;
				
				
								}
								if (windcount == 3) {
										windtext.GetComponent<GUIText>().text = "HARD";
				
										store_currentStatus.instances.currentwin = store_currentStatus.currentChallengewind.current_windHard;
				
			   
								}
				
						}
				}
		}
	public override void OnEntryAnimationCompleted ()
	{
		notDestroy.instances.OnShowBannerAds (true,true);
	}


		void changelayer ()
		{
				windleftbuuton.gameObject.layer = 31;
				windrightbutton.gameObject.layer = 31;
				leftbutton.gameObject.layer = 31;
				rightbutton.gameObject.layer = 31;
		}
		void changelayer1 ()
		{
				windleftbuuton.gameObject.layer = 0;
				windrightbutton.gameObject.layer = 0;
				leftbutton.gameObject.layer = 0;
				rightbutton.gameObject.layer = 0;
		}
		IEnumerator Example ()
		{
       
				yield return new WaitForSeconds (.2f);
				changelayer1 ();
		}
	
}

