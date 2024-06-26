using UnityEngine;
using System.Collections;

public class shopfirstpageEvent :GUIItemsManager
{
	/////public Transform Pauseprefab;
	
	public GUIText firstbowtext;
	
	public GUIText secondbowtext;
	
	public GUIText thirdbowtext;
	
	public int i;
	
	public int curentbowselected;
	
	public GUITexture firstglow;
	public GUITexture secondglow;
	public GUITexture thirdglow;
	
	/////public GameObject shopmanager;
	///////public ScreenManager subscreenmanager;
	//public string firstext;
	
	//public string secondtext;
	
	//public string thirdtext;
	// Use this for initialization
	void Start ()
	{
	  base.Init(); 
	  curentbowselected=PlayerPrefs.GetInt("bowselected");
	 
	  PlayerPrefs.SetInt("bowselected",curentbowselected);
	  //print ("cu=="+curentbowselected);
	  firstbowtext.text="SELECTED";
	  secondbowtext.text="100 COINS";
	  thirdbowtext.text="100 COINS";
		
	
		//if(shopmanager != null)
		//{
			//GameObject tshop = GameObject.Instantiate(shopmanager) as GameObject;
			//subscreenmanager = tshop.GetComponent<ScreenManager>();
		///}
		//subscreenmanager.LoadScreen();
	}
	
	void Update()
	{
		
		if(PlayerPrefs.GetInt("Firstbowactivate")==1&&PlayerPrefs.GetString("Firstbowtext")=="SELECTED"&& PlayerPrefs.GetInt("bowselected")!=0)
		{
			
			firstbowtext.text="ACTIVATE";
			firstbowtext.material.color=Color.red;
			
		}
		if(PlayerPrefs.GetInt("Secondbowactivate")==1&&PlayerPrefs.GetString("Secondbowtext")=="Activate"&& PlayerPrefs.GetInt("bowselected")!=1)
		{
			
			secondbowtext.text="ACTIVATE";
			secondbowtext.material.color=Color.red;
			
		}
		if(PlayerPrefs.GetInt("Thirdbowactivate")==1&&PlayerPrefs.GetString("Thirdbowtext")=="Activate"&& PlayerPrefs.GetInt("bowselected")!=2)
		{
			
			thirdbowtext.text="ACTIVATE";
			thirdbowtext.material.color=Color.red;
			
		}
		
		if(PlayerPrefs.GetInt("bowselected")==0)//&&PlayerPrefs.GetString("Firstbowtext")=="Activate")
		{
			firstbowtext.text="SELECTED";
			firstbowtext.material.color=Color.green;
			store_currentStatus.instances.currentbowtexture=store_currentStatus.instances.bowtexture[0];
			firstglow.gameObject.SetActive(true);
			if(secondglow.gameObject.active==true)
			{
				secondglow.gameObject.SetActive(false);
			}
			if(thirdglow.gameObject.active==true)
			{
				thirdglow.gameObject.SetActive(false);
			}
		}
		if(PlayerPrefs.GetInt("bowselected")==1&&PlayerPrefs.GetString("Secondbowtext")=="Activate")
		{
			secondbowtext.text="SELECTED";
			secondbowtext.material.color=Color.green;
			store_currentStatus.instances.currentbowtexture=store_currentStatus.instances.bowtexture[1];
			secondglow.gameObject.SetActive(true);
			if(firstglow.gameObject.active==true)
			{
				firstglow.gameObject.SetActive(false);
			}
			if(thirdglow.gameObject.active==true)
			{
				thirdglow.gameObject.SetActive(false);
			}
		}
		if(PlayerPrefs.GetInt("bowselected")==2&&PlayerPrefs.GetString("Thirdbowtext")=="Activate")
		{
			thirdbowtext.text="SELECTED";
			thirdbowtext.material.color=Color.green;
			store_currentStatus.instances.currentbowtexture=store_currentStatus.instances.bowtexture[2];
			thirdglow.gameObject.SetActive(true);
			if(firstglow.gameObject.active==true)
			{
				firstglow.gameObject.SetActive(false);
			}
			if(secondglow.gameObject.active==true)
			{
				secondglow.gameObject.SetActive(false);
				
			}
		}
		
	}
	// Update is called once per frame
	
	public override void OnSelectedEvent(GUIItem item)
	{
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			
			
				if(item.name == "firstcostbu"&&store_currentStatus.instances._chekoutofcoins==false)
			{
			
				 Debug.Log("----- In Derived class event handle : " + item.name);
				
				 if(firstbowtext.text=="100 COINS")
				 {
					
					//store_currentStatus.instances.bowpurchase(1);
					
				 }
				 if(firstbowtext.text=="ACTIVATE")
				 {
					curentbowselected=0;
					PlayerPrefs.SetInt("bowselected",curentbowselected);
					
				 }
				 
			
			 
			}
				if(item.name == "Thirdcostbu"&&store_currentStatus.instances._chekoutofcoins==false)
			{
			    
				 Debug.Log("----- In Derived class event handle : " + item.name);
				
				  if(thirdbowtext.text=="100 COINS")
				{
					store_currentStatus.instances.bowpurchase(3);
				}
				 if(thirdbowtext.text=="ACTIVATE")
				 {
					curentbowselected=2;
					PlayerPrefs.SetInt("bowselected",curentbowselected);
					
				 }
			
			}
			if(item.name == "secondcostbu"&&store_currentStatus.instances._chekoutofcoins==false)
			{
			   
				 Debug.Log("----- In Derived class event handle : " + item.name);
				 if(secondbowtext.text=="100 COINS")
				{
					store_currentStatus.instances.bowpurchase(2);
				}
				 
				if(secondbowtext.text=="ACTIVATE")
				 {
					curentbowselected=1;
					PlayerPrefs.SetInt("bowselected",curentbowselected);
					
				 }
				
			}
			
			
        }
		
	}
	
}
