using UnityEngine;
using System.Collections;

public class notDestroy : MonoBehaviour
{
	public enum ePlayMode
	{
		PlayForNormal,
		PlayForCash
	}
	;
	public ePlayMode _emPlayMode;
	public int targetdistance;
	public int challengeSelect;
	public bool checkchallengemode;
	public static notDestroy instances;
	public int _selectchallenge;
	public bool _activeArrowPopUp ;
	public int gameCount;
	public float[]_SpeedOfAir;
	public  int mAirIndex;
	void Awake ()
	{
		if(Screen.width >= 1920 )
		{
			if(Screen.height ==1200 || Screen.height ==1080 || Screen.height ==1600)
				Screen.SetResolution(1280,720,true);
		}
		DontDestroyOnLoad (this.gameObject);
		instances = this;
		ExternalInterfaceHandler.Instance.SendRequest(eEXTERNAL_REQ_TYPE.InitExternalSDK);
		ExternalInterfaceHandler.Instance.SendRequest(eEXTERNAL_REQ_TYPE.Hide_Banner_Ads);
		#if UNITY_ANDROID
		ExternalInterfaceHandler.Instance.SendRequest(eEXTERNAL_REQ_TYPE.SignIn, "",SignInCallBack);
		#else
		Invoke ("LoadGamePlay", 1f);
		#endif
	}
	void Start ()
	{
		mAirIndex = 0;
	}
	void SignInCallBack(eEXTERNAL_REQ_TYPE reqType , string requestedId , string receivedStatus)
	{
		Invoke ("LoadGamePlay", 1f);
	}
	void LoadGamePlay()
	{
		Debug.Log("LoadGamePlay");
		ExternalInterfaceHandler.Instance.SendRequest(eEXTERNAL_REQ_TYPE.Initialize);
		Application.LoadLevel(1);
	}
	void OnApplicationPause (bool pauseStatus)
	{
		if (_emPlayMode == ePlayMode.PlayForCash && !pauseStatus) {
			notDestroy.instances.mAirIndex = 0;
		}
	}
	public void OnShowBannerAds (bool pIsTopBanner = true, bool pIsVisible = true)
	{
		if (_emPlayMode == ePlayMode.PlayForCash) 
		{
			ExternalInterfaceHandler.Instance.SendRequest (eEXTERNAL_REQ_TYPE.Hide_Banner_Ads);
			return;
		}
		if (pIsVisible == false) {
			ExternalInterfaceHandler.Instance.SendRequest (eEXTERNAL_REQ_TYPE.Hide_Banner_Ads);
		} else {
			if (pIsTopBanner) {
				ExternalInterfaceHandler.Instance.SendRequest (eEXTERNAL_REQ_TYPE.Show_Banner_Top_Ads);
			} else {
				ExternalInterfaceHandler.Instance.SendRequest (eEXTERNAL_REQ_TYPE.Show_Banner_Bottom_Ads);
			}
		}
		
	}
	public void OnShowFullAds (bool  pIsVisible, string str)
	{
		if (_emPlayMode == ePlayMode.PlayForCash)
			return;
		if (pIsVisible) {
			ExternalInterfaceHandler.Instance.SendRequest (eEXTERNAL_REQ_TYPE.Show_FullScreen_Ads, str,null);
		} 
	}
}
