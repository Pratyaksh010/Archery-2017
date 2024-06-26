using UnityEngine;
using System.Collections;

public class PauseEventScript :GUIItemsManager
{

		// Use this for initialization
		void Start ()
		{
				base.Init ();
				if (controll.instance.secondpowerup != null) {
						controll.instance.secondpowerup.gameObject.SetActive(false);
				}
		
				if (challenge_Controll.instances.secondpowerup != null) {
						challenge_Controll.instances.secondpowerup.gameObject.SetActive(false);
				}
				if (challenge_Controll.instances.powerup != null) {
						challenge_Controll.instances.powerup.gameObject.SetActive(false);
				}
		
				if (controll.instance.powerup != null) {
						controll.instance.powerup.gameObject.SetActive(false);
				}
		
				GamePlugin.ShowChatBoost ();	
		}
		
	void Update()
	{
		if(Input.GetKeyUp(KeyCode.Escape))
		{
			ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Deactivate;
			audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
			audioManager.instances.playcurrentaudio ();
			
			_screenManager.LoadScreen ("pause_gui");
			
		}

	}

		public override void OnSelectedEvent (GUIItem item)
		{
				if (meState == eGUI_ITEMS_MANAGER_STATE.Settled) {
						if (item.name == "home") {
			
								Debug.Log ("----- In Derived class event handle : " + item.name);
								store_currentStatus.instances.currentscene = 1;
								_screenManager.LoadScreen ("loading_bagground");
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
								//_screenManager.LoadScreen("Exhibition_First_menu 1");// challenges menu page open
				
						}
						if (item.name == "Rematch") {
								ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Deactivate;
								notDestroy.instances.OnShowBannerAds (false, true);
								Debug.Log ("----- In Derived class event handle : " + item.name);
								store_currentStatus.instances.challengemodecheck = notDestroy.instances.checkchallengemode;
								///// store_currentStatus.instances.rematchscene= store_currentStatus.instances.currentscene;
								/////// store_currentStatus.instances.currentscene=4;
								_screenManager.LoadScreen ("loading_bagground");
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
								//_screenManager.LoadScreen("Exhibition_First_menu 1");// challenges menu page open
				
						}
						if (item.name == "Resume") {
								ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Deactivate;
								Debug.Log ("----- In Derived class event handle : " + item.name);
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
								audioManager.instances.playcurrentaudio ();
		    
								_screenManager.LoadScreen ("pause_gui");
				
						}
			
				}
		
				audioManager.instances.playcurrentaudio ();
		}
}
