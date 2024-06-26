using UnityEngine;
using System.Collections;

public class BoardScore : MonoBehaviour
{
		public Transform boardcenterpoint;
		public float[] range;
	
		public bool onetimeshowscorecall;
		public int score;
		public Texture[] numbertexture;
		public float alpha;
		public bool fadestart;
		public bool fadein;
		public float waitingtime;
		public float wiatingdelay;
		public static BoardScore boardsc;
		public bool CheckchallengeMode;
		int _currentchallenge;
		public int _playerTargetbull;
		private float widthx;
		private float heighty;
		public static  BoardScore instances;
		public Transform _gamehandler;
		public int _arrowmultiplier ;
		public GUITexture showmultiplier ;
		void Awake ()
		{
				boardsc = this;
	  
				alpha = 0f;
				_arrowmultiplier = 1;
				instances = this;
				_gamehandler = transform;
		}
	
		// Update is called once per frame
		void Update ()
		{
				transform.GetComponent<GUITexture>().color = new Color (.5f, .5f, .5f, alpha);
				showmultiplier.GetComponent<GUITexture>().color = new Color (.5f, .5f, .5f, alpha);
		}
		void Start ()
		{
				CheckchallengeMode = controll.instance.challenge_mode;
		
				_currentchallenge = notDestroy.instances.challengeSelect;
		
				//if (Application.platform == RuntimePlatform.IPhonePlayer && (iPhone.generation == iPhoneGeneration.iPad3Gen)) 
				if(Application.platform == RuntimePlatform.Android)
				{
					widthx = 60f;
					heighty = 60f;
				} 
				else {
						widthx = 60f;
						heighty = 60f;
				}
		}
		public void showScore (Vector2 pos)
		{
		
				float distance = Vector2.Distance (new Vector2 (boardcenterpoint.position.x, boardcenterpoint.position.y), new Vector2 (pos.x, pos.y));
		 
		
				if (distance >= 0f && distance < range [0]) {
			
						score = 11;
						audioManager.instances._popupaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [4];
						_playerTargetbull = _playerTargetbull + 1;
						fadestart = true;
						if (CheckchallengeMode == false) {
								controll.instance.showscoreset (10 * _arrowmultiplier);
						}
						if (CheckchallengeMode == true) {  
								if (_currentchallenge != 7) {
										challenge_Controll.instances.showChallengescoreset (10 * _arrowmultiplier);
										challenge_Controll.instances._noOffhitBullEyes = challenge_Controll.instances._noOffhitBullEyes + 1;
								}
								if (_currentchallenge == 7) {
										challenge_Controll.instances.showscoreset (10 * _arrowmultiplier);
								}
								//showscoreset
						}
				}
				if (distance >= range [0] && distance < range [1]) {
						score = 10;
						audioManager.instances._popupaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [5];
						fadestart = true;
						if (CheckchallengeMode == false) {
								controll.instance.showscoreset (10 * _arrowmultiplier);
						}
						if (CheckchallengeMode == true) {
								if (_currentchallenge != 7) {
										challenge_Controll.instances.showChallengescoreset (10 * _arrowmultiplier);
								}
								if (_currentchallenge == 7) {
										challenge_Controll.instances.showscoreset (10 * _arrowmultiplier);
								}
						}
				}
				if (distance >= range [1] && distance < range [2]) {
						score = 9;
						audioManager.instances._popupaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [6];
						fadestart = true;
						if (CheckchallengeMode == false) {
								controll.instance.showscoreset (score * _arrowmultiplier);
						}
						if (CheckchallengeMode == true) {
								if (_currentchallenge != 7) {
										challenge_Controll.instances.showChallengescoreset (score * _arrowmultiplier);
								}
								if (_currentchallenge == 7) {
										challenge_Controll.instances.showscoreset (score * _arrowmultiplier);
								}
						}
				}
				if (distance >= range [2] && distance < range [3]) {
						score = 8;
						audioManager.instances._popupaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [7];
						fadestart = true;
						if (CheckchallengeMode == false) {
								controll.instance.showscoreset (score * _arrowmultiplier);
						}
						if (CheckchallengeMode == true) {
								if (_currentchallenge != 7) {
										challenge_Controll.instances.showChallengescoreset (score * _arrowmultiplier);
								}
								if (_currentchallenge == 7) {
										challenge_Controll.instances.showscoreset (score * _arrowmultiplier);
								}
						}
				}
				if (distance >= range [3] && distance < range [4]) {
						score = 7;
						audioManager.instances._popupaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [8];
						fadestart = true;
						if (CheckchallengeMode == false) {
								controll.instance.showscoreset (score * _arrowmultiplier);
						}
						if (CheckchallengeMode == true) {
								if (_currentchallenge != 7) {
										challenge_Controll.instances.showChallengescoreset (score * _arrowmultiplier);
								}
								if (_currentchallenge == 7) {
										challenge_Controll.instances.showscoreset (score * _arrowmultiplier);
								}
						}
				}
				if (distance >= range [4] && distance < range [5]) {
						score = 6;
						audioManager.instances._popupaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [9];
						fadestart = true;
						if (CheckchallengeMode == false) {
								controll.instance.showscoreset (score * _arrowmultiplier);
						}
						if (CheckchallengeMode == true) {
								if (_currentchallenge != 7) {
										challenge_Controll.instances.showChallengescoreset (score * _arrowmultiplier);
								}
								if (_currentchallenge == 7) {
										challenge_Controll.instances.showscoreset (score * _arrowmultiplier);
								}
						}
				}
				if (distance >= range [5] && distance < range [6]) {
						score = 5;
						audioManager.instances._popupaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [10];
						fadestart = true;
						if (CheckchallengeMode == false) {
								controll.instance.showscoreset (score * _arrowmultiplier);
						}
						if (CheckchallengeMode == true) {
								if (_currentchallenge != 7) {
										challenge_Controll.instances.showChallengescoreset (score * _arrowmultiplier);
								}
								if (_currentchallenge == 7) {
										challenge_Controll.instances.showscoreset (score * _arrowmultiplier);
								}
						}
				}
				if (distance >= range [6] && distance < range [7]) {
						score = 4;
						audioManager.instances._popupaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [11];
						fadestart = true;
						if (CheckchallengeMode == false) {
								controll.instance.showscoreset (score * _arrowmultiplier);
						}
						if (CheckchallengeMode == true) {
								if (_currentchallenge != 7) {
										challenge_Controll.instances.showChallengescoreset (score * _arrowmultiplier);
								}
								if (_currentchallenge == 7) {
										challenge_Controll.instances.showscoreset (score * _arrowmultiplier);
								}
						}
				}
				if (distance >= range [7] && distance < range [8]) {
						score = 3;
						audioManager.instances._popupaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [12];
						fadestart = true;
						print ("three");
						if (CheckchallengeMode == false) {
								controll.instance.showscoreset (score * _arrowmultiplier);
						}
						if (CheckchallengeMode == true) {
								if (_currentchallenge != 7) {
										challenge_Controll.instances.showChallengescoreset (score * _arrowmultiplier);
								}
								if (_currentchallenge == 7) {
										challenge_Controll.instances.showscoreset (score * _arrowmultiplier);
								}
						}
				}
				if (distance >= range [8] && distance < range [9]) {
						score = 2;
						audioManager.instances._popupaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [13];
						fadestart = true;
						if (CheckchallengeMode == false) {
								controll.instance.showscoreset (score * _arrowmultiplier);
						}
						if (CheckchallengeMode == true) {
								if (_currentchallenge != 7) {
										challenge_Controll.instances.showChallengescoreset (score * _arrowmultiplier);
								}
								if (_currentchallenge == 7) {
										challenge_Controll.instances.showscoreset (score * _arrowmultiplier);
								}
						}
				}
				if (distance >= range [9] && distance <= range [10]) {
			
						audioManager.instances._popupaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [14];
						score = 1;
						fadestart = true;
						if (CheckchallengeMode == false) {
								controll.instance.showscoreset (score * _arrowmultiplier);
						}
						if (CheckchallengeMode == true) {
								if (_currentchallenge != 7) {
										challenge_Controll.instances.showChallengescoreset (score * _arrowmultiplier);
								}
								if (_currentchallenge == 7) {
										challenge_Controll.instances.showscoreset (score * _arrowmultiplier);
								}
						}
				}
				if (distance > range [10]) {
						audioManager.instances._popupaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [15];
						score = 0;
						fadestart = true;
						if (CheckchallengeMode == false) {
								controll.instance.showscoreset (score);
						}
						if (CheckchallengeMode == true) {
								if (_currentchallenge != 7) {
										challenge_Controll.instances.showChallengescoreset (score);
								}
								if (_currentchallenge == 7) {
										challenge_Controll.instances.showscoreset (score);
								}
						}
				}
		
				audioManager.instances.playpopsound ();
	
		}	
		void  OnGUI ()
		{
				// GUI.depth=10000;
	
				if (fadestart == true) {
		
						// GUI.color = new Color (1.0f,1.0f,1.0f,alpha);//0f + ((GetHitEffect - 50) / 7)
						//transform.guiTexture.color=new Color(.5f,.5f,.5f,alpha);
						if (fadein == false) {  
				
								alpha += .7f * Time.deltaTime;
								waitingtime = Time.time;
						}
						if (alpha >= 1) {
								fadein = true;
				
						}
						if (fadein == true) {   
								if (Time.time - waitingtime > wiatingdelay) {
										alpha -= 2f * Time.deltaTime;
								}
								if (alpha <= 0) {
										fadestart = false;
								}
						}
			
		

						if (score == 10) {
           
								//  GUI.DrawTexture(new Rect((Screen.width/2)-25,20,widthx,heighty),numbertexture[10]);
								_gamehandler.localScale = new Vector3 (.09f, .09f, 1f);
								showmultiplier.transform.localScale = new Vector3 (.09f, .09f, 1f);
								transform.GetComponent<GUITexture>().texture = numbertexture [10];
		       
		 
						}
						if (score == 11) {
								// GUI.DrawTexture(new Rect((Screen.width/2)-90,20,widthx+120,heighty),numbertexture[11]);
								_gamehandler.localScale = new Vector3 (.20f, .11f, 1f);
								showmultiplier.transform.localScale = new Vector3 (.09f, .09f, 1f);
								transform.GetComponent<GUITexture>().texture = numbertexture [11];
						}
						if (score < 10) {
          
								// GUI.DrawTexture(new Rect((Screen.width/2)-25,20,widthx,heighty),numbertexture[score]);
								_gamehandler.localScale = new Vector3 (.09f, .09f, 1f);
								showmultiplier.transform.localScale = new Vector3 (.09f, .09f, 1f);
								transform.GetComponent<GUITexture>().texture = numbertexture [score];
			  
						}
						switch (_arrowmultiplier) {
						case 1:
								showmultiplier.texture = numbertexture [15];
								break;
						case 2:
								showmultiplier.texture = numbertexture [12];
								break;
						case 4:
								showmultiplier.texture = numbertexture [13];
								break;
						case 6:
								showmultiplier.texture = numbertexture [14];
								break;
						}
       

		
				}      
     
		}
 
	
	
 
}
	

