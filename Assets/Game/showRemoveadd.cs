using UnityEngine;
using System.Collections;

public class showRemoveadd : MonoBehaviour {
	
	public GUIText _showAds ;
	// Use this for initialization
	void Start () 
	{
		if(PlayerPrefs.GetInt("ShowAddsafterPurchase")==0)
		{
			_showAds.GetComponent<GUIText>().text = "Ads Will be Removed On Any Purchase";
		}
		if(PlayerPrefs.GetInt("ShowAddsafterPurchase")==1)
		{
			_showAds.GetComponent<GUIText>().text = "";
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if(_showAds.GetComponent<GUIText>().text!=""&&PlayerPrefs.GetInt("ShowAddsafterPurchase")==1)
		{
			_showAds.GetComponent<GUIText>().text = "";
		}
	}
}
