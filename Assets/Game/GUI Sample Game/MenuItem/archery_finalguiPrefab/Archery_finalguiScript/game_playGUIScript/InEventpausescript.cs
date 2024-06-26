using UnityEngine;
using System.Collections;

public class InEventpausescript :GUIItemsManager
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
			if (Input.GetKeyUp (KeyCode.Escape)) 
			{
				ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Deactivate;
				notDestroy.instances.OnShowFullAds (false,"");
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
				audioManager.instances.playcurrentaudio ();
				
				_screenManager.LoadScreen ("Inpausegui");

			}
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
			
						if (item.name == "Rematch") {
								ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Activate;
								notDestroy.instances.OnShowFullAds (false,"");
								Debug.Log ("----- In Derived class event handle : " + item.name);
								//store_currentStatus.instances.currentscene=
								store_currentStatus.instances.challengemodecheck = notDestroy.instances.checkchallengemode;
								////// store_currentStatus.instances.rematchscene= store_currentStatus.instances.currentscene;
								///////////  store_currentStatus.instances.currentscene=4;
								store_currentStatus.instances.loadingcheck = true;
								_screenManager.LoadScreen ("loading_bagground");//load home page
				
								//_screenManager.LoadScreen("Exhibition_First_menu 1");// challenges menu page open
								//audioManager.instances._currentaudio.audio.clip=audioManager.instances._audioclip[19];
						}
						if (item.name == "Resume") {
								ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Deactivate;
								notDestroy.instances.OnShowFullAds (false,"");
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
								audioManager.instances.playcurrentaudio ();
		 
								_screenManager.LoadScreen ("Inpausegui");
				
						}
			
				}
				audioManager.instances.playcurrentaudio ();
	
		}
}
