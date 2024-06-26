using UnityEngine;
using System.Collections;

public class challengs_secondPageevent :GUIItemsManager 
{
	//public notDestroy notdesScript1;
	// Use this for initialization
	
	public GameObject gamemanager;
	
	public ScreenManager screenmanager;
	
	private int _completechallenge;
	public GUITexture _finishedchall4;
	public GUITexture _finishedchall5;
	public GUITexture _finishedchall6;
	public GUIText fourtext;
	public GUIText fifthtext;
	public GUIText sixthtext;
	void Start () 
	{
		base.Init();
		
		
		 screenmanager=gamemanager.GetComponent("ScreenManager")as ScreenManager;
			//GameObject.Find("Game_manager").GetComponent<ScreenManager>();
		   PlayerPrefs.SetInt("currentchalleneg",9);
		 _completechallenge=PlayerPrefs.GetInt("currentchalleneg");//PlayerPrefs.GetInt("numberOfChallenge");
				 //_completechallenge = 9 ;
		
	 if( _completechallenge>=4)
		{
		       store_currentStatus.instances._fourthrewards=100;
			   _finishedchall4.gameObject.SetActive(true);
			 
			
		}
		if( _completechallenge>=5)
		{
			  store_currentStatus.instances._fourthrewards=100;
			  store_currentStatus.instances._fifthrewards=100;
			 _finishedchall4.gameObject.SetActive(true);
			 _finishedchall5.gameObject.SetActive(true);
			
		}
		if( _completechallenge>=6)
		{
		      store_currentStatus.instances._fourthrewards=100;
			  store_currentStatus.instances._fifthrewards=100;
			  store_currentStatus.instances._sixthrewards=150;
			 _finishedchall4.gameObject.SetActive(true);
			 _finishedchall5.gameObject.SetActive(true);
			 _finishedchall6.gameObject.SetActive(true);
		}	
		fourtext.text="GET SCORE BETWEEN 40 - 50  IN\n LESS THAT 60 SECONDS";
		fifthtext.text="BEAT\n THE OPPONENT IN AN ACTUAL MATCH \nIN HEAVY WIND CONDITIONS ";
		sixthtext.text="SCORE MORE THAN 200\n WITH 12 ARROWS ";
	}
	
	public override void OnSelectedEvent(GUIItem item)
		
	{
	   if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			
			if(item.name=="chall4button"&&challenge_bgEvent.instances. _showunlockpage==false)
			{  
				
				
				  if(_completechallenge>=3)
				 {
				   challenge_bgEvent.instances.notdesScript1.challengeSelect=6;
				   challenge_bgEvent.instances.notdesScript1._selectchallenge=4;
				   store_currentStatus.instances.currentscene=3;
				
				   challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
				
				    screenmanager.LoadScreen("loading_bagground1");
					GamePlugin.ShowAddBanner(false,false);
				  }
				
				  else
				  {
				         challenge_bgEvent.instances. _showunlockpage=true;	
					      challenge_bgEvent.instances.unlockshow();
				   }
				
			
				
			}
			
			
			if(item.name=="chall5button"&&challenge_bgEvent.instances. _showunlockpage==false)
			{
				
				
				 if(_completechallenge>=4) 
				{
				 challenge_bgEvent.instances.notdesScript1.challengeSelect=7;
				 challenge_bgEvent.instances.notdesScript1._selectchallenge=5;
				  challenge_bgEvent.instances.notdesScript1.targetdistance=1;
				
			     store_currentStatus.instances.currentscene=2;
				 
				 challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
				
			    screenmanager.LoadScreen("loading_bagground1");
				 GamePlugin.ShowAddBanner(false,false);
				}
				
			 else
				{
					 challenge_bgEvent.instances. _showunlockpage=true;	
					  challenge_bgEvent.instances.unlockshow();
				 }
				     
			}
			
			
			if(item.name=="chall6button"&&challenge_bgEvent.instances. _showunlockpage==false)
			{
				  
				if(_completechallenge>=5) 
				{
				 
					challenge_bgEvent.instances.notdesScript1.challengeSelect=8;
				    challenge_bgEvent.instances.notdesScript1._selectchallenge=6;
			       
				   store_currentStatus.instances.currentscene=3;
				
				 GamePlugin.ShowAddBanner(false,false);
				screenmanager.LoadScreen("loading_bagground1");
				  challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
				
				 
				}
				
				else
				  {
					  challenge_bgEvent.instances. _showunlockpage=true;
					  challenge_bgEvent.instances.unlockshow();
				 }
			}
			
			
		}
		
	}
	

}
