using UnityEngine;
using System.Collections;

public class defaultScreengen : MonoBehaviour {

	// Use this for initialization
	public ScreenManager Screnscript;
	void Start () 
	{
	 Screnscript=gameObject.GetComponent("ScreenManager")as ScreenManager;
	}
	
	// Update is called once per frame
	void Update () 
	{
	   if(store_currentStatus.instances.loadingshoppage==true)
		{
			Screnscript.defaultScreen="shopBGprefab";
			store_currentStatus.instances.loadingshoppage=false;
		}
	}
}
