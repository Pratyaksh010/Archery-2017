using UnityEngine;
using System.Collections;

public class powerUp_event :GUIItemsManager
{

		// Use this for initialization

		public GUIText firstarrowvalue;
	
		public GUIText secondarrowvalue;
	
		public GUIText Thirdarrowvalue;
	
		int currentfirstarrowvalue;
	
		int currentsecondarrowvalue;
	
		int currentthirdarrowvalue;
	
		int firstarrowstore;
	
		int secondarrowstore;
	
		int thirdarrowstore;
	
		bool firstarr;
	
		bool secondarr;
	
		bool thirdarr;
	
		int i;
	
		public GUITexture _firstglow;
	
		public GUITexture _secondglow;
	
		public GUITexture _thirdglow;
	
	
		void Start ()
		{
				base.Init (); 
	

		
				store_currentStatus.instances.offcontrolling = true;
				challenge_Controll.instances.secondpowerup = transform;
				controll.instance.secondpowerup = transform;
				challenge_Controll.instances.setgravity (0);
		
				controll.instance.setgravity (0);
		
				if (store_currentStatus.instances.Realasearrow == false) {
						if (store_currentStatus.instances.resetarrowvalue == 1) {
				
								i = PlayerPrefs.GetInt ("Firstnumberofarrow");
								i = i + 1;
								print ("i=" + i);
								PlayerPrefs.SetInt ("Firstnumberofarrow", i);
								store_currentStatus.instances.resetarrowvalue = 0;
						}
			
						if (store_currentStatus.instances.resetarrowvalue == 2) {
				
								i = PlayerPrefs.GetInt ("Secondnumberofarrow");
								i = i + 1;
								PlayerPrefs.SetInt ("Secondnumberofarrow", i);
								store_currentStatus.instances.resetarrowvalue = 0;
						}
			
			
						if (store_currentStatus.instances.resetarrowvalue == 3) {
				
								i = PlayerPrefs.GetInt ("Thirdnumberofarrow");
								i = i + 1;
								PlayerPrefs.SetInt ("Thirdnumberofarrow", i);
								store_currentStatus.instances.resetarrowvalue = 0;
			
						}
			
			
			
			
				}
				currentfirstarrowvalue = PlayerPrefs.GetInt ("Firstnumberofarrow");
				firstarrowvalue.text = "" + currentfirstarrowvalue;
				currentsecondarrowvalue = PlayerPrefs.GetInt ("Secondnumberofarrow");
				secondarrowvalue.text = "" + currentsecondarrowvalue;
				currentthirdarrowvalue = PlayerPrefs.GetInt ("Thirdnumberofarrow");
				firstarrowstore = PlayerPrefs.GetInt ("Firstnumberofarrow");
				secondarrowstore = PlayerPrefs.GetInt ("Secondnumberofarrow");
				thirdarrowstore = PlayerPrefs.GetInt ("Thirdnumberofarrow");
				Thirdarrowvalue.text = "" + currentthirdarrowvalue;
				if (PlayerPrefs.GetInt ("currentbow") == 1 && PlayerPrefs.GetInt ("Firstnumberofarrow") > 0) {
						_firstglow.gameObject.SetActive(true);
						_secondglow.gameObject.SetActive(false);
						_thirdglow.gameObject.SetActive(false);
			
				}
				if (PlayerPrefs.GetInt ("currentbow") == 2 && PlayerPrefs.GetInt ("Secondnumberofarrow") > 0) {
						_firstglow.gameObject.SetActive(false);
						_secondglow.gameObject.SetActive(true);
						_thirdglow.gameObject.SetActive(false);
				}
				if (PlayerPrefs.GetInt ("currentbow") == 3 && PlayerPrefs.GetInt ("Thirdnumberofarrow") > 0) {
						_firstglow.gameObject.SetActive(false);
						_secondglow.gameObject.SetActive(false);
						_thirdglow.gameObject.SetActive(true);
				}
		
		 
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		
		
		
		
		}
	
		public override void OnSelectedEvent (GUIItem item)
		{
				if (meState == eGUI_ITEMS_MANAGER_STATE.Settled) {
			
						if (item.name == "powerup" && Application.loadedLevel == 2) {
			
								Debug.Log ("----- In Derived class event handle : " + item.name);
								_screenManager.LoadScreen ("SecodArrowpopup");
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
								audioManager.instances.playcurrentaudio ();
				
						}
				
						if (item.name == "backbutton1" && Application.loadedLevel == 2) {
			
								Debug.Log ("----- In Derived class event handle : " + item.name);
				
								if (notDestroy.instances._emPlayMode == notDestroy.ePlayMode.PlayForNormal) {
										_screenManager.LoadScreen ("arrowpopup");
										audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
										audioManager.instances.playcurrentaudio ();
								}
			    
						}
				
						if (item.name == "firstbowButton" && Application.loadedLevel == 2) {
			
								Debug.Log ("----- In Derived class event handle : " + item.name);
				
								// setarrowvalue(1);
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [28];
								audioManager.instances.playcurrentaudio ();
								if (notDestroy.instances._emPlayMode == notDestroy.ePlayMode.PlayForNormal) {
										_screenManager.LoadScreen ("arrowpopup");
								}
								if (PlayerPrefs.GetInt ("Firstnumberofarrow") > 0) {
				  
										_firstglow.gameObject.SetActive(true);
										BoardScore.instances._arrowmultiplier = 2;
										enemy_score.instances._eneMyScoremultiplier = 2;
										ArrowTrail.instances.changeTrail (0);
			     
								}
								if (_secondglow.gameObject.active==true) {
										_secondglow.gameObject.SetActive(false);
								}
								if (_thirdglow.gameObject.active==true) {
										_thirdglow.gameObject.SetActive(false);
								}
								PlayerPrefs.SetInt ("currentbow", 1);
								setarrowvalue (1);
			  
						}
				
						if (item.name == "secondbowbutton" && Application.loadedLevel == 2) {
			
								Debug.Log ("----- In Derived class event handle : " + item.name);
				
				
								//setarrowvalue(2);
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [28];
								audioManager.instances.playcurrentaudio ();
								if (notDestroy.instances._emPlayMode == notDestroy.ePlayMode.PlayForNormal) {
										_screenManager.LoadScreen ("arrowpopup");
								}
								if (PlayerPrefs.GetInt ("Secondnumberofarrow") > 0) {
										_secondglow.gameObject.SetActive(true);
										BoardScore.instances._arrowmultiplier = 4;
										enemy_score.instances._eneMyScoremultiplier = 4;
										ArrowTrail.instances.changeTrail (0);
					
								}
								if (_firstglow.gameObject.active==true) {
					
										_firstglow.gameObject.SetActive(false);
								}
								if (_thirdglow.gameObject.active==true) {
										_thirdglow.gameObject.SetActive(false);
								}
								PlayerPrefs.SetInt ("currentbow", 2);
								setarrowvalue (2);
						}
				
			
						if (item.name == "Thirdbowbutton" && Application.loadedLevel == 2) {
			
								Debug.Log ("----- In Derived class event handle : " + item.name);
				
				
								///setarrowvalue(3);
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [28];
								audioManager.instances.playcurrentaudio ();
								if (notDestroy.instances._emPlayMode == notDestroy.ePlayMode.PlayForNormal) {

										_screenManager.LoadScreen ("arrowpopup");
								}
								if (PlayerPrefs.GetInt ("Thirdnumberofarrow") > 0) {
										_thirdglow.gameObject.SetActive(true);
										BoardScore.instances._arrowmultiplier = 6;
										enemy_score.instances._eneMyScoremultiplier = 6;
										ArrowTrail.instances.changeTrail (0);
					 
								}
								if (_firstglow.gameObject.active==true) {
					
										_firstglow.gameObject.SetActive(false);
								}
								if (_secondglow.gameObject.active==true) {
										_secondglow.gameObject.SetActive(false);
								}
				
								PlayerPrefs.SetInt ("currentbow", 3);
								setarrowvalue (3);
						}
			
				}
		}
	
		void  setarrowvalue (int number)
		{
		
				if (number == 1) {
						if (PlayerPrefs.GetInt ("Firstnumberofarrow") > 0 && firstarr == false) {
								firstarrowvalue.text = "" + (PlayerPrefs.GetInt ("Firstnumberofarrow") - 1);
				
								currentfirstarrowvalue = PlayerPrefs.GetInt ("Firstnumberofarrow") - 1;
				
				
								PlayerPrefs.SetInt ("Firstnumberofarrow", currentfirstarrowvalue);
				
								store_currentStatus.instances.resetarrowvalue = 1;
				
								challenge_Controll.instances.setgravity (0);
		
								controll.instance.setgravity (0);
								if (PlayerPrefs.GetInt ("Secondnumberofarrow") < secondarrowstore) {
										secondarrowvalue.text = "" + secondarrowstore;
										currentsecondarrowvalue = secondarrowstore;
										PlayerPrefs.SetInt ("Secondnumberofarrow", currentsecondarrowvalue);
				
								}
								if (PlayerPrefs.GetInt ("Thirdnumberofarrow") < thirdarrowstore) {
										Thirdarrowvalue.text = "" + thirdarrowstore;
										currentthirdarrowvalue = thirdarrowstore;
										PlayerPrefs.SetInt ("Thirdnumberofarrow", currentthirdarrowvalue);
								}
								firstarr = true;
								secondarr = false;
								thirdarr = false;
								store_currentStatus.instances.Realasearrow = false;
						}
			
			
				}
				if (number == 2) {
						if (PlayerPrefs.GetInt ("Secondnumberofarrow") > 0 && secondarr == false) {
								secondarrowvalue.text = "" + (PlayerPrefs.GetInt ("Secondnumberofarrow") - 1);
								currentsecondarrowvalue = PlayerPrefs.GetInt ("Secondnumberofarrow") - 1;
								PlayerPrefs.SetInt ("Secondnumberofarrow", currentsecondarrowvalue);
				
								store_currentStatus.instances.resetarrowvalue = 2;
								challenge_Controll.instances.setgravity (0);
		
								controll.instance.setgravity (0);
								if (PlayerPrefs.GetInt ("Thirdnumberofarrow") < thirdarrowstore) {
										Thirdarrowvalue.text = "" + thirdarrowstore;
										currentthirdarrowvalue = thirdarrowstore;
										PlayerPrefs.SetInt ("Thirdnumberofarrow", currentthirdarrowvalue);
								}
				
								if (PlayerPrefs.GetInt ("Firstnumberofarrow") < firstarrowstore) {
										firstarrowvalue.text = "" + firstarrowstore;
										currentfirstarrowvalue = firstarrowstore;
										PlayerPrefs.SetInt ("Firstnumberofarrow", currentfirstarrowvalue);
								}
				
								secondarr = true;
								firstarr = false;
								thirdarr = false;
								store_currentStatus.instances.Realasearrow = false;
						}
			
				}
				if (number == 3) {
						if (PlayerPrefs.GetInt ("Thirdnumberofarrow") > 0 && thirdarr == false) {
								Thirdarrowvalue.text = "" + (PlayerPrefs.GetInt ("Thirdnumberofarrow") - 1);
								currentthirdarrowvalue = PlayerPrefs.GetInt ("Thirdnumberofarrow") - 1;
								PlayerPrefs.SetInt ("Thirdnumberofarrow", currentthirdarrowvalue);
				
								store_currentStatus.instances.resetarrowvalue = 3;
								challenge_Controll.instances.setgravity (0);
		
								controll.instance.setgravity (0);
								if (PlayerPrefs.GetInt ("Firstnumberofarrow") < firstarrowstore) {
										firstarrowvalue.text = "" + firstarrowstore;
										currentfirstarrowvalue = firstarrowstore;
										PlayerPrefs.SetInt ("Firstnumberofarrow", currentfirstarrowvalue);
								}
				
								if (PlayerPrefs.GetInt ("Secondnumberofarrow") < secondarrowstore) {
										secondarrowvalue.text = "" + secondarrowstore;
										currentsecondarrowvalue = secondarrowstore;
										PlayerPrefs.SetInt ("Secondnumberofarrow", currentsecondarrowvalue);
				
								}
				
						}
						secondarr = false;
						firstarr = false;
						thirdarr = true;
						store_currentStatus.instances.Realasearrow = false;
				}
		
		
		
		
		}
	

}
