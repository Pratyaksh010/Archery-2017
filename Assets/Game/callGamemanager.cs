using UnityEngine;
using System.Collections;

public class callGamemanager:MonoBehaviour
{
	public GameObject GameManger;

    public ScreenManager Screnscript;

	// Use this for initialization
	void Start ()
	{
		
		notDestroy.instances._activeArrowPopUp = false ;
	    
		Screnscript=GameManger.GetComponent("ScreenManager")as ScreenManager;
		
		if(store_currentStatus.instances.loadingshoppage==true)
		{
			 Screnscript.LoadScreen("shopBGprefab");
			
			 store_currentStatus.instances.loadingshoppage=false;
		}
		else
		{
			
			Screnscript.LoadScreen("Archery_First_guiPage");
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
