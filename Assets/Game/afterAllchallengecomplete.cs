using UnityEngine;
using System.Collections;

public class afterAllchallengecomplete : MonoBehaviour
{
	public Transform _lefthomeButton;
	public Transform _centerhomeButton;
	public Transform _nextbutton;
	// Use this for initialization
	void Start ()
	{
	    if(challenge_bgEvent.instances.notdesScript1._selectchallenge==15)
		{
			_lefthomeButton.gameObject.SetActive(false) ;
			_centerhomeButton.gameObject.SetActive(true) ;
			_nextbutton.gameObject.SetActive(false) ;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
