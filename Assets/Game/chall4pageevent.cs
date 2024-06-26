using UnityEngine;
using System.Collections;

public class chall4pageevent:GUIItemsManager 
{public GameObject gamemanager;
	
	public ScreenManager screenmanager;
	private int _completechallenge;
	public GUITexture _finishedchall7;
	public GUITexture _finishedchall8;
	public GUITexture _finishedchall9;
	public GUIText seventext;
	public GUIText eighttext;
	public GUIText ninetext;
	// Use this for initialization
	void Start () 
	{
	   base.Init();
		
		 screenmanager=gamemanager.GetComponent("ScreenManager")as ScreenManager;//GameObject.Find("Game_manager").GetComponent<ScreenManager>();
		_completechallenge=PlayerPrefs.GetInt("currentchalleneg");//PlayerPrefs.GetInt("numberOfChallenge");
    if( _completechallenge>=7)
		{
		       store_currentStatus.instances._sevenrewards=300;
			
			   _finishedchall7.gameObject.SetActive(true);
			 
			
		}
		if( _completechallenge>=8)
		{
			   store_currentStatus.instances._sevenrewards=300;
			  store_currentStatus.instances._eightrewards=700;
			 _finishedchall7.gameObject.SetActive(true);
			 _finishedchall8.gameObject.SetActive(true);
			
		}
		if( _completechallenge>=9)
		{
		      store_currentStatus.instances._sevenrewards=300;
			  store_currentStatus.instances._eightrewards=700;
			  store_currentStatus.instances._ninethrewards=1000;
			 _finishedchall7.gameObject.SetActive(true);
			 _finishedchall8.gameObject.SetActive(true);
			 _finishedchall9.gameObject.SetActive(true);
		}
		seventext.text="YOU HAVE 8 ARROWS SCORE\n EXACTLY 57";////////"BEAT THE OPPONENT \n IN AN  ACTUAL MATCH IN  HEAVY \nWIND CONDITIONS ";
		eighttext.text="HIT\n7,7,7 CONTINOUSLY USING \n4 ARROWS ";//////////"SCORE\n MORE THAN 100\n WITH 12 ARROWS ";
		ninetext.text="HIT THE BULLS EYE\nFIVE TIMES  \nWITHIN 8 ARROWS";
	}
	
	public override void OnSelectedEvent(GUIItem item)
		
	{
	   if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			
			if(item.name=="chall7button"&&challenge_bgEvent.instances. _showunlockpage==false)
			{
				
				
				
				  if(_completechallenge>=6)
				 {
				    challenge_bgEvent.instances.notdesScript1.challengeSelect=5;
				     challenge_bgEvent.instances.notdesScript1._selectchallenge=7;
				    challenge_bgEvent.instances.notdesScript1.targetdistance=1;
				
				    store_currentStatus.instances.currentscene=2;
				
				    challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
				    GamePlugin.ShowAddBanner(false,false);
				    screenmanager.LoadScreen("loading_bagground1");
			       }
				
				  else
				  {
				 	 challenge_bgEvent.instances. _showunlockpage=true;	
					  challenge_bgEvent.instances.unlockshow();
				   }
			
				
				
			}
			
			
			if(item.name=="chall8button"&&challenge_bgEvent.instances. _showunlockpage==false)
			{
			   
				 if(_completechallenge>=7)
			        
			{
				    
				challenge_bgEvent.instances.notdesScript1.challengeSelect=4;
				challenge_bgEvent.instances.notdesScript1._selectchallenge=8;
			    challenge_bgEvent.instances.notdesScript1.targetdistance=2;
				
				store_currentStatus.instances.currentscene=2;
				
				challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
				 GamePlugin.ShowAddBanner(false,false);
				 screenmanager.LoadScreen("loading_bagground1");
		    }
				
		    else
		 {
			 challenge_bgEvent.instances. _showunlockpage=true;	
			  challenge_bgEvent.instances.unlockshow();
				
	    }
			
				
				
				
			}
			
			
			if(item.name=="chall9button"&&challenge_bgEvent.instances._showunlockpage==false)
			{
				  if(_completechallenge>=8)
				 {
				 challenge_bgEvent.instances.notdesScript1.challengeSelect=9;
				 challenge_bgEvent.instances.notdesScript1._selectchallenge=9;
				 challenge_bgEvent.instances.notdesScript1.targetdistance=2;
				
				 store_currentStatus.instances.currentscene=2;
				
				 challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
				 GamePlugin.ShowAddBanner(false,false);
				 screenmanager.LoadScreen("loading_bagground1");
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
