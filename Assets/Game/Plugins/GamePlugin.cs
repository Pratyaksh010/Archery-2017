using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class GamePlugin {

	/* Interface to native implementation */
	
	/*[DllImport ("__Internal")]
	private static extern void _StartLookup (string service, string domain);

	[DllImport ("__Internal")]
	private static extern string _GetLookupStatus ();
	
	[DllImport ("__Internal")]
	private static extern int _GetServiceCount ();
	
	[DllImport ("__Internal")]
	private static extern void _Stop ();
	
	[DllImport ("__Internal")]
	private static extern string _GetServiceName (int serviceNumber);*/

	
	
	
	
	
	////[DllImport("__Internal")]
	/////private static extern void _showChatBoost();
	
	////[DllImport("__Internal")]
////	private static extern void _showAddBanner(bool showBanner,bool onTop);
	


	
	/*[[DllImport("__Internal")]
	private static extern  bool _checkInAppPurchaseAttempts();
	
	[DllImport("__Internal")]
	private static extern bool _checkInAppPurchaseAdds();
	
	
	[DllImport("__Internal")]
	private static extern bool _isLogin();*/
	
	/*[DllImport ("__Internal")]
	private static extern bool _isGameFinish(int network);*/
	
	
	public static bool CheckInAppPurchaseAttempts()
	{
	    return false;	//_checkInAppPurchaseAttempts();
	}
	
	public static bool CheckInAppPurchaseAdds()
	{
	   	return false;
		
	}
	public static bool IsLoggedIn()
	{
		return true;//_isLogin();
	}
    
	public static void ShowChatBoost()
	{
		//_showChatBoost();
		 ///Debug.Log("showChatBoost");
	}
	
	public static void ShowAddBanner(bool showBanner,bool onTop)
	{
	   //_showAddBanner(showBanner,onTop);	
		//Debug.Log("ShowAddBanner");
	}
	
	
	
	
	
}
