using UnityEngine;
using System.Collections;

public class targetboarddistance : MonoBehaviour
{
		public Transform targetboard;
	
		public Transform secondarycamera;
	
		public float secondarycamdiff;
	
		public Transform secondaryboard;
	
		public Transform Seccondary;
	
		public Transform mainArcheryboard;
	
		public int checklimit;
	
		public float vel0;
	
		public float vel1;
	
		public float vel2;
	
		public float vel3;
	
		public float pos70MaxVel;
	
		public float pos50MaxVel;
	
		public float addforce;
	
		public bool checkdivce;
		void Awake ()
		{
				addforce = PlayerPrefs.GetFloat ("powervalue");
		
				// if(Application.platform==RuntimePlatform.IPhonePlayer&&(iPhone.generation==iPhoneGeneration.iPodTouch1Gen) || (iPhone.generation==iPhoneGeneration.iPodTouch2Gen) || (iPhone.generation==iPhoneGeneration.iPodTouch3Gen) || (iPhone.generation==iPhoneGeneration.iPodTouch4Gen))
				//{
				//checkdivce=true;
			
				//}
				//else
				//{
				//checkdivce=false;
				//}
		}
		public void Settargetboard (int pos)
		{
				checklimit = pos;
				if (controll.instance.outdoor == false && controll.instance.challenge_mode == false) {
						/*targetboard.position=new Vector3(targetboard.position.x,targetboard.position.y,targetboard.position.z);
		    secondarycamera.position=new Vector3(secondarycamera.position.x,secondarycamera.position.y,targetboard.position.z-4.5f);//targetboard.position.z-4.5f);
		    Seccondary.position=mainArcheryboard.position;
			secondarycamera.position=new Vector3(secondarycamera.position.x,secondarycamera.position.y,Seccondary.position.z-4.5f);*/
						targetboard.transform.position = new Vector3 (targetboard.transform.position.x, targetboard.position.y, targetboard.position.z);
						Seccondary.transform.position = mainArcheryboard.position;
						secondarycamera.transform.position = new Vector3 (secondarycamera.transform.position.x, secondarycamera.transform.position.y, Seccondary.transform.position.z - 5f);
						secondaryboard.transform.position = secondarycamera.transform.position;
						//if(checkdivce==true)
						//{
						//controll.instance.veloc=41f+addforce;
						//}
						//else
						//{
						controll.instance.veloc = vel0 + addforce;
						//}
			
				}
		
				if (controll.instance.outdoor == true || controll.instance.challenge_mode == true) {	
		
		
						if (pos == 1) {
	    	        
				  
								if (controll.instance.outdoor == true && controll.instance.challenge_mode == false) {
										// if(checkdivce==true)
										//{
										//controll.instance.veloc=57f+addforce;	
										//}
										//else
										//{
										controll.instance.veloc = 60f + addforce;//62f;//currentvel;//62f;//controll.instance.veloc+((pos+1)*16f);	
										//}
								}    
								targetboard.position = new Vector3 (targetboard.position.x, targetboard.position.y, targetboard.position.z + 20f);
								Seccondary.transform.position = mainArcheryboard.position;
								secondarycamera.transform.position = new Vector3 (secondarycamera.transform.position.x, secondarycamera.transform.position.y, Seccondary.transform.position.z - 5f);
								secondaryboard.transform.position = secondarycamera.transform.position;
		  
						}
						if (pos == 2) {
								if (controll.instance.outdoor == true && controll.instance.challenge_mode == false) {
										//if(checkdivce==true)
										//{
										//controll.instance.veloc=64f+addforce;
										//}
										//else
										//{
										controll.instance.veloc = 66f + addforce;//68f
										//}
								}
								targetboard.transform.position = new Vector3 (targetboard.transform.position.x, targetboard.position.y, targetboard.position.z + 40);
								Seccondary.transform.position = mainArcheryboard.position;
								secondarycamera.transform.position = new Vector3 (secondarycamera.transform.position.x, secondarycamera.transform.position.y, Seccondary.transform.position.z - 5f);
								secondaryboard.transform.position = secondarycamera.transform.position;
		
						}
						if (pos == 3) {
		
								targetboard.transform.position = new Vector3 (targetboard.transform.position.x, targetboard.position.y, targetboard.position.z + 60);
								Seccondary.transform.position = mainArcheryboard.position;
								secondarycamera.transform.position = new Vector3 (secondarycamera.transform.position.x, secondarycamera.transform.position.y, Seccondary.transform.position.z - 5f);
								secondaryboard.transform.position = secondarycamera.transform.position;
								if (controll.instance.outdoor == true && controll.instance.challenge_mode == false) {
										//if(checkdivce==true)
										//{
										// controll.instance.veloc=65f+addforce;
										//}
										//else
										//{
										controll.instance.veloc = 68f + addforce;//vel3
										//}
		      
								}
						}
						if (pos == 0) {
								targetboard.transform.position = new Vector3 (targetboard.transform.position.x, targetboard.position.y, targetboard.position.z);
								Seccondary.transform.position = mainArcheryboard.position;
								secondarycamera.transform.position = new Vector3 (secondarycamera.transform.position.x, secondarycamera.transform.position.y, Seccondary.transform.position.z - 5f);
								secondaryboard.transform.position = secondarycamera.transform.position;
								if (controll.instance.outdoor == true && controll.instance.challenge_mode == false) {
										controll.instance.veloc = vel0 + addforce;
								}
		
						}
				}
		}
		public void SettargetboardChallenge (int pos)
		{	
				checklimit = pos;
		
				if (pos == 1) {
	    	      
						targetboard.position = new Vector3 (targetboard.position.x, targetboard.position.y, targetboard.position.z + 20f);
						Seccondary.transform.position = mainArcheryboard.position;
						secondarycamera.transform.position = new Vector3 (secondarycamera.transform.position.x, secondarycamera.transform.position.y, Seccondary.transform.position.z - 5f);
						secondaryboard.transform.position = secondarycamera.transform.position;
						// if(checkdivce==true)
						//{
						//challenge_Controll.instances.challengeconVel=61f+addforce;
			
						//}
						//else
						//{
						challenge_Controll.instances.challengeconVel = 63f + addforce;
			
						//}
		    
			
				}
		
				if (pos == 2) {
						targetboard.transform.position = new Vector3 (targetboard.transform.position.x, targetboard.position.y, targetboard.position.z + 40);
						Seccondary.transform.position = mainArcheryboard.position;
						secondarycamera.transform.position = new Vector3 (secondarycamera.transform.position.x, secondarycamera.transform.position.y, Seccondary.transform.position.z - 5f);
						secondaryboard.transform.position = secondarycamera.transform.position;
						//if(checkdivce==true)
						//{
						//challenge_Controll.instances.challengeconVel=62f+addforce;
						//}
						//else
						//{
						challenge_Controll.instances.challengeconVel = 64f + addforce;
						//}
				}
				if (pos == 3) {
		
						targetboard.transform.position = new Vector3 (targetboard.transform.position.x, targetboard.position.y, targetboard.position.z + 60);
						Seccondary.transform.position = mainArcheryboard.position;
						secondarycamera.transform.position = new Vector3 (secondarycamera.transform.position.x, secondarycamera.transform.position.y, Seccondary.transform.position.z - 5f);
						secondaryboard.transform.position = secondarycamera.transform.position;
						//if(checkdivce==true)
						//{
						// challenge_Controll.instances.challengeconVel=67f+addforce;
						//}
						//else
						//{
						challenge_Controll.instances.challengeconVel = 70f + addforce;
						//}
				}
				if (pos == 0) {
						targetboard.transform.position = new Vector3 (targetboard.transform.position.x, targetboard.position.y, targetboard.position.z);
						Seccondary.transform.position = mainArcheryboard.position;
						secondarycamera.transform.position = new Vector3 (secondarycamera.transform.position.x, secondarycamera.transform.position.y, Seccondary.transform.position.z - 5f);
						secondaryboard.transform.position = secondarycamera.transform.position;
						//if(checkdivce==true)
						//{
						// challenge_Controll.instances.challengeconVel=41f+addforce;
						//}
						//else
						//{
						challenge_Controll.instances.challengeconVel = 45f + addforce;
						//}
			
				}
		}
}