using UnityEngine;
using System.Collections;

public class Scrolling : ScrollAndPaging 
{
	public GUIText[] _ChallengeText ;
	private int _completechallenge;
	public GameObject gamemanager;
	
	public ScreenManager screenmanager;
	
	public GUITexture _challengebg;
	
	public GUITexture _challengpopup;
	
	public GUITexture _challengebackbutton;
	
	public Transform _changeScroll ;
	// Use this for initialization
	void Awake () 
	{
		 base.InitScroll();
		 screenmanager=gamemanager.GetComponent<ScreenManager>();
		_ChallengeText[0].text = ""+"SCORE MORE THAN 75  WITHIN 12 ARROWS";
		_ChallengeText[1].text = "   "+"SCORE MORE THAN 150 IN LESS THAN \n90 SECONDS";
		_ChallengeText[2].text = " "+"YOU HAVE 20 ARROWS SCORE MORE THAN\n 150";
		_ChallengeText[3].text = "   "+"GET SCORE BETWEEN 80-90 WITHIN 60 SECONDS";
		_ChallengeText[4].text = ""+"GET SCORE BETWEEN 60-65 IN WITHIN \n7 ARROWS";
		_ChallengeText[5].text = ""+"GET SCORE 0 WITHIN 10 ARROWS IN \nHEAVY WIND CONDITIONS";//"GET SCORE EXACTLY 57 WITH 8 ARROWS";
		_ChallengeText[6].text = ""+"GET SCORE 151 WITHIN 10 ARROWS";
		_ChallengeText[7].text = ""+"BEAT THE OPPONENT IN AN ACTUAL \nMATCH IN HEAVY WIND CONDITIONS ";
		_ChallengeText[8].text = ""+"GET SCORE EXACTLY 57 WITH 8 ARROWS";//"GET SCORE 0 WITHIN 10 ARROWS IN \nHEAVY WIND CONDITIONS";
		_ChallengeText[9].text = "     "+"GET SCORE EXACTLY 60 WITHIN 2  6X ARROWS\n HEAVY WIND CONDITIONS";
		_ChallengeText[10].text = ""+"HIT THE BULLS EYE FIVE TIMES\nWITHIN 8 ARROWS";//"HIT 7,7,7 CONTINUOUSLY USING\n4 ARROWS ";
		_ChallengeText[11].text = ""+"SCORE MORE THAN 42 WITHIN 4 2XARROWS";//"HIT THE BULLS EYE FIVE TIMES\nWITHIN 8 ARROWS";
		_ChallengeText[12].text = ""+"HIT THE BULLS EYE THREE TIMES\nWITHIN 3  6X ARROWS";//"SCORE MORE THAN 42 WITHIN 4 2XARROWS";
		_ChallengeText[13].text = ""+"HIT 7,7,7 CONTINUOUSLY USING\n4 ARROWS ";//"HIT THE BULLS EYE THREE TIMES\nWITHIN 3  6X ARROWS";
		_ChallengeText[14].text = ""+"GET MORE THAN 600 WITH 20 arrows" ;
		_completechallenge=PlayerPrefs.GetInt("currentchalleneg");
		 StartCoroutine(Example());
		
		
		
		
		//////////////////////////////////////////////////////////_completechallenge = 7 ;
	}
	
	// Update is called once per frame
	public override void OnSelectedEvent(GUIItem item)
	{				
		
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			if(item.name == "challengebackbutton")
			{
				 
				  challenge_bgEvent.instances. _showunlockpage=false;
				  unlockshow();
			    //audioManager.instances._currentaudio.audio.clip=audioManager.instances._audioclip[19];
			}
			if(item.name == "chall1button"&&challenge_bgEvent.instances. _showunlockpage==false)
			{
				if(PlayerPrefs.GetInt("challenge1")==1)
				{
				  store_currentStatus.instances._firstrewards=100;
				}
				challenge_bgEvent.instances.notdesScript1.challengeSelect=1;
			    challenge_bgEvent.instances.notdesScript1._selectchallenge=1;
				challenge_bgEvent.instances.notdesScript1.targetdistance=1;
			    store_currentStatus.instances.currentscene=2;
			    challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
			    screenmanager.LoadScreen("loading_bagground1");
		    }
			else
			{
				if(item.name == "chall2button"&&challenge_bgEvent.instances. _showunlockpage==false)
				{
					  if(_completechallenge>=1)
			          {
				         challenge_bgEvent.instances.notdesScript1.challengeSelect=2;
				         challenge_bgEvent.instances.notdesScript1._selectchallenge=2;
				         challenge_bgEvent.instances.notdesScript1.targetdistance=1;
				         store_currentStatus.instances.currentscene=2;
				       //  GamePlugin.ShowAddBanner(false,false);
				         challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
			             screenmanager.LoadScreen("loading_bagground1");
				
			          }
				
			          else
			          {
				           // challenge_bgEvent.instances. _showunlockpage=true;	
				            unlockshow();
			           }
			 
					   if(PlayerPrefs.GetInt("challenge2")==1)
				        {
				             store_currentStatus.instances._secondrewards=100;
				        }
					
				}
				else
				{
					if(item.name == "chall3button"&&challenge_bgEvent.instances. _showunlockpage==false)
				   {
					 
						  if(_completechallenge>=2)
				          {
				            challenge_bgEvent.instances.notdesScript1.challengeSelect=3;
				            challenge_bgEvent.instances.notdesScript1._selectchallenge=3;
			                challenge_bgEvent.instances.notdesScript1.targetdistance=2;
				            store_currentStatus.instances.currentscene=2;
				            challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
				            screenmanager.LoadScreen("loading_bagground1");//"loading_bagground1");
					       }
			               else
					
				           {
			  	                // challenge_bgEvent.instances. _showunlockpage=true;	
					             unlockshow();
				           }
						  if(PlayerPrefs.GetInt("challenge3")==1)
				          {
				                  store_currentStatus.instances._thirdrewards = 100 ;
				          }
						 
				   }
				   else
				   {
					  if(item.name == "chall4button"&&challenge_bgEvent.instances. _showunlockpage==false)
				     {  
							if(_completechallenge>=3)
				           {
				               challenge_bgEvent.instances.notdesScript1.challengeSelect=6;
				               challenge_bgEvent.instances.notdesScript1._selectchallenge=4;
							   challenge_bgEvent.instances.notdesScript1.targetdistance=1;
				               store_currentStatus.instances.currentscene=2;
				               challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
				               screenmanager.LoadScreen("loading_bagground1");
							}
							else
				            {
				                // challenge_bgEvent.instances. _showunlockpage=true;	
					             unlockshow();
				            }
				           if(PlayerPrefs.GetInt("challenge4")==1)
				            {
				                 store_currentStatus.instances._fourthrewards = 100 ;
				            }
							
				     }
					 else
					 {
						if(item.name == "chall5button"&&challenge_bgEvent.instances. _showunlockpage==false)
						{
								if(_completechallenge>=4) 
				                  {
									      challenge_bgEvent.instances.notdesScript1.challengeSelect=10;
				                          challenge_bgEvent.instances.notdesScript1._selectchallenge=5;
			                              challenge_bgEvent.instances.notdesScript1.targetdistance=2;
				                          store_currentStatus.instances.currentscene=2;
				                          challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
				                          screenmanager.LoadScreen("loading_bagground1");//"loading_bagground1");
				                  
				
				                  }
			                      else
				                  {
					                 // challenge_bgEvent.instances. _showunlockpage=true;	
					                  unlockshow();
				                  }
								if(PlayerPrefs.GetInt("challenge5")==1)
				                {
				                 store_currentStatus.instances._fifthrewards = 100 ;
				                }
								
						}
						else
						{
							if(item.name == "chall6button"&&challenge_bgEvent.instances. _showunlockpage==false)
						    {
								 if(_completechallenge>=5) 
				                  {
									challenge_bgEvent.instances.notdesScript1.challengeSelect=12;
								    challenge_bgEvent.instances.notdesScript1._selectchallenge=6;
									challenge_bgEvent.instances.notdesScript1.targetdistance=1;
		                            store_currentStatus.instances.currentscene=2;
				                    challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
			                        screenmanager.LoadScreen("loading_bagground1");
										
				                      /* challenge_bgEvent.instances.notdesScript1.challengeSelect=5;
				                       challenge_bgEvent.instances.notdesScript1._selectchallenge=6;
				                       challenge_bgEvent.instances.notdesScript1.targetdistance=1;
				                       store_currentStatus.instances.currentscene=2;
			                           challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
				                       screenmanager.LoadScreen("loading_bagground1");*/
					             
									}
								 else
				                  {
					                // challenge_bgEvent.instances. _showunlockpage=true;
					                 unlockshow();
				                  }
								 if(PlayerPrefs.GetInt("challenge6")==1)
				                  {
				                      store_currentStatus.instances._sixthrewards = 50;//100 ;
				                  }
								
						    }	
							else
							{
								if(item.name == "chall7button"&&challenge_bgEvent.instances. _showunlockpage==false)
						        {
								    if(_completechallenge>=6)
				                    {
											
										challenge_bgEvent.instances.notdesScript1.challengeSelect = 11 ;
										challenge_bgEvent.instances.notdesScript1._selectchallenge=7;
										challenge_bgEvent.instances.notdesScript1.targetdistance=1;
										store_currentStatus.instances.currentscene=2;
										challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
										screenmanager.LoadScreen("loading_bagground1");
				                     
			                        }
									else
				                    {
				 	                    //challenge_bgEvent.instances. _showunlockpage=true;	
					                    unlockshow();
				                    }
									if(PlayerPrefs.GetInt("challenge7")==1)
				                    {
				                    store_currentStatus.instances._sevenrewards= 1200 ;
				                    }
									
						        }
							    else
								{
									if(item.name == "chall8button"&&challenge_bgEvent.instances. _showunlockpage==false)
						            {
								        	 if(_completechallenge>=7)
			        
			                                 { 
												    challenge_bgEvent.instances.notdesScript1.challengeSelect=7;
				                                    challenge_bgEvent.instances.notdesScript1._selectchallenge=8;
				                                    challenge_bgEvent.instances.notdesScript1.targetdistance=1;
		                                            store_currentStatus.instances.currentscene=2;
				                                    challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
			                                        screenmanager.LoadScreen("loading_bagground1");
				
				                               /// challenge_bgEvent.instances.notdesScript1.challengeSelect=4;
				                               /// challenge_bgEvent.instances.notdesScript1._selectchallenge=8;
			                                   /// challenge_bgEvent.instances.notdesScript1.targetdistance=2;
				                               //// store_currentStatus.instances.currentscene=2;
			                                    ///challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
				                               // screenmanager.LoadScreen("loading_bagground1");
		                                     }
				
		                                    else
		                                     {
			                                    // challenge_bgEvent.instances. _showunlockpage=true;	
			                                     unlockshow();
				
	                                         }
										if(PlayerPrefs.GetInt("challenge8")==1)
				                        {
				                         store_currentStatus.instances._eightrewards= 100;
				                        }
										
						            }
									else
									{
										if(item.name == "chall9button"&&challenge_bgEvent.instances. _showunlockpage==false)
						                {
								              if(_completechallenge>=8)
				                              {
													
														challenge_bgEvent.instances.notdesScript1.challengeSelect=5;
				                                        challenge_bgEvent.instances.notdesScript1._selectchallenge=9;
				                                        challenge_bgEvent.instances.notdesScript1.targetdistance=1;
				                                        store_currentStatus.instances.currentscene=2;
			                                            challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
				                                        screenmanager.LoadScreen("loading_bagground1");
				                                   
													/*challenge_bgEvent.instances.notdesScript1.challengeSelect=12;
													challenge_bgEvent.instances.notdesScript1._selectchallenge=9;
													challenge_bgEvent.instances.notdesScript1.targetdistance=1;
		                                            store_currentStatus.instances.currentscene=2;
				                                   challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
			                                       screenmanager.LoadScreen("loading_bagground1");*/
				                               
				                               }
				
				                               else
				                                {
					                              // challenge_bgEvent.instances. _showunlockpage=true;	
					                               unlockshow();
				                                 }
											 if(PlayerPrefs.GetInt("challenge9")==1)
				                             { 
				                                 store_currentStatus.instances._ninethrewards= 100;
				                             }
											
						                }
										else
										{
											if(item.name == "chall10button"&&challenge_bgEvent.instances. _showunlockpage==false)
						                    {
												 if(_completechallenge>=9)
												 {
													challenge_bgEvent.instances.notdesScript1.challengeSelect=13;
				                                    challenge_bgEvent.instances.notdesScript1._selectchallenge=10;
				                                    challenge_bgEvent.instances.notdesScript1.targetdistance=1;
		                                            store_currentStatus.instances.currentscene=2;
				                                    challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
			                                        screenmanager.LoadScreen("loading_bagground1");
												 }
												else
												{
														// challenge_bgEvent.instances. _showunlockpage=true;	
					                                     unlockshow();
												}
								                 if(PlayerPrefs.GetInt("challenge10")==1)
				                                 { 
				                                     store_currentStatus.instances._tenrewards= 2200;
				                                 }
												
						                    }
											else
											{
												if(item.name == "chall11button"&&challenge_bgEvent.instances. _showunlockpage==false)
						                        {
													if(_completechallenge>=10)
													{
															challenge_bgEvent.instances.notdesScript1.challengeSelect=9;
				                                            challenge_bgEvent.instances.notdesScript1._selectchallenge=11;//12;
				                                            challenge_bgEvent.instances.notdesScript1.targetdistance=2;
		                                                    store_currentStatus.instances.currentscene=2;
				                                            challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
			                                                screenmanager.LoadScreen("loading_bagground1");
								                      /* challenge_bgEvent.instances.notdesScript1.challengeSelect=4;
				                                       challenge_bgEvent.instances.notdesScript1._selectchallenge=11;
			                                           challenge_bgEvent.instances.notdesScript1.targetdistance=2;
				                                       store_currentStatus.instances.currentscene=2;
			                                           challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
				                                       screenmanager.LoadScreen("loading_bagground1"); */
													}
												    else
												    {
													  // challenge_bgEvent.instances. _showunlockpage=true;	
					                                   unlockshow();
												    }
													if(PlayerPrefs.GetInt("challenge11")==1)
				                                   { 
				                                     store_currentStatus.instances._elvenrewards= 500;
				                                   }
													
						                        }	
													
												else
												{   
													if(item.name == "chall12button"&&challenge_bgEvent.instances. _showunlockpage==false)
						                             {
														 if(_completechallenge>=11)
				                                         {
															challenge_bgEvent.instances.notdesScript1.challengeSelect=14;
				                                            challenge_bgEvent.instances.notdesScript1._selectchallenge=12;
				                                             challenge_bgEvent.instances.notdesScript1.targetdistance=2;
		                                                      store_currentStatus.instances.currentscene=2;
				                                               challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
			                                                    screenmanager.LoadScreen("loading_bagground1");
													      /*  challenge_bgEvent.instances.notdesScript1.challengeSelect=9;
				                                            challenge_bgEvent.instances.notdesScript1._selectchallenge=12;
				                                            challenge_bgEvent.instances.notdesScript1.targetdistance=2;
		                                                    store_currentStatus.instances.currentscene=2;
				                                            challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
			                                                screenmanager.LoadScreen("loading_bagground1");*/
				                                          }
				                                         else
				                                          {
					                                         // challenge_bgEvent.instances. _showunlockpage=true;	
					                                          unlockshow();
				                                          }
															
								                          if(PlayerPrefs.GetInt("challenge12")==1)
														  {
														     store_currentStatus.instances._tewelrewards=2000;
														  }
						                             }
													else
													 {
														if(item.name == "chall13button"&&challenge_bgEvent.instances. _showunlockpage==false)
						                                {
								                               if(_completechallenge>=12)
				                                                {
																   challenge_bgEvent.instances.notdesScript1.challengeSelect=15;
				                                                   challenge_bgEvent.instances.notdesScript1._selectchallenge=13;
				                                                   challenge_bgEvent.instances.notdesScript1.targetdistance=1;
		                                                           store_currentStatus.instances.currentscene=2;
				                                                   challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
			                                                       screenmanager.LoadScreen("loading_bagground1");
																   /*challenge_bgEvent.instances.notdesScript1.challengeSelect=14;
				                                                   challenge_bgEvent.instances.notdesScript1._selectchallenge=13;
				                                                   challenge_bgEvent.instances.notdesScript1.targetdistance=2;
		                                                           store_currentStatus.instances.currentscene=2;
				                                                   challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
			                                                       screenmanager.LoadScreen("loading_bagground1");*/
																}
																else
				                                               {
					                                               //challenge_bgEvent.instances. _showunlockpage=true;	
					                                               unlockshow();
				                                               }
																if(PlayerPrefs.GetInt("challenge13")==1)
														        {
																  store_currentStatus.instances. _thirteenrewards= 3500;
																}
						                                }
														else
														{
															if(item.name == "chall14button"&& challenge_bgEvent.instances. _showunlockpage==false)
						                                    {
								                                if(_completechallenge>=13)
				                                                {
																		  challenge_bgEvent.instances.notdesScript1.challengeSelect=4;
				                                                          challenge_bgEvent.instances.notdesScript1._selectchallenge=14;
			                                                              challenge_bgEvent.instances.notdesScript1.targetdistance=2;
				                                                          store_currentStatus.instances.currentscene=2;
			                                                              challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
				                                                          screenmanager.LoadScreen("loading_bagground1"); 
																   /*challenge_bgEvent.instances.notdesScript1.challengeSelect=15;
				                                                   challenge_bgEvent.instances.notdesScript1._selectchallenge=14;
				                                                   challenge_bgEvent.instances.notdesScript1.targetdistance=1;
		                                                           store_currentStatus.instances.currentscene=2;
				                                                   challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
			                                                       screenmanager.LoadScreen("loading_bagground1");*/
																}
																else
				                                                {
					                                            //  challenge_bgEvent.instances. _showunlockpage=true;	
					                                              unlockshow();
				                                                }
																if(PlayerPrefs.GetInt("challenge14")==1)
														        {
																   store_currentStatus.instances._fourteenrewards=500;//3500;
																}
						                                    }
															else
														    {
															  if(item.name == "chall15button"&& challenge_bgEvent.instances. _showunlockpage==false)
						                                      {
								                                      if(_completechallenge>=14)
																		{
																		 challenge_bgEvent.instances.notdesScript1.challengeSelect=16;
				                                                         challenge_bgEvent.instances.notdesScript1._selectchallenge=15;
				                                                         challenge_bgEvent.instances.notdesScript1.targetdistance=2;
		                                                                 store_currentStatus.instances.currentscene=2;
				                                                         challenge_bgEvent.instances.subscreenmanager.closeScreenManager();
			                                                             screenmanager.LoadScreen("loading_bagground1");
																        }
																       else
				                                                        {
					                                                       //challenge_bgEvent.instances. _showunlockpage=true;	
					                                                       unlockshow();
				                                                        }
																		
																	    if(PlayerPrefs.GetInt("challenge15")==1)
														               {
																		store_currentStatus.instances._fifteenrewards = 12000;
																	   }
						                                      }
															}
														}
													 }
												}
											}
										}
									}
								}
							}
						}
					 }
					
				   }
				}
				
			}
			
		}
	}
	public void unlockshow()
	{
		
		if( challenge_bgEvent.instances. _showunlockpage)
		{
			 
		//	_challengebg.gameObject.SetActive(true);
			// _challengpopup.gameObject.SetActive(true);
		//	_challengebackbutton.gameObject.SetActive(true);
			
			
			
		}
		if( challenge_bgEvent.instances. _showunlockpage==false)
		{
		//	_challengebg.gameObject.SetActive(false);
			//// _challengpopup.gameObject.SetActive(false);
			//_challengebackbutton.gameObject.SetActive(false);
			
		}
	}
	
	
      IEnumerator Example() 
	{
       
        yield return new WaitForSeconds(.15f);
		
		GameObject o1 = GameObject.Find("Scrollindicater(Clone)")as GameObject ;
		if(o1!=null)
		{
			o1.gameObject.layer = 31 ;
			
		}
    }

}