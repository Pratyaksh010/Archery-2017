using UnityEngine;
using System.Collections;

public class challfirstpage_event:GUIItemsManager
{
	public GameObject gamemanager;
	
	public ScreenManager screenmanager;
	
	public GUITexture _finishedchall1;
	public GUITexture _finishedchall2;
	public GUITexture _finishedchall3;
	private int _completechallenge;
	public GUIText firsttext;
	public GUIText secondtext;
	public GUIText thirdtext;
	
	// Use this for initialization
	void Start () 
	{
	 base.Init();
	 //screenmanager=GameObject.Find("Game_manager")
		 screenmanager=gamemanager.GetComponent<ScreenManager>();
	 //if(PlayerPrefs.GetInt("previouschale")<=PlayerPrefs.GetInt("numberOfChallenge"))
		//{
			
		//}
	 _completechallenge=PlayerPrefs.GetInt("currentchalleneg");//PlayerPrefs.GetInt("numberOfChallenge");
		
	  if( _completechallenge>=1)
		{
		
			   _finishedchall1.gameObject.SetActive(true);
			    store_currentStatus.instances._firstrewards=50;
			    
		}
		if( _completechallenge>=2)
		{
			  store_currentStatus.instances._firstrewards=50;
			  store_currentStatus.instances._secondrewards=50;
			 _finishedchall1.gameObject.SetActive(true);
			 _finishedchall2.gameObject.SetActive(true);
			
		}
		if( _completechallenge>=3)
		{
		      store_currentStatus.instances._firstrewards=50;
			  store_currentStatus.instances._secondrewards=50;
			  store_currentStatus.instances._thirdrewards=50;
			  
			 _finishedchall1.gameObject.SetActive(true);
			 _finishedchall2.gameObject.SetActive(true);
			 _finishedchall3.gameObject.SetActive(true);
		}	
		
		firsttext.text="SCORE\nMORE THAN 50\n WITHIN 10 ARROWS";
		
		secondtext.text="SCORE\nMORE THAN 100\nIN LESS THAN  90 SECONDS";
		
		thirdtext.text="YOU\n HAVE 20 ARROWS,\nSCORE MORE THAN 120";
		
		
	}
	
	
	public override void OnSelectedEvent(GUIItem item)
	{
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			
			if(item.name=="chall1button")
			{ Debug.Log("----- In Derived class event handle : " + item.name);
			   challenge_bgEvent.instances.notdesScript1.challengeSelect=1;
			   challenge_bgEvent.instances.notdesScript1._selectchallenge=1;
			   store_currentStatus.instances.currentscene=3;
			   GamePlugin.ShowAddBanner(false,false);
			  challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
			   screenmanager.LoadScreen("loading_bagground1");
			}
			
			
			if(item.name=="chall2button"&&challenge_bgEvent.instances. _showunlockpage==false)
			{
				  if(_completechallenge>=1)
			  {
				challenge_bgEvent.instances.notdesScript1.challengeSelect=2;
				challenge_bgEvent.instances.notdesScript1._selectchallenge=2;
				challenge_bgEvent.instances.notdesScript1.targetdistance=1;
				
				 store_currentStatus.instances.currentscene=2;
				 GamePlugin.ShowAddBanner(false,false);
				 challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
				
				 screenmanager.LoadScreen("loading_bagground1");
				
			   }
				
			   else
			    {
				     challenge_bgEvent.instances. _showunlockpage=true;	
				      challenge_bgEvent.instances.unlockshow();
			    }
			 
			}
			
			
			if(item.name=="chall3button"&&challenge_bgEvent.instances. _showunlockpage==false)
			{
			    if(_completechallenge>=2)
				{
				 challenge_bgEvent.instances.notdesScript1.challengeSelect=3;
				 challenge_bgEvent.instances.notdesScript1._selectchallenge=3;
			     challenge_bgEvent.instances.notdesScript1.targetdistance=2;
				
				 store_currentStatus.instances.currentscene=2;
				
				
				 challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
				 screenmanager.LoadScreen("loading_bagground1");//"loading_bagground1");
					
					//loading_bagground1
				 GamePlugin.ShowAddBanner(false,false);
					
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
