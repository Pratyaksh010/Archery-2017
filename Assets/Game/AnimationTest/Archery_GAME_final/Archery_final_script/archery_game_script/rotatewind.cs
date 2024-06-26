using UnityEngine;
using System.Collections;

public class rotatewind : MonoBehaviour
{
		public float speed;
		public float timelimit;
		public bool onetime;
		public int sector;
		public float val;
		public float angle;
		public float movanglelimit;
		public float timewiating;
		public float maxspeed;
		public float minspeed;
		public float minmagtude1;
		public float maxmagtude1;
		public float minmagtude2;
		public float maxmagtude2;
		private Transform rotatewi;
		public bool chekoutdoor;// check game play indoor or outdoor
		public bool challenge_showgui;// chek challenge mode enable or not
		public float Easyminwindmag;
		public float Easymaxwindmag;
		public float mediumminwindmag;
		public float mediummaxwindmag;
		public float hardminwindmag;
		public float hardmaxwindmag;
		private float currentminmag;
		private float currentmaxmag;
	
		public Transform rotatewindobject;
	
		public Transform windarrow;
	
		public bool chekIndoor;// check indoor or outdoor
	
		public bool showwind;
	
		public Transform flaganimation;
	
		public Transform wind1;
	
		public Transform wind2;
	
		public Transform wind3;
	
		public Transform wind4;
	
		public bool checkoutdoor;
		void Start ()
		{
				//if ((iPhone.generation == iPhoneGeneration.iPodTouch1Gen) || (iPhone.generation == iPhoneGeneration.iPodTouch2Gen) || (iPhone.generation == iPhoneGeneration.iPodTouch3Gen) || (iPhone.generation == iPhoneGeneration.iPodTouch4Gen)) 
				if(Application.platform == RuntimePlatform.Android)
				{
						windarrow.transform.localPosition = new Vector3 (.1f, windarrow.transform.localPosition.y, windarrow.transform.localPosition.z);
				}
//				if (iPhone.generation == iPhoneGeneration.iPodTouch5Gen) {
//						windarrow.transform.localPosition = new Vector3 (.7f, windarrow.transform.localPosition.y, windarrow.transform.localPosition.z);
//				}
				checkoutdoor = controll.instance.outdoor;
				rotatewi = transform;
				if (checkoutdoor == true) {
						wind1.gameObject.SetActive(false);
						wind2.gameObject.SetActive(false);
						wind3.gameObject.SetActive(false);
						wind4.gameObject.SetActive(false);
				}
				timelimit = Time.time;
				///speed=Random.Range(.2f,4f);
				challenge_showgui = challenge_Controll.instances.showgui;
	   
				chekoutdoor = controll.instance.outdoor;
		
				if (store_currentStatus.instances.currentwin == store_currentStatus.currentChallengewind.current_windeasy) {
						currentminmag = Easyminwindmag;
			
						currentmaxmag = Easymaxwindmag;
			
				}
		
				if (store_currentStatus.instances.currentwin == store_currentStatus.currentChallengewind.current_windMed) {
						currentminmag = mediumminwindmag;
			
						currentmaxmag = mediummaxwindmag;
			
						print ("3");
				}
		
				if (store_currentStatus.instances.currentwin == store_currentStatus.currentChallengewind.current_windHard) {
						currentminmag = hardminwindmag;
			
						currentmaxmag = hardmaxwindmag;
				}
		
		}
	
		// Update is called once per frame
		void Update ()
		{
		
				if (checkoutdoor == true && showwind == true && controll.instance.pause == false && chekIndoor == true) {
			
						rotatewindobject.gameObject.SetActive(true);
			
						windarrow.transform.GetComponent<Renderer>().enabled = true;
				}
				if (checkoutdoor == true && controll.instance.pause == true || controll.instance.gameovercom == true || chekIndoor == false || challenge_mode_gui.instances.showgameresult == true || showwind == false) {
		
			
			
						rotatewindobject.gameObject.SetActive(false);
			
						windarrow.transform.GetComponent<Renderer>().enabled = false;
				}
		
		
				if (checkoutdoor == true && controll.instance.outdoor == true || (challenge_Controll.instances.showgui == true && controll.instance.outdoor == true)) {
		
						if (onetime == false) {
								if (notDestroy.instances._emPlayMode == notDestroy.ePlayMode.PlayForCash)
										sector = (sector + 1) % 4;
								else
										sector = Random.Range (0, 4);
			   
			  
								if (sector == 0) {
										timelimit = Time.time;
										// transform
										rotatewi.eulerAngles = new Vector3 (0, 0, 90f);//Random.Range(55f,90f));
										//wind1.eulerAngles=new Vector3(0,0,0);
										//wind2.eulerAngles=new Vector3(0,0,0);
										wind1.gameObject.SetActive(true);
										wind2.gameObject.SetActive(true);
										wind3.gameObject.SetActive(false);
										wind4.gameObject.SetActive(false);
										val = rotatewi.eulerAngles.z;
										//if( rotatewi.eulerAngles.z>=55&&rotatewi.eulerAngles.z<=75f)
										//{
										if (chekoutdoor == true && challenge_showgui == false) {
												if (notDestroy.instances._emPlayMode == notDestroy.ePlayMode.PlayForNormal)
														controll.instance.windmagnitude = Random.Range (currentminmag, currentmaxmag);
												else
														controll.instance.windmagnitude = notDestroy.instances._SpeedOfAir [notDestroy.instances.mAirIndex++];					
												controll.instance.windmultipler = (controll.instance.windmagnitude);//+Random.Range(.2f,1f)+Random.Range(.1f,.5f);
				   
												controll.instance.windmagnitude /= 400;
												// flaganimation.animation["windeffect"].speed=flaganimation.animation["windeffect"].speed*controll.instance.windmagnitude*500;	
										}
					
										if (challenge_showgui == true) {
												challenge_Controll.instances.challengewindmagnitude = Random.Range (currentminmag, currentmaxmag);
						
												challenge_Controll.instances.challengewindmultipler = challenge_Controll.instances.challengewindmagnitude;
						
												challenge_Controll.instances.challengewindmagnitude /= 400;
												//	flaganimation.animation["windeffect"].speed=flaganimation.animation["windeffect"].speed*controll.instance.windmagnitude*500;
										}
										//}
										//if( rotatewi.eulerAngles.z>75f&&rotatewi.eulerAngles.z<90f)
										//{
										//controll.instance.windmagnitude=Random.Range(minmagtude2,maxmagtude2);
										//controll.instance.windmultipler=(controll.instance.windmagnitude*500);//+Random.Range(.8f,5f);
										//}
								}
		  
								if (sector == 1) {
										timelimit = Time.time;
										rotatewi.eulerAngles = new Vector3 (0, 0, 270f);//Random.Range(90f,135f));
										///wind1.eulerAngles=new Vector3(0,90,0);
										//wind2.eulerAngles=new Vector3(0,90,0);
										wind1.gameObject.SetActive(false);
										wind2.gameObject.SetActive(false);
										wind3.gameObject.SetActive(true);
										wind4.gameObject.SetActive(true);
										val = rotatewi.eulerAngles.z;
										//if( rotatewi.eulerAngles.z>=90&&rotatewi.eulerAngles.z<=135f)
										//{
										if (chekoutdoor == true && challenge_showgui == false) {
												if (notDestroy.instances._emPlayMode == notDestroy.ePlayMode.PlayForNormal)
														controll.instance.windmagnitude = Random.Range (currentminmag, currentmaxmag);
												else
														controll.instance.windmagnitude = notDestroy.instances._SpeedOfAir [notDestroy.instances.mAirIndex++];												//controll.instance.windmultipler=(controll.instance.windmagnitude*500);//+Random.Range(.6f,5f);
												controll.instance.windmultipler = (controll.instance.windmagnitude);//+Random.Range(.2f,1f)+Random.Range(.1f,.5f);
				   
												controll.instance.windmagnitude /= 400;
												//flaganimation.animation["windeffect"].speed=flaganimation.animation["windeffect"].speed*controll.instance.windmagnitude*500;
					
										}
					
										if (challenge_showgui == true) {
												challenge_Controll.instances.challengewindmagnitude = Random.Range (currentminmag, currentmaxmag);
												challenge_Controll.instances.challengewindmultipler = challenge_Controll.instances.challengewindmagnitude;
						
												challenge_Controll.instances.challengewindmagnitude /= 400;
												//flaganimation.animation["windeffect"].speed=flaganimation.animation["windeffect"].speed*controll.instance.windmagnitude*500;
					
										}
										//}
										//if( rotatewi.eulerAngles.z>135f&&rotatewi.eulerAngles.z<180f)
										//{
										//controll.instance.windmagnitude=0f;//=Random.Range(minmagtude1,maxmagtude1);
										//controll.instance.windmultipler=(controll.instance.windmagnitude*100)+Random.Range(.1f,1f)+Random.Range(.1f,.5f);
										//}
								}
								if (sector == 2) {    
										timelimit = Time.time;
										rotatewi.eulerAngles = new Vector3 (0, 0, 90f);//Random.Range(225f,270f));
										val = rotatewi.eulerAngles.z;
										wind1.gameObject.SetActive(true);
										wind2.gameObject.SetActive(true);
										wind3.gameObject.SetActive(false);
										wind4.gameObject.SetActive(false);
										//if( rotatewi.eulerAngles.z>=225f&&rotatewi.eulerAngles.z<=245f)
										//{
										//wind1.eulerAngles=new Vector3(0,0,0);
										//wind2.eulerAngles=new Vector3(0,0,0);
										if (chekoutdoor == true && challenge_showgui == false) {
												if (notDestroy.instances._emPlayMode == notDestroy.ePlayMode.PlayForNormal)
														controll.instance.windmagnitude = Random.Range (currentminmag, currentmaxmag);
												else
														controll.instance.windmagnitude = notDestroy.instances._SpeedOfAir [notDestroy.instances.mAirIndex++];													//controll.instance.windmultipler=(controll.instance.windmagnitude*500);//+Random.Range(.1f,1f);
												controll.instance.windmultipler = (controll.instance.windmagnitude);//+Random.Range(.2f,1f)+Random.Range(.1f,.5f);
				   
												controll.instance.windmagnitude /= 400;
												//flaganimation.animation["windeffect"].speed=flaganimation.animation["windeffect"].speed*controll.instance.windmagnitude*500;
						
										}
					
										if (challenge_showgui == true) {
												challenge_Controll.instances.challengewindmagnitude = Random.Range (currentminmag, currentmaxmag);
						
												challenge_Controll.instances.challengewindmultipler = challenge_Controll.instances.challengewindmagnitude;
						
												challenge_Controll.instances.challengewindmagnitude /= 400;
												//flaganimation.animation["windeffect"].speed=flaganimation.animation["windeffect"].speed*controll.instance.windmagnitude*500;
					
										}
										//}
										//if( rotatewi.eulerAngles.z>245f&&rotatewi.eulerAngles.z<270f)
										//{
										//controll.instance.windmagnitude=Random.Range(minmagtude2,maxmagtude2);
										//controll.instance.windmultipler=(controll.instance.windmagnitude*500);//+Random.Range(.6f,5f);
										//}
								}
								if (sector == 3) {
										timelimit = Time.time;
										rotatewi.eulerAngles = new Vector3 (0, 0, 270f);//Random.Range(270f,315f));
										val = rotatewi.eulerAngles.z;
										wind1.gameObject.SetActive(false);
										wind2.gameObject.SetActive(false);
										wind3.gameObject.SetActive(true);
										wind4.gameObject.SetActive(true);
										//if( rotatewi.eulerAngles.z>=270f&&rotatewi.eulerAngles.z<=290f)
										//{
										//wind1.eulerAngles=new Vector3(0,90,0);
										//wind2.eulerAngles=new Vector3(0,90,0);
										if (chekoutdoor == true && challenge_showgui == false) {
												if (notDestroy.instances._emPlayMode == notDestroy.ePlayMode.PlayForNormal)
														controll.instance.windmagnitude = Random.Range (currentminmag, currentmaxmag);
												else
														controll.instance.windmagnitude = notDestroy.instances._SpeedOfAir [notDestroy.instances.mAirIndex++];													///controll.instance.windmultipler=(controll.instance.windmagnitude*500);//+Random.Range(.1f,4f);
												controll.instance.windmultipler = (controll.instance.windmagnitude);//+Random.Range(.2f,1f)+Random.Range(.1f,.5f);
				   
												controll.instance.windmagnitude /= 400;
												//flaganimation.animation["windeffect"].speed=flaganimation.animation["windeffect"].speed*controll.instance.windmagnitude*500;
						
										}
					
										if (challenge_showgui == true) {
												challenge_Controll.instances.challengewindmagnitude = Random.Range (currentminmag, currentmaxmag);
						
												challenge_Controll.instances.challengewindmultipler = challenge_Controll.instances.challengewindmagnitude;
						
												challenge_Controll.instances.challengewindmagnitude /= 400;
												//flaganimation.animation["windeffect"].speed=flaganimation.animation["windeffect"].speed*controll.instance.windmagnitude*500;
					
										}
										//}
										//if( rotatewi.eulerAngles.z>290f&&rotatewi.eulerAngles.z<=315f)
										//{
										//controll.instance.windmagnitude=Random.Range(minmagtude1,maxmagtude1);
										//controll.instance.windmultipler=(controll.instance.windmagnitude*500);//+Random.Range(.1f,1f)+Random.Range(.1f,.5f);
										///}
								}
								onetime = true;
						}
						if (Time.time - timelimit > timewiating && onetime == true) {
			
								angle = Random.Range (val - movanglelimit, val + movanglelimit);
			
								speed = Random.Range (minspeed, maxspeed);
			
								timelimit = Time.time;
						}
						if (onetime == true) {
								//if(transform.eulerAngles.z>=val-(movanglelimit+20)&&transform.eulerAngles.z<=val+(movanglelimit+20))
			
								//////////rotatewi.eulerAngles=new Vector3(0f,0f, Mathf.MoveTowardsAngle(rotatewi.eulerAngles.z,angle, speed * Time.deltaTime));
			
						}
				} 
	
		}
	
}