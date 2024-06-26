using UnityEngine;
using System.Collections;

public class CoinsManager :GUIItemsManager
{
		//public GUITexture plusbutton;
		private int _currentcoins;
		private int selectedbutton;
		public GameObject _PointDistribution;
		public GameObject _AlphaImg;
		public GameObject _ClosePointDestribution;
		public GameObject _TutorialBackBtn;
		public GUITexture _PointDestributionImg;
		private int mCode;
		// Use this for initialization
		void Start ()
		{
				base.Init ();
				_currentcoins = PlayerPrefs.GetInt ("Total_Coins");
		
				Debug.Log ("<-----Coins Manager----->");
				if (transform.name == "helppage(Clone)") {	
						_PointDistribution.SetActive (false);
						_ClosePointDestribution.SetActive (false);
						_AlphaImg .SetActive (false);
						_TutorialBackBtn .SetActive (true);
						mCode = -1;
						FadeInOutClickImage ();
				}
		}
	
		
		void FadeInOutClickImage ()
		{

				_PointDestributionImg.color = new Color (_PointDestributionImg.color.r, _PointDestributionImg.color.g, _PointDestributionImg.color.b, _PointDestributionImg.color.a + .1f * mCode);
				if (_PointDestributionImg.color.a < 0.0001f) {
						mCode = 1;
				} else if (_PointDestributionImg.color.a > .9f) {
						mCode = -1;
				}
				StartCoroutine (OccilateAlpha (.01f));
		}
		IEnumerator OccilateAlpha (float pTime)
		{
				yield return new WaitForSeconds (pTime);
				FadeInOutClickImage ();
				
		}

		void Update()
		{
				if (Input.GetKeyUp (KeyCode.Escape))
				{
						_screenManager.LoadScreen ("Archery_First_guiPage");
				}
		}
		public override void OnSelectedEvent (GUIItem item)
		{
				if (meState == eGUI_ITEMS_MANAGER_STATE.Settled) {
						if (item.name == "BackButtonBuy") {
								_screenManager.LoadScreen ("Archery_First_guiPage");
						}
						if (item.name == "ShowPointBtn") {
								_PointDistribution.SetActive (true);
								_ClosePointDestribution.SetActive (true);
								_AlphaImg .SetActive (true);
								_TutorialBackBtn .SetActive (false);

						}
						if (item.name == "ClosePointBtn") {
								_PointDistribution.SetActive (false);
								_ClosePointDestribution.SetActive (false);
								_AlphaImg .SetActive (false);
								_TutorialBackBtn .SetActive (true);

						}
						if (item.name == "BackButtonHelp") {
								_screenManager.LoadScreen ("Archery_First_guiPage");
						}
			
						if (item.name == "firstbutton") {
								ExternalInterfaceHandler.Instance.SendRequest (eEXTERNAL_REQ_TYPE.InAppConsumable, "1", UpdateReceivedStatus);
								// XcodePopups.Addcoins(1,"2000");
				 
								selectedbutton = 1;
						}
						if (item.name == "secondbutton") {
								// XcodePopups.Addcoins(2,"5000");
								ExternalInterfaceHandler.Instance.SendRequest (eEXTERNAL_REQ_TYPE.InAppConsumable, "2", UpdateReceivedStatus);
								selectedbutton = 2;
						}
						if (item.name == "thirdbutton") {
								// XcodePopups.Addcoins(3,"12000");
								ExternalInterfaceHandler.Instance.SendRequest (eEXTERNAL_REQ_TYPE.InAppConsumable, "3", UpdateReceivedStatus);
								selectedbutton = 3;
						}
						if (item.name == "fourbutton") {
								//XcodePopups.Addcoins(4,"25000");
								ExternalInterfaceHandler.Instance.SendRequest (eEXTERNAL_REQ_TYPE.InAppConsumable, "4", UpdateReceivedStatus);
								selectedbutton = 4;
						}
						if (item.name == "fifthbuttton") {
								// XcodePopups.Addcoins(5,"60000");
								ExternalInterfaceHandler.Instance.SendRequest (eEXTERNAL_REQ_TYPE.InAppConsumable, "5", UpdateReceivedStatus);
								selectedbutton = 5;
						}
				}
		}
	public override void OnEntryAnimationCompleted ()
	{
		if(transform.name.Equals("BUY_coinsPrefab(Clone)"))
		notDestroy.instances.OnShowBannerAds (true,true);
	}
	public override void OnExitAnimationCompleted ()
	{

	}
		public void PurchaseCallBack (string pSting)
		{
				if (pSting == "PurchaseFailed") {
						Debug.Log ("Purchase failed");
				} else if (pSting == "PurchaseCoins") {
						switch (selectedbutton) {
						case 1:
								_currentcoins = PlayerPrefs.GetInt ("Total_Coins");
								_currentcoins = _currentcoins + 2000;
								break;
						case 2:
								_currentcoins = PlayerPrefs.GetInt ("Total_Coins");
								_currentcoins = _currentcoins + 5000;
								break;
						case 3:
								_currentcoins = PlayerPrefs.GetInt ("Total_Coins");
								_currentcoins = _currentcoins + 12000;
								break;
						case 4:
								_currentcoins = PlayerPrefs.GetInt ("Total_Coins");
								_currentcoins = _currentcoins + 25000;
								break;
						case 5:
								_currentcoins = PlayerPrefs.GetInt ("Total_Coins");
								_currentcoins = _currentcoins + 60000;
								break;			
						}
				}
			
				PlayerPrefs.SetInt ("Total_Coins", _currentcoins);	
				Debug.Log ("Purchase " + "" + _currentcoins);	
		  
		}
		public void UpdateReceivedStatus (eEXTERNAL_REQ_TYPE requestType, string requestedID, string result)
		{
				if (result == "true") {
						PlayerPrefs.SetInt ("ShowAdds", 1);
						switch (requestType) {
						case eEXTERNAL_REQ_TYPE.InAppNonConsumable:
								{
										// put condition to remove ads
				      
				      
				
								}
								break;
						case eEXTERNAL_REQ_TYPE.InAppConsumable:
								{
										switch (requestedID) {
										case "1":
												addCoins (2000);
												break;
										case "2":
												addCoins (5000);
												break;
										case "3":
												addCoins (10000);
												break;
										case "4":
												addCoins (20000);
												break;
										case "5":
												addCoins (50000);
												break;
										case "6":
					   
												break;
										case "7":
					   
												break;
										}
								}
								break;
						}
			
				}
		}
	
		void addCoins (int coins)
		{
				PlayerPrefs.SetInt ("ShowAddsafterPurchase", 1);
				_currentcoins = PlayerPrefs.GetInt ("Total_Coins");
				_currentcoins = _currentcoins + coins;
				PlayerPrefs.SetInt ("Total_Coins", _currentcoins);	
		}
}
