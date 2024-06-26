using UnityEngine;
using System.Collections;

public class PlayGameManager : MonoBehaviour
{
		public ScreenManager _PlaygameSceenManager;
		public static PlayGameManager _instance;
		// Use this for initialization
		void Start ()
		{
				_instance = this;
		}
		public void LoadGameAtGamePlay ()
		{
				notDestroy.instances._emPlayMode = notDestroy.ePlayMode.PlayForCash;
				store_currentStatus.instances.currentchall = store_currentStatus.currentChallengedis.current_distance70;
				store_currentStatus.instances.currentdistances = 2;
				store_currentStatus.instances.currentwin = store_currentStatus.currentChallengewind.current_windHard;
				_PlaygameSceenManager.LoadScreen ("loading_bagground");
				gamegui_play.instances.camanimation.gameObject.SetActive(false);
				audioManager.instances._currentaudio.GetComponent<AudioSource>().clip = audioManager.instances._audioclip [19]; 
				PlayerPrefs.SetInt("bowselected",0);
		}
}
