using UnityEngine;
using System.Collections;

public class addAudio : MonoBehaviour {

	// Use this for initialization
	public AudioClip[] _audio;
	public static addAudio instances;
	public AudioSource currentaudio;
	public AudioSource _backgroundaudio;
	public AudioSource _audiosourcesecond;
	
	void Awake () 
	{
	
		instances=this;
		
		//playbackgroundsound();
		//currentaudio.audio=_audio[1].;
		//_audio[1].isReadyToPlay();
		//audio.Play(_audio[1]);
	}
	
	// Update is called once per frame
	public void playbackgroundsound() 
	{
	
		 if(PlayerPrefs.GetInt("soundon")==2)
		{
			 // _backgroundaudio.audio.clip=_audio[0];
			 _backgroundaudio.GetComponent<AudioSource>().Play();
			//_backgroundaudio.PlayClipAtPoint(_backgroundaudio.audio,new Vector3(Camera.main.transform.position.x,Camera.main.transform.position.y,Camera.main.transform.position.z));
		
		}
		 if(PlayerPrefs.GetInt("soundon")==1)
		{
			// audio.clip=null;
			  _backgroundaudio.GetComponent<AudioSource>().Stop();
		
		}
		print (PlayerPrefs.GetInt("soundon"));
	}
	public void playbackgroundsound1() 
	{
	
		 if(PlayerPrefs.GetInt("soundon")==2)
		{
			 // _backgroundaudio.audio.clip=_audio[0];
			 _audiosourcesecond.GetComponent<AudioSource>().Play();
		
		}
		 if(PlayerPrefs.GetInt("soundon")==1)
		{
			// audio.clip=null;
			 _audiosourcesecond.GetComponent<AudioSource>().Stop();
		
		}
		print (PlayerPrefs.GetInt("soundon"));
	}
	
	
	
	public void playSound()
	{
		
		currentaudio.GetComponent<AudioSource>().Play();
	}
}
