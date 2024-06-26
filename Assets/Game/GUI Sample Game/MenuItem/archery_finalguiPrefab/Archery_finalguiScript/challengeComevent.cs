using UnityEngine;
using System.Collections;

public class challengeComevent :GUIItemsManager 
{
    private int _totalcoins;
	public bool _gamecomplete;
	public GUIText _showscore;
	public int currentch;
	
	// Use this for initialization
	void Start () 
	{
	  base.Init();
		Debug.Log("This is ChallengeScreen");
	if(_gamecomplete)
		
	{
	  
	// PlayerPrefs.SetInt("numberOfChallenge",notDestroy.instances.challengeSelect);
		
		PlayerPrefs.SetInt("numberOfChallenge",notDestroy.instances._selectchallenge);
	    
	   _totalcoins=PlayerPrefs.GetInt("Total_Coins");//,toatlcoins);
		
		if(PlayerPrefs.GetInt("currentchalleneg")<=PlayerPrefs.GetInt("numberOfChallenge"))
			{
				PlayerPrefs.SetInt("currentchalleneg",notDestroy.instances._selectchallenge);
			}
		if(PlayerPrefs.GetInt("currentchalleneg")==0)
			{
				PlayerPrefs.SetInt("currentchalleneg",notDestroy.instances._selectchallenge);
			}
			 
	  switch(notDestroy.instances._selectchallenge)//notDestroy.instances.challengeSelect)
			
		{
		case 1: _totalcoins=_totalcoins+store_currentStatus.instances._firstrewards;
				
			break;
		
		case 2: _totalcoins=_totalcoins+store_currentStatus.instances._secondrewards;
				
			break;
			
		case 3: _totalcoins=_totalcoins+store_currentStatus.instances._thirdrewards;
			
			break;
		
		case 4: _totalcoins=_totalcoins+store_currentStatus.instances._fourthrewards;
				
			break;
		case 5: _totalcoins=_totalcoins+store_currentStatus.instances._tenrewards ;//_fifthrewards;
				
			break;
		
		case 6: _totalcoins=_totalcoins+store_currentStatus.instances._sixthrewards;
				
			break;
			
		case 7: _totalcoins=_totalcoins+store_currentStatus.instances._sevenrewards;
				
			break;
		
		case 8: _totalcoins=_totalcoins+store_currentStatus.instances._eightrewards;
				
			break;
			
		case 9: _totalcoins=_totalcoins+store_currentStatus.instances._ninethrewards;
				
			
			break;
	    case 10: _totalcoins=_totalcoins+store_currentStatus.instances._tenrewards;
				
			
			break;
		case 11: _totalcoins=_totalcoins+store_currentStatus.instances._elvenrewards ;
				
			
			break;
		case 12: _totalcoins=_totalcoins+store_currentStatus.instances._tewelrewards;
				
			
			break;
		case 13: _totalcoins=_totalcoins+store_currentStatus.instances._thirteenrewards;
				
			
			break;
		case 14: _totalcoins=_totalcoins+store_currentStatus.instances._fourteenrewards;
				
			
			break;
		case 15: _totalcoins=_totalcoins+store_currentStatus.instances._fifteenrewards ;
				
			
			break;
				
		}

	 	 PlayerPrefs.SetInt("Total_Coins", _totalcoins);
		}
		
		
	}
	
		public override void OnSelectedEvent(GUIItem item)
	{
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			if(item.name == "home")
			{
			    Debug.Log("----- In Derived class event handle : " + item.name);
		        store_currentStatus.instances.currentscene=1;
				challenge_mode_gui.instances.camanimation.gameObject.SetActive(false);
			   _screenManager.LoadScreen("loading_bagground");
			   audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[19];
			}
			if(item.name=="homeafterchallenge")
			{
				store_currentStatus.instances.currentscene=1;
				challenge_mode_gui.instances.camanimation.gameObject.SetActive(false);
			   _screenManager.LoadScreen("loading_bagground");
			   audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[19];
			}
			if(item.name == "next")
			{
			    store_currentStatus.instances.challengemodecheck=notDestroy.instances.checkchallengemode;
				store_currentStatus.instances.loadingcheck=true;
			  _screenManager.LoadScreen("loading_bagground");
			  challenge_mode_gui.instances.camanimation.gameObject.SetActive(false);
			  audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[19];
			}
			if(item.name=="shop")
			{
				 store_currentStatus.instances.currentscene=1;
				 challenge_mode_gui.instances.camanimation.gameObject.SetActive(false);
				 store_currentStatus.instances.loadingshoppage=true;
			   _screenManager.LoadScreen("loading_bagground");
				////ScreenManager.instances._DefaultScreen="shopBGprefab";
				store_currentStatus.instances._openshop=true;
			//	store_currentStatus.instances.setstring();
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[19];
			}
			if(item.name=="CashPlay")
			{
				ExternalInterfaceHandler.Instance.ExternalBackGroundAds = eEXTERNAL_BackGround_FullAds.Deactivate;
				notDestroy.instances.OnShowFullAds (false,"");
			}
			
		}
		if(item.name=="nextchalenge")
		{
			    store_currentStatus.instances.challengemodecheck=notDestroy.instances.checkchallengemode;
				
				store_currentStatus.instances.loadingcheck=true;
			    gotonextChallenge(challenge_bgEvent.instances.notdesScript1._selectchallenge);
			   _screenManager.LoadScreen("loading_bagground");
			   challenge_mode_gui.instances.camanimation.gameObject.SetActive(false);
			   audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[19];
		}
		audioManager.instances.playcurrentaudio();
	}
	void Update()
	{
		if (Input.GetKeyUp (KeyCode.Escape)) 
		{
			store_currentStatus.instances.currentscene=1;
			challenge_mode_gui.instances.camanimation.gameObject.SetActive(false);
			_screenManager.LoadScreen("loading_bagground");
			audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[19];
		}
		_showscore.text=""+challenge_mode_gui.instances._toatlscore;
	}
	void  gotonextChallenge(int currentchallenge)
	{
		if(currentchallenge<15)
		{
		   switch(currentchallenge)
			{
			    case 1:
				         challenge_bgEvent.instances.notdesScript1.challengeSelect=2;
				         challenge_bgEvent.instances.notdesScript1._selectchallenge=2;
				         challenge_bgEvent.instances.notdesScript1.targetdistance=1;
				         store_currentStatus.instances.currentscene=2;
				break ;
				case 2:
				         challenge_bgEvent.instances.notdesScript1.challengeSelect=3;
				         challenge_bgEvent.instances.notdesScript1._selectchallenge=3;
			             challenge_bgEvent.instances.notdesScript1.targetdistance=2;
				         store_currentStatus.instances.currentscene=2;
				        
				break ;
				case 3:
				      
				         challenge_bgEvent.instances.notdesScript1.challengeSelect=6;
				         challenge_bgEvent.instances.notdesScript1._selectchallenge=4;
					     challenge_bgEvent.instances.notdesScript1.targetdistance=1;
				         store_currentStatus.instances.currentscene=2;
				       
				break ;
				case 4:
				       
					    challenge_bgEvent.instances.notdesScript1.challengeSelect=10;
				        challenge_bgEvent.instances.notdesScript1._selectchallenge=5;
			            challenge_bgEvent.instances.notdesScript1.targetdistance=2;
				        store_currentStatus.instances.currentscene=2;
				         store_currentStatus.instances.currentscene=2;
				                          
				break ;
				case 5:
				        challenge_bgEvent.instances.notdesScript1.challengeSelect=12;
					    challenge_bgEvent.instances.notdesScript1._selectchallenge=6;
						challenge_bgEvent.instances.notdesScript1.targetdistance=1;
		                store_currentStatus.instances.currentscene=2;
				break ;
				case 6:
				        challenge_bgEvent.instances.notdesScript1.challengeSelect = 11 ;
						challenge_bgEvent.instances.notdesScript1._selectchallenge=7;
						challenge_bgEvent.instances.notdesScript1.targetdistance=1;
						store_currentStatus.instances.currentscene=2;
				break ;
				case 7:
				         challenge_bgEvent.instances.notdesScript1.challengeSelect=7;
				         challenge_bgEvent.instances.notdesScript1._selectchallenge=8;
				         challenge_bgEvent.instances.notdesScript1.targetdistance=1;
		                 store_currentStatus.instances.currentscene=2;
				break ;
				case 8:
				        challenge_bgEvent.instances.notdesScript1.challengeSelect=5;
				        challenge_bgEvent.instances.notdesScript1._selectchallenge=9;
				        challenge_bgEvent.instances.notdesScript1.targetdistance=1;
				        store_currentStatus.instances.currentscene=2;
				break ;
				case 9:
				         challenge_bgEvent.instances.notdesScript1.challengeSelect=13;
				         challenge_bgEvent.instances.notdesScript1._selectchallenge=10;
				          challenge_bgEvent.instances.notdesScript1.targetdistance=1;
		                   store_currentStatus.instances.currentscene=2;
				break ;
				case 10:
				        challenge_bgEvent.instances.notdesScript1.challengeSelect=9;
				        challenge_bgEvent.instances.notdesScript1._selectchallenge=11;//12;
				        challenge_bgEvent.instances.notdesScript1.targetdistance=2;
		                store_currentStatus.instances.currentscene=2;
				break ;
				case 11:
				          challenge_bgEvent.instances.notdesScript1.challengeSelect=14;
				          challenge_bgEvent.instances.notdesScript1._selectchallenge=12;
				         challenge_bgEvent.instances.notdesScript1.targetdistance=2;
		                   store_currentStatus.instances.currentscene=2;
				break ;   
				case 12:
				          challenge_bgEvent.instances.notdesScript1.challengeSelect=15;
				           challenge_bgEvent.instances.notdesScript1._selectchallenge=13;
				            challenge_bgEvent.instances.notdesScript1.targetdistance=1;
		                     store_currentStatus.instances.currentscene=2;
				break ;
				case 13:
				         challenge_bgEvent.instances.notdesScript1.challengeSelect=4;
				         challenge_bgEvent.instances.notdesScript1._selectchallenge=14;
			             challenge_bgEvent.instances.notdesScript1.targetdistance=2;
				          store_currentStatus.instances.currentscene=2;
				break ;
				case 14:
				            challenge_bgEvent.instances.notdesScript1.challengeSelect=16;
				            challenge_bgEvent.instances.notdesScript1._selectchallenge=15;
				            challenge_bgEvent.instances.notdesScript1.targetdistance=2;
		                    store_currentStatus.instances.currentscene=2;
				break ;
			
			}
		
		}
	}
}
