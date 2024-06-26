using UnityEngine;
using System.Collections;

public class popevent :GUIItemsManager
{
		public GameObject _showarrow ;
	
		public ScreenManager subscreenmanager;
	
		bool i1 ;
		GameObject tshop;
		// Use this for initialization
		void Start ()
		{
				challenge_Controll.instances.powerup = transform;
				controll.instance.powerup = transform;
				store_currentStatus.instances.offcontrolling = false;
				base.Init (); 
//				if (notDestroy.instances._emPlayMode == notDestroy.ePlayMode.PlayForCash)
//						gameObject.SetActive (false);
		}
	
		public override void OnSelectedEvent (GUIItem item)
		{
				if (meState == eGUI_ITEMS_MANAGER_STATE.Settled) {
						if (item.name == "powerup" && Application.loadedLevel == 2 && i1 == true && tshop != null) {
								audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
								audioManager.instances.playcurrentaudio (); 
				   
								challenge_Controll.instances.powerup = transform;
								controll.instance.powerup = transform;
								store_currentStatus.instances.offcontrolling = false;
								subscreenmanager.closeScreenManager ();
								i1 = false;
						} else {
								if (item.name == "powerup" && notDestroy.instances._activeArrowPopUp == true && Application.loadedLevel == 2 && i1 == false && tshop == null) {
			
										i1 = true;
										BoardScore.instances._arrowmultiplier = 1;
										enemy_score.instances._eneMyScoremultiplier = 1;
										ArrowTrail.instances.changeTrail (0);
				
										// _screenManager.LoadScreen("SecodArrowpopup");
			    
										audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
				 
										audioManager.instances.playcurrentaudio ();
				
										if (_showarrow != null) {//GameObject
			         
												if (tshop == null) {
														tshop = GameObject.Instantiate (_showarrow) as GameObject;
														subscreenmanager = tshop.GetComponent<ScreenManager> ();
												}
			
										}
					
					
								}
				
								if (item.name == "powerup1" && Application.loadedLevel == 2 && i1 == true && tshop != null && store_currentStatus.instances.offcontrolling == true) {
					
					
										audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
										audioManager.instances.playcurrentaudio (); 
				   
										challenge_Controll.instances.powerup = transform;
										controll.instance.powerup = transform;
										store_currentStatus.instances.offcontrolling = false;
										subscreenmanager.closeScreenManager ();
										i1 = false;
								}
				
				
						}
				} 
		}
	
		public void stop ()
		{
				if (tshop != null) {
						audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19];
				   
						audioManager.instances.playcurrentaudio (); 
				   
						challenge_Controll.instances.powerup = transform;
						controll.instance.powerup = transform;
						store_currentStatus.instances.offcontrolling = false;
						subscreenmanager.closeScreenManager ();
						i1 = false;
				}
		}

}