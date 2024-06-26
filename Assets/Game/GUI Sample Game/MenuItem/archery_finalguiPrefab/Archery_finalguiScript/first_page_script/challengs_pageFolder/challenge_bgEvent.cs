using UnityEngine;
using System.Collections;

public class challenge_bgEvent :GUIItemsManager 
{
	public GameObject challengemanager;
	
	public ScreenManager subscreenmanager;
	
	public notDestroy notdesScript1;
	
	public static challenge_bgEvent instances;
	
	public GUITexture leftbutton;
	
	public GUITexture rightbutton;
	
	public int currentstate;
	
	public GUITexture _challengebg;
	
	public GUITexture _challengpopup;
	
	public GUITexture _challengebackbutton;
	
	public bool _showunlockpage;
	
	
	
	// Use this for initialization
	void Awake()
	{
			if(challengemanager != null)
		{
			GameObject tshop = GameObject.Instantiate(challengemanager) as GameObject;
			subscreenmanager = tshop.GetComponent<ScreenManager>();
		}
		
		 notdesScript1=GameObject.Find("Nondestroy").GetComponent("notDestroy")as notDestroy;
		   
		 notdesScript1.checkchallengemode=true;
		
	}
	void Start () 
	{ 
		instances=this;
	  
		currentstate=0;
		base.Init(); 
		
		/*if(challengemanager != null)
		{
			GameObject tshop = GameObject.Instantiate(challengemanager) as GameObject;
			subscreenmanager = tshop.GetComponent<ScreenManager>();
		}
		
		 notdesScript1=GameObject.Find("Nondestroy").GetComponent("notDestroy")as notDestroy;
		   
		 notdesScript1.checkchallengemode=true;
		*/
		
		
		rightbutton.gameObject.SetActive(false);
		
	     
	}
	
	public void unlockshow()
	{
		/*
		if(currentstate>=2)
		{
			 leftbutton.color=new Color( leftbutton.color.r, leftbutton.color.g, leftbutton.color.b,0);
			 rightbutton.color=new Color(rightbutton.color.r,rightbutton.color.g,rightbutton.color.b, alpha);
		}
		if(currentstate<=0)
		{
			 rightbutton.color=new Color(rightbutton.color.r,rightbutton.color.g,rightbutton.color.b,0f);
			 leftbutton.color=new Color( leftbutton.color.r, leftbutton.color.g, leftbutton.color.b, alpha);
		}
		if(currentstate==1)
		{
			 rightbutton.color=new Color(rightbutton.color.r,rightbutton.color.g,rightbutton.color.b, alpha);
			 leftbutton.color=new Color( leftbutton.color.r, leftbutton.color.g, leftbutton.color.b, alpha);
		}*/
		if( _showunlockpage)
		{
			 
			_challengebg.gameObject.SetActive(true);
			 _challengpopup.gameObject.SetActive(true);
			_challengebackbutton.gameObject.SetActive(true);
			
			
			
		}
		if( _showunlockpage==false)
		{
			_challengebg.gameObject.SetActive(false);
			 _challengpopup.gameObject.SetActive(false);
			_challengebackbutton.gameObject.SetActive(false);
			
		}
	}
	void Update()
	{
		if (Input.GetKeyUp (KeyCode.Escape) && _showunlockpage==false) 
		{
			GameObject o1 = GameObject.Find("Scrollindicater(Clone)")as GameObject ;
			
			if(o1!=null)
			{
				o1.gameObject.layer = 29 ;
				
			}
			_screenManager.LoadScreen("Archery_First_guiPage");
			
			notdesScript1.checkchallengemode=false;
			
			
			rightbutton.gameObject.SetActive(false);
			
			leftbutton.gameObject.SetActive(false);
			subscreenmanager.closeScreenManager();
			audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[19];
		}
	
	
	}
	public override void OnSelectedEvent(GUIItem item)
	{
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			
			if(item.name == "backbutton"&& _showunlockpage==false)
			{
				   
				 GameObject o1 = GameObject.Find("Scrollindicater(Clone)")as GameObject ;
		          
				   if(o1!=null)
		           {
			           o1.gameObject.layer = 29 ;
			
		           }
				 _screenManager.LoadScreen("Archery_First_guiPage");
				
				 notdesScript1.checkchallengemode=false;
				 
				
				 rightbutton.gameObject.SetActive(false);
				 
				 leftbutton.gameObject.SetActive(false);
				 subscreenmanager.closeScreenManager();
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[19];
			}
			
			if(item.name == "leftbutton"&&currentstate<2&& _showunlockpage==false)
			{
				
				currentstate=currentstate+1;
				
				if(currentstate==1)
				{
				subscreenmanager.LoadScreen("challengsSecondtpage");
			    rightbutton.gameObject.SetActive(true);
				}
				
				if(currentstate==2)
					
				{
					subscreenmanager.LoadScreen("challengsThirdPage");
					leftbutton.gameObject.SetActive(false);
				}
				 audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[19];
			}
			
			if(item.name == "rightbutton"&&currentstate>0&& _showunlockpage==false)
			{
				
				if(currentstate==2)
				{
					subscreenmanager.LoadScreen("challengsSecondtpage");
					
					leftbutton.gameObject.SetActive(true);
			   
				 
				}
				
				if(currentstate==1)
				{
					subscreenmanager.LoadScreen("challengsFirstpage");
					rightbutton.gameObject.SetActive(false);
				
				}
				
				currentstate=currentstate-1;
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[19];
			}
			
		}
		
		
			if(item.name == "challengebackbutton")
			{
				 
				 _showunlockpage=false; 
				 unlockshow();
			    audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[19];
			}
		
		
		 audioManager.instances.playcurrentaudio();
	}
	public override void OnEntryAnimationCompleted ()
	{
		notDestroy.instances.OnShowBannerAds (true,true);
	}
}
