using UnityEngine;
using System.Collections;

public class shopBgevent :GUIItemsManager {
	public GameObject shopmanager;
	
	public ScreenManager subscreenmanager;
	
	string currentstate;
	
	public GUITexture _outbg;
	
	public GUITexture _backbutton;
	
	public GUITexture _yesbutton;
	
	public GUITexture _outofcoinsbg;
	
	
	public GUITexture plusbutton;
	public GUIText abilitytext;
	public GUIText arrowtext;
	public GUIText bowtext;
	public GUIText buycoinstext;
	public int chekcurrentstate;
	private int comparevar;
	//public bool showoutpage;
	//GameObject tshop ;
	/*public GameObject arrowprefab;
	public GameObject bowprefab;
	public GameObject buycoinsprefab;
	public GameObject stabilityprefab;*/
	private bool checkonetime;
	private bool onetimecall;
//	private bool c
	// Use this for initialization
	void Awake()
	{
		
		if(shopmanager != null)
		
		{//GameObject
			chekcurrentstate=1;
			currentstate="Bow_Button";
			GameObject tshop = GameObject.Instantiate(shopmanager) as GameObject;
			subscreenmanager=tshop.GetComponent<ScreenManager>();
			//subscreenmanager =tshop.gameObject.GetComponent("ScreenManager")as ScreenManager;
			
		}
		/*if( store_currentStatus.instances.loadbuyscreen==true&&tshop!=null)
		{
			currentstate="BuY_coinsbutton";
			plusbutton.gameObject.SetActive(false);
	        chekcurrentstate=3;
		    subscreenmanager.LoadScreen("BUY_coinsPrefab");
			store_currentStatus.instances.loadbuyscreen=false;
		}*/
	}
	void Start () 
	{
	
		base.Init(); 
		//bowprefab.gameObject.SetActive(true);
		
		
		
		
		//comparevar=0;
	/*	if(shopmanager != null)
		
		{//GameObject
			 tshop = GameObject.Instantiate(shopmanager) as GameObject;
			subscreenmanager =tshop.gameObject.GetComponent("ScreenManager")as ScreenManager; //tshop.GetComponent("SpeedThumb")as SpeedThumb;//tshop.GetComponent<ScreenManager>();
		}
		if( store_currentStatus.instances.loadbuyscreen==true&&tshop!=null)
		{
			plusbutton.gameObject.SetActive(false);
	        chekcurrentstate=3;
		    subscreenmanager.LoadScreen("BUY_coinsPrefab");
			store_currentStatus.instances.loadbuyscreen=false;
		}*/
		
		//currentstate="Bow_Button";
	}
	
	void Update()
	{
		///bowtext.text.
		
		
		switch(chekcurrentstate)
		{
			
		case 1: //bowprefab.gameObject.SetActive(true);
			   //stabilityprefab.gameObject.SetActive(false);
			   //arrowprefab.gameObject.SetActive(false);
			   //buycoinsprefab.gameObject.SetActive(false);
			    bowtext.material.color=Color.green;
			    abilitytext.material.color=Color.white;
			    arrowtext.material.color=Color.white;
			    buycoinstext.material.color=Color.white;
			    break;
			
		case 2: //bowprefab.gameObject.SetActive(false);
			   //stabilityprefab.gameObject.SetActive(false);
			  // arrowprefab.gameObject.SetActive(true);
			  // buycoinsprefab.gameObject.SetActive(false);
			    bowtext.material.color=Color.white;
			    abilitytext.material.color=Color.white;
			    arrowtext.material.color=Color.green;
			    buycoinstext.material.color=Color.white;
			    break;
		case 3:// bowprefab.gameObject.SetActive(false);
			  // stabilityprefab.gameObject.SetActive(false);
			  // arrowprefab.gameObject.SetActive(false);
			  // buycoinsprefab.gameObject.SetActive(true);
			    bowtext.material.color=Color.white;
			    abilitytext.material.color=Color.white;
			    arrowtext.material.color=Color.white;
			    buycoinstext.material.color=Color.green;
			    break;
		case 4: 
			    ///bowprefab.gameObject.SetActive(false);
			   ///.gameObject.SetActive(true);
			   //arrowprefab.gameObject.SetActive(false);
			  // buycoinsprefab.gameObject.SetActive(false);
			    bowtext.material.color=Color.white;
			    abilitytext.material.color=Color.green;
			    arrowtext.material.color=Color.white;
			    buycoinstext.material.color=Color.white;
			    break;
		}
			
		
		
		if(store_currentStatus.instances._chekoutofcoins==true)
		{
			_outbg.gameObject.SetActive(true);
			_backbutton.gameObject.SetActive(true);
			_outofcoinsbg.gameObject.SetActive(true);
			_yesbutton.gameObject.SetActive(true);
		}
		if(store_currentStatus.instances._chekoutofcoins==false)
		{
			_outbg.gameObject.SetActive(false);
			_backbutton.gameObject.SetActive(false);
			_outofcoinsbg.gameObject.SetActive(false);
			_yesbutton.gameObject.SetActive(false);
		}
		
	}
	public override void OnSelectedEvent(GUIItem item)
	{
		
		
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			
			if(item.name == "backbutton"&&store_currentStatus.instances._chekoutofcoins==false)
			{
			
				 Debug.Log("----- In Derived class event handle : " + item.name);
				
				 plusbutton.gameObject.SetActive(true);
				
			      store_currentStatus.instances.shop_page=store_currentStatus.ShopPage.first_shop_page;
				  store_currentStatus.instances.shoppagestart=false;
				
				 
			      audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[19];
				 _screenManager.LoadScreen("Archery_First_guiPage");
				  subscreenmanager.closeScreenManager();
			}
			if(item.name == "Bow_Button"&&currentstate!="Bow_Button"&&store_currentStatus.instances._chekoutofcoins==false)
			{
				 plusbutton.gameObject.SetActive(true);
//				 Debug.Log("----- In Derived class event handle : " + item.name);
				 store_currentStatus.instances.shop_page=store_currentStatus.ShopPage.first_shop_page;
				 
				
				 
				  currentstate="Bow_Button";  
				 
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[28];
				chekcurrentstate=1;
				 subscreenmanager.LoadScreen("shopfirstThings");
			}
			if(item.name == "Ablity_button"&&currentstate!="Ablity_button"&&store_currentStatus.instances._chekoutofcoins==false)
			{
			
				 Debug.Log("----- In Derived class event handle : " + item.name);
				
					plusbutton.gameObject.SetActive(true);
//				_screenManager.LoadScreen("Third_shop_page");
		       store_currentStatus.instances.shop_page=store_currentStatus.ShopPage.third_shop_page;
				
				
				currentstate="Ablity_button";
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[28];
				chekcurrentstate=4;
				subscreenmanager.LoadScreen("ShopThirdThings");
				
			}
			if(item.name == "Arrow_button"&&currentstate!="Arrow_button"&&store_currentStatus.instances._chekoutofcoins==false)
			{
			
//				 Debug.Log("----- In Derived class event handle : " + item.name);
//					plusbutton.gameObject.SetActive(true);
//				 
//				_screenManager.LoadScreen("shop_page2");
		       store_currentStatus.instances.shop_page=store_currentStatus.ShopPage.second_shop_page;
				
				
				
				plusbutton.gameObject.SetActive(true);
				
				currentstate="Arrow_button";
				
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[28];
				chekcurrentstate=2;
				subscreenmanager.LoadScreen("shopSecondThings");
			}
				
			if(item.name == "BuY_coinsbutton"&&currentstate!="BuY_coinsbutton"&&store_currentStatus.instances._chekoutofcoins==false)
			{
			     plusbutton.gameObject.SetActive(false);
				 Debug.Log("----- In Derived class event handle : " + item.name);
				
				store_currentStatus.instances.shop_page=store_currentStatus.ShopPage.four_shop_page;
				 
				currentstate="BuY_coinsbutton";
			
			  
				 
			    audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[28];
				chekcurrentstate=3;
				subscreenmanager.LoadScreen("BUY_coinsPrefab");
			}
			
				if(item.name == "plusbutton"&&currentstate!="BuY_coinsbutton")
			{
			
				plusbutton.gameObject.SetActive(false);
				currentstate="BuY_coinsbutton";
				store_currentStatus.instances.shop_page=store_currentStatus.ShopPage.four_shop_page;
				
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[28]; 
				chekcurrentstate=3;
				//if(chekcurrentstate==3)
				subscreenmanager.LoadScreen("BUY_coinsPrefab");
			}
				
				if(item.name == "shopblackbutton")
			{
			
				
				store_currentStatus.instances._chekoutofcoins=false;
				
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[28];
			}
					
				if(item.name == "yesbutton")
			{
			
				store_currentStatus.instances._chekoutofcoins=false;
			    store_currentStatus.instances.shop_page=store_currentStatus.ShopPage.four_shop_page;
				 
				currentstate="BuY_coinsbutton";
			    
				plusbutton.gameObject.SetActive(false);
			  
				 chekcurrentstate=3;
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[28];
				 subscreenmanager.LoadScreen("BUY_coinsPrefab");
			}
			 

		
		
		}
		
		 //audioManager.instances.playcurrentaudio();

	}
	
	
 /*  void Update()
	{
		
		if(store_currentStatus.instances._chekoutofcoins==true)
		{
			_outbg.gameObject.SetActive(true);
			_backbutton.gameObject.SetActive(true);
			_outofcoinsbg.gameObject.SetActive(true);
			_yesbutton.gameObject.SetActive(true);
		}
		if(store_currentStatus.instances._chekoutofcoins==false)
		{
			_outbg.gameObject.SetActive(false);
			_backbutton.gameObject.SetActive(false);
			_outofcoinsbg.gameObject.SetActive(false);
			_yesbutton.gameObject.SetActive(false);
		}
		
			
		
	}*/
}