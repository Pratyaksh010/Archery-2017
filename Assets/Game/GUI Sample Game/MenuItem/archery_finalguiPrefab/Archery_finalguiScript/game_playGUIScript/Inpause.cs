using UnityEngine;
using System.Collections;

public class Inpause : GUIItemsManager
{
	
		public static Inpause instances;
		public string Loadingprefab;
		public string challengeloading;
		// Use this for initialization
		void Start ()
		{
				instances = this;
				base.Init ();
		
//				if (Application.loadedLevel == 3)//&&store_currentStatus.instances.checkchallengemode==false)
//						GamePlugin.ShowAddBanner (true, true);
		
		
		}
	
	
	
		public override void OnSelectedEvent (GUIItem item)
		{
				if (meState == eGUI_ITEMS_MANAGER_STATE.Settled) {
			
						if (item.name == "home") {
			
								Debug.Log ("----- In Derived class event handle : " + item.name);
								store_currentStatus.instances.currentscene = 1;
								_screenManager.LoadScreen ("loading_bagground");//load home page
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
				
						}
						if (item.name == "Pause_button" && notDestroy.instances.checkchallengemode == false) {
								Debug.Log ("----- In Derived class event handle : " + item.name);
								_screenManager.LoadScreen (Loadingprefab);//back_button menu page open
				
								controll.instance.pause = true;
				
								challenge_Controll.instances.pause = true;
				
								challenge_Controll.instances.time_showScript.timestop = true;
				
					 
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [20];
						}
						if (item.name == "Pause_button" && notDestroy.instances.checkchallengemode == true) {
								Debug.Log ("----- In Derived class event handle : " + item.name);
								_screenManager.LoadScreen (challengeloading);//back_button menu page open
								ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Activate;
								notDestroy.instances.OnShowFullAds (true, "2");
								controll.instance.pause = true;
				
								challenge_Controll.instances.pause = true;
				
								challenge_Controll.instances.time_showScript.timestop = true;
			
				
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [20];
						}
			
				}
		
				audioManager.instances.playcurrentaudio ();
		}

	void Update()
	{
		if (Input.GetKeyUp (KeyCode.Escape) && transform.gameObject.name == "Inpausegui1(Clone)") 
		{
			store_currentStatus.instances.currentscene = 1;
			_screenManager.LoadScreen ("loading_bagground");//load home page
			audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
		}
		if (Input.GetKeyUp (KeyCode.Escape) && transform.gameObject.name == "Inpausegui(Clone)") 
		{
			_screenManager.LoadScreen (challengeloading);//back_button menu page open
			ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Activate;
			notDestroy.instances.OnShowFullAds (true, "2");
			controll.instance.pause = true;
			
			challenge_Controll.instances.pause = true;
			
			challenge_Controll.instances.time_showScript.timestop = true;
			
			
			audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [20];

		}
	}
	public override void OnEntryAnimationCompleted ()
	{
		notDestroy.instances.OnShowBannerAds (false,true);
	}
}
