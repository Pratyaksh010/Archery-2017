using UnityEngine;
using System.Collections;

public class settings_event :GUIItemsManager  
{
	public GameObject _SoundOn, _SoundOff;
	public GameObject _OptOutOn,_OptOutOff;
	// Use this for initialization
	void Start () 
	{
		base.Init(); 
		
		if(PlayerPrefs.GetInt("soundon")==1)
		{
			_SoundOn.SetActive(false);
			_SoundOff.SetActive(true);
		}
		
		else if(PlayerPrefs.GetInt("soundon")==2)
		{
			_SoundOn.SetActive(true);
			_SoundOff.SetActive(false);
		}
		#if UNITY_ANDROID
		InvokeRepeating ("SetMicButtonStatus", 0f, 0.5f);
		#else
		SetMicButtonStatus();
		#endif
		
	}
	
	public override void OnSelectedEvent(GUIItem item)
	{
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			if (item.name == "OptOutOn") 
			{
				ExternalInterfaceHandler.Instance.SendRequest (eEXTERNAL_REQ_TYPE.MicStatus, "1", MicCallback);
			} 
			else if (item.name == "OptOutOff") 
			{
				ExternalInterfaceHandler.Instance.SendRequest (eEXTERNAL_REQ_TYPE.MicStatus, "0", MicCallback);
			} 
			else if (item.name == "PrivacyPolicy") 
			{
				Application.OpenURL ("http://dumadu.com/privacy-policy/");
			}
			else if(item.name == "backbutton")
			{
				_screenManager.LoadScreen("Archery_First_guiPage");
				
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[19];
				
				audioManager.instances.playcurrentaudio();
			}
			
			else if(item.name=="SoundOn")
			{
				PlayerPrefs.SetInt("soundon",1);
				audioManager.instances._bgsound.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[0];
				audioManager.instances.playbackgroundsound();
				_SoundOn.SetActive(false);
				_SoundOff.SetActive(true);
			}
			else if(item.name=="SoundOff")
			{
				PlayerPrefs.SetInt("soundon",2);
				audioManager.instances._bgsound.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[0];
				audioManager.instances.playbackgroundsound();
				_SoundOn.SetActive(true);
				_SoundOff.SetActive(false);
			}
			
		}
		
	}

	void Update()
	{
		if(Input.GetKeyUp(KeyCode.Escape))
		{
			_screenManager.LoadScreen("Archery_First_guiPage");
			
			audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[19];
			
			audioManager.instances.playcurrentaudio();
		}
	}
	void MicCallback(eEXTERNAL_REQ_TYPE requestType,string requestedID,string result){
		SetMicButtonStatus();
	}
	
	void SetMicButtonStatus(){
		bool pIsMicOn = ExternalInterfaceHandler.Instance.IsMicOn;
		//		Debug.Log (pIsMicOn);
		if(pIsMicOn){
			_OptOutOff.gameObject.SetActive(true);
			_OptOutOn.gameObject.SetActive(false);
		}
		
		else{
			_OptOutOff.gameObject.SetActive(false);
			_OptOutOn.gameObject.SetActive(true);
		}
	}
}
