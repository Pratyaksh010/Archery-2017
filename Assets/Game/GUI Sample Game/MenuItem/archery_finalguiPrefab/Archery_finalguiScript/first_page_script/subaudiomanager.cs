using UnityEngine;
using System.Collections;

public class subaudiomanager : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
		audioManager.instances._bgsound.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[0];
		audioManager.instances._bgsound.volume=1f;
		audioManager.instances.playbackgroundsound();
	}
	
	// Update is called once per frame
	
}
