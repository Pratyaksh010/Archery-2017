using UnityEngine;
using System.Collections;

public class pauseScriptEventScript:GUIItemsManager
{
		public static pauseScriptEventScript instances;
		void Start ()
		{
				instances = this;
				base.Init ();
		}
		public override void OnSelectedEvent (GUIItem item)
		{
				if (meState == eGUI_ITEMS_MANAGER_STATE.Settled) {
						if (item.name == "Pause_button") {
								ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Activate;
								notDestroy.instances.OnShowFullAds (true, "2");
								Debug.Log ("----- In Derived class event handle : " + item.name);
								_screenManager.LoadScreen ("afterPausegui");//back_button menu page open
								controll.instance.pause = true;
								challenge_Controll.instances.time_showScript.timestop = true;
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [20];
						}
						if (item.name == "Pause_buttonch") {
								ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Activate;
								notDestroy.instances.OnShowFullAds (true, "2");
								Debug.Log ("----- In Derived class event handle : " + item.name);
								_screenManager.LoadScreen ("indoornewAfterPausegui");//back_button menu page open
								controll.instance.pause = true;
								challenge_Controll.instances.time_showScript.timestop = true;
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [20];
						}
				}
				audioManager.instances.playcurrentaudio ();
		}
	public override void OnEntryAnimationCompleted ()
	{
		notDestroy.instances.OnShowBannerAds (false,true);
	}

	void Update()
	{
		if(Input.GetKeyUp(KeyCode.Escape) && notDestroy.instances._emPlayMode != notDestroy.ePlayMode.PlayForCash)
		{
			ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Activate;
			notDestroy.instances.OnShowFullAds (true, "2");
			_screenManager.LoadScreen ("afterPausegui");//back_button menu page open
			controll.instance.pause = true;
			challenge_Controll.instances.time_showScript.timestop = true;
			audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [20];
		}
	}
}
