using UnityEngine;
using System.Collections;

public class GuiFirstPageEvent :GUIItemsManager
{
	public Texture _soundoff;
	public Texture _musicoff;
	public Texture _soundon;
	public Texture _musicon;
	public GUITexture sound;
	public GameObject _subScreenManager ;
	public ScreenManager subscreenmanager;
	public GUITexture _arrowButton ;
	public GUITexture _bowButton ;
	public Texture2D[] _selectedButtonImage ;
	public Texture2D[] _unselectedImage ;
	int firstPageOpen ;
	int secondPageOpen ;
	private GUIItemButton _arrowButtonS ;
	private GUIItemButton _bowButtonS;
	public GameObject _SettingsBtn, _SoundBtn, _SoundImage, _CashPlayBtn;
	void Awake ()
	{
		if (_subScreenManager != null) {//GameObject
			GameObject tshop = GameObject.Instantiate (_subScreenManager) as GameObject;
			subscreenmanager = tshop.GetComponent<ScreenManager> ();
		}
		firstPageOpen = 1;
		secondPageOpen = 0;
		audioManager.instances._challengeback.GetComponent<AudioSource>().clip = null;
	}
	void Start ()
	{
		base.Init ();
		if (transform.name == "Archery_First_guiPage(Clone)") {
			ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Activate;

		}
		_arrowButtonS = _arrowButton.GetComponent<GUIItemButton> ();
		_bowButtonS = _bowButton.GetComponent<GUIItemButton> ();
		if(ExternalInterfaceHandler.Instance.BuildType == eEXTERNAL_Build_Type.FreeWithAlphonso)
		{
			_SettingsBtn.SetActive(true);
			_SoundBtn.SetActive(false);
			_SoundImage.SetActive(false);
		}
		else
		{
			_SettingsBtn.SetActive(false);
			if (PlayerPrefs.GetInt ("soundon") == 1) {
				sound.texture = _soundoff;
				
			}
			
			if (PlayerPrefs.GetInt ("soundon") == 2) {
				sound.texture = _soundon;
				
			}
		}
		if (PlayerPrefs.GetInt ("musicon") == 1) {
			//if(_musicon!=null)
			//{
			///music.texture=_musicoff;
			//}
		}
		if (PlayerPrefs.GetInt ("musicon") == 2) {
			//if(_musicon!=null)
			//{
			//music.texture=_musicon;
			//}
		}
		

	}		
	
	void Update ()
	{
		if (secondPageOpen == 0) {
			_arrowButtonS.GetComponent<GUITexture>().texture = _selectedButtonImage [0];
			_arrowButtonS._texNormalState = _selectedButtonImage [0];
			_arrowButtonS._texSelectedState = _selectedButtonImage [0];
			_bowButtonS.GetComponent<GUITexture>().texture = _unselectedImage [1];
			_bowButtonS._texNormalState = _unselectedImage [1];
			_bowButtonS._texSelectedState = _unselectedImage [1];
		}
		if (secondPageOpen == 1) {
			_arrowButtonS.GetComponent<GUITexture>().texture = _unselectedImage [0];
			_arrowButtonS._texNormalState = _unselectedImage [0];
			_arrowButtonS._texSelectedState = _unselectedImage [0];
			_bowButtonS.GetComponent<GUITexture>().texture = _selectedButtonImage [1];
			_bowButtonS._texNormalState = _selectedButtonImage [1];
			_bowButtonS._texSelectedState = _selectedButtonImage [1];
		}
		
		if (Input.GetKeyUp (KeyCode.Escape)) 
		{
			ExternalInterfaceHandler.Instance.SendRequest(eEXTERNAL_REQ_TYPE.ApplicationQuit,"",null);
		}
		
		
	}
	
	// Update is called once per frame
	
	public override void OnSelectedEvent (GUIItem item)
	{
		if (meState == eGUI_ITEMS_MANAGER_STATE.Settled) {
			Debug.Log ("----- In Derived class event handle : " + item.name);
			if (item.name == "HelpButton") {
				subscreenmanager.closeScreenManager ();
				_screenManager.LoadScreen ("helppage");
			}

			if (item.name == "SettingsBtn") {
				subscreenmanager.closeScreenManager ();
				_screenManager.LoadScreen ("SettingsPage");
			}

			if (item.name == "plusbutton11111") {
				subscreenmanager.closeScreenManager ();
				_screenManager.LoadScreen ("BUY_coinsPrefab");
			}
			
			if (item.name == "ArrowButtons" && firstPageOpen == 0) {
				subscreenmanager.LoadScreen ("Arrow_selectionPage");
				secondPageOpen = 0;
				firstPageOpen = 1;
			}
			if (item.name == "BowButtons" && secondPageOpen == 0) {
				
				subscreenmanager.LoadScreen ("Bow_selectionPage");
				secondPageOpen = 1;
				firstPageOpen = 0;
			}
			if (item.name == "Challenges") {
				
				notDestroy.instances._emPlayMode = notDestroy.ePlayMode.PlayForNormal;
				
				store_currentStatus.instances.current = store_currentStatus.currentplayarea.Challenges;
				//_screenManager.LoadScreen("challenge_mode_page");
				
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [16];
				if (_screenManager != null) {
					subscreenmanager.closeScreenManager ();
					_screenManager.LoadScreen ("challengebgpage");
					
				}
				
				audioManager.instances.playcurrentaudio ();
				
				
				
			}
			if (item.name == "Exhibition") {
				notDestroy.instances._emPlayMode = notDestroy.ePlayMode.PlayForNormal;
				notDestroy.instances.OnShowFullAds (false,"");
				store_currentStatus.instances.current = store_currentStatus.currentplayarea.EXHIBITION;
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [17];
				if (_screenManager != null) {
					subscreenmanager.closeScreenManager ();
					_screenManager.LoadScreen ("Exhibition_guiFirstpage");// exhibition menu page open
				}
				audioManager.instances.playcurrentaudio ();
				//o1.guiTexture.texture=t1;
				
			}
			if (item.name == "Practice") {
				notDestroy.instances._emPlayMode = notDestroy.ePlayMode.PlayForNormal;
				ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Deactivate;
				notDestroy.instances.OnShowFullAds (false,"");
				
				store_currentStatus.instances.current = store_currentStatus.currentplayarea.Practice;
				store_currentStatus.instances.currentscene = 3;
				store_currentStatus.instances.currentdistances = 0;
				if (_screenManager != null) { 
					subscreenmanager.closeScreenManager ();
					_screenManager.LoadScreen ("loading_bagground1");
				}
				//_screenManager.LoadScreen("Exhibition_First_menu 1");// Practice menu page open
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [18];
				audioManager.instances.playcurrentaudio ();
			}
			//Chandan Yadav.......
			if (item.name == "CashPlay") {
				ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Deactivate;
				notDestroy.instances.OnShowFullAds (false,"");
				
				//	PlayForCash ();
			}
			/////Chandan Yadav....
			if (item.name == "shop") {
				if (_screenManager != null) {
					_screenManager.LoadScreen ("shopBGprefab");
				}
				
				GamePlugin.ShowAddBanner (true, false);
				//				store_currentStatus.instances.shop_page=store_currentStatus.ShopPage.first_shop_page;
				//				store_currentStatus.instances.shoppagestart=true;
				//audioManager.instances._currentaudio.audio.clip=audioManager.instances._audioclip[19];
			}
			
			
			
			if (item.name == "plusbutton") {
				if (_screenManager != null) {
					_screenManager.LoadScreen ("shopBGprefab");
					/// addreferencescript.gamemanger.screenscript.
					store_currentStatus.instances.loadbuyscreen = true;
					//// ScreenManager.instances._DefaultScreen="BuY_coinsbutton";
					//addreferencescript.gamemanger.sc
					//addreferencescript.screenscript._DefaultScreen="BuY_coinsbutton";
				}
				//audioManager.instances._currentaudio.audio.clip=audioManager.instances._audioclip[28];
			}
			
			
		}
		if (item.name == "soundbutton") {
			if (sound.texture == _soundon) {
				sound.texture = _soundoff;
				
				PlayerPrefs.SetInt ("soundon", 1);
				audioManager.instances._bgsound.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [0];
				audioManager.instances.playbackgroundsound ();
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [28];
				
			} else {
				sound.texture = _soundon;
				
				PlayerPrefs.SetInt ("soundon", 2);
				audioManager.instances._bgsound.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [0];
				audioManager.instances.playbackgroundsound ();
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [28];
			}
		}
		
	}
	public void PlayForCash ()
	{
		subscreenmanager.closeScreenManager ();
		store_currentStatus.instances.currentchall = store_currentStatus.currentChallengedis.current_distance70;
		store_currentStatus.instances.currentdistances = 2;
		store_currentStatus.instances.currentwin = store_currentStatus.currentChallengewind.current_windHard;
		notDestroy.instances._emPlayMode = notDestroy.ePlayMode.PlayForCash;
		audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
		audioManager.instances.playcurrentaudio ();
		store_currentStatus.instances.currentscene = 2;
		GamePlugin.ShowAddBanner (false, false);
		PlayerPrefs.SetInt("bowselected",0);

		_screenManager.LoadScreen ("loading_bagground1");
	}
	public override void OnEntryAnimationCompleted ()
	{
		notDestroy.instances.OnShowBannerAds (true,false);
		store_currentStatus.instances.UpdateBowStatus ();
	}

}
