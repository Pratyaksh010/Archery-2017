using UnityEngine;
using System.Collections;

public class MyEventManager :GUIItemsManager
{
		//public Texture t1;
		//public Texture t2;
		//public Texture t3;
		public GUIItemButton _Home;
		public GUIItemButton _Next;
		public GUIItemButton _Rmatch;

		private int i = 0;
		void Start ()
		{
				base.Init ();
				if (transform.name == "loseprefab(Clone)" || transform.name == "winPrefab(Clone)") {
						ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Activate;
						notDestroy.instances.OnShowFullAds (true, "3");
						notDestroy.instances.OnShowBannerAds (false, false);
				}
		}
		
		public override void OnSelectedEvent (GUIItem item)
		{
				if (meState == eGUI_ITEMS_MANAGER_STATE.Settled) {
			
			
						if (item.name == "TapButtonChallenge") {
								gamegui_play.instances.changelevel ();//changelevel();
								ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Deactivate;
								notDestroy.instances.OnShowFullAds (false,"");
								
								_screenManager.LoadScreen ("Inpausegui");
								challenge_mode_gui.instances.gameplaystart = true;
								challenge_mode_gui.instances.showstringTimelimit = Time.time;
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
								audioManager.instances.playcurrentaudio ();
						}
						if (item.name == "scoreLoading") {
								_screenManager.LoadScreen ("show_scorePrefab");
						}
						if (item.name == "Next") { 
								notDestroy.instances._emPlayMode = notDestroy.ePlayMode.PlayForNormal;
								store_currentStatus.instances.currentscene = 1;
								_screenManager.LoadScreen ("loading_bagground");
								gamegui_play.instances.camanimation.gameObject.SetActive(false);
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
						}
						if (item.name == "CashPlay") { 
								ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Deactivate;
								notDestroy.instances.OnShowFullAds (false,"");
						}
						if (item.name == "Rematch") {
								notDestroy.instances._emPlayMode = notDestroy.ePlayMode.PlayForNormal;
								ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Deactivate;
								notDestroy.instances.OnShowFullAds (false,"");
								
								store_currentStatus.instances.challengemodecheck = notDestroy.instances.checkchallengemode;
								_screenManager.LoadScreen ("loading_bagground");
								gamegui_play.instances.camanimation.gameObject.SetActive(false);
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19]; 
						}	
				

						if (item.name == "shopbutton") {
								store_currentStatus.instances.currentscene = 1;
								store_currentStatus.instances.loadingshoppage = true;
								gamegui_play.instances.camanimation.gameObject.SetActive(false);
								_screenManager.LoadScreen ("loading_bagground");	
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
						}
			
				}
		
				audioManager.instances.playcurrentaudio ();
		}
		public void SetActiveBtn (bool pState)
		{
				_Home.setDisabled (!pState);
				_Next.setDisabled (!pState);
				_Rmatch.setDisabled (!pState);
		}
		public void PlayForCash ()
		{
//				notDestroy.instances._emPlayMode = notDestroy.ePlayMode.PlayForCash;
//				_screenManager.LoadScreen ("loading_bagground");
//				gamegui_play.instances.camanimation.gameObject.SetActive(false);
//				audioManager.instances._currentaudio.audio.clip = audioManager.instances._audioclip [19]; 

		}

	void Update()
	{
		if (Input.GetKeyUp (KeyCode.Escape)) 
		{
			if(GameObject.Find("loseprefab(Clone)")!= null || GameObject.Find("winPrefab(Clone)")!= null)
			{
				notDestroy.instances._emPlayMode = notDestroy.ePlayMode.PlayForNormal;
				store_currentStatus.instances.currentscene = 1;
				_screenManager.LoadScreen ("loading_bagground");
				gamegui_play.instances.camanimation.gameObject.SetActive(false);
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
			}
		}
	}
}