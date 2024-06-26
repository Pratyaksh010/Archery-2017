using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class audioManager : MonoBehaviour
{

		// Use this for initialization
		public AudioClip[] _audioclip;
	
		public AudioSource _bgsound;
	
		public  AudioSource _currentaudio;
	
		public AudioSource _popupaudio;
	
		public AudioSource _challengeback;
		public static audioManager instances;
	
		void Start ()
		{
				instances = this;
				_bgsound.GetComponent<AudioSource>().clip = _audioclip [0];
	 
		}
	
		public void playbackgroundsound ()
		{
	
				if (PlayerPrefs.GetInt ("soundon") == 2 || PlayerPrefs.GetInt ("soundon") == 0) {
						// _backgroundaudio.audio.clip=_audio[0];
						_bgsound.GetComponent<AudioSource>().Play ();
						PlayerPrefs.SetInt ("musicon", 2); 
						//_backgroundaudio.PlayClipAtPoint(_backgroundaudio.audio,new Vector3(Camera.main.transform.position.x,Camera.main.transform.position.y,Camera.main.transform.position.z));
		
				}
				if (PlayerPrefs.GetInt ("soundon") == 1) {
						//AudioSource.PlayClipAtPoint
						// audio.clip=null;
						_bgsound.GetComponent<AudioSource>().Stop ();
			   
						PlayerPrefs.SetInt ("musicon", 1); 
				}
		}
	
		public void playcurrentaudio ()
		{
				if (PlayerPrefs.GetInt ("musicon") == 1) {
						_currentaudio.GetComponent<AudioSource>().Stop ();
				}
				if (PlayerPrefs.GetInt ("musicon") == 2 || PlayerPrefs.GetInt ("musicon") == 0) {
						_currentaudio.GetComponent<AudioSource>().Play ();
				}
		
				//	audio
		}
	
		public void playpopsound ()
		{
				if (PlayerPrefs.GetInt ("musicon") == 1) {
						_popupaudio.GetComponent<AudioSource>().Stop ();
				}
				if (PlayerPrefs.GetInt ("musicon") == 2 || PlayerPrefs.GetInt ("musicon") == 0) {
						_popupaudio.GetComponent<AudioSource>().Play ();
				}
		}
	
		public void _challengesoundplay ()
		{
				if (PlayerPrefs.GetInt ("soundon") == 2 || PlayerPrefs.GetInt ("soundon") == 0) {
						// _backgroundaudio.audio.clip=_audio[0];
						_challengeback.GetComponent<AudioSource>().Play ();
						//_backgroundaudio.PlayClipAtPoint(_backgroundaudio.audio,new Vector3(Camera.main.transform.position.x,Camera.main.transform.position.y,Camera.main.transform.position.z));
		
				}
				if (PlayerPrefs.GetInt ("soundon") == 1) {
						// audio.clip=null;
						_challengeback.GetComponent<AudioSource>().Stop ();
		
				}
		}
}
