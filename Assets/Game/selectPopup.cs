using UnityEngine;
using System.Collections;

public class selectPopup : MonoBehaviour
{
	public Transform _withTimebackground;
	public Transform _withoutTimebackground ;
	public Transform _withAibackground ;
	public Transform _totalScoretext ;
	public Transform _totalarrow ;
	public Transform _minutetime ;
	public Transform _second ;
	public Transform _slash;
	public Transform _playerscoretext ;
	public Transform _aiscoretext ;
	

	// Use this for initialization
	void Start () 
	{
	    if(challenge_bgEvent.instances.notdesScript1.challengeSelect==2||   challenge_bgEvent.instances.notdesScript1.challengeSelect == 6)
		{
			
			_withTimebackground.transform.gameObject.SetActive(true) ;
			_minutetime.transform.gameObject.SetActive(true) ;
			_second.transform.gameObject.SetActive(true) ;
			_slash.transform.gameObject.SetActive(true) ;
			_totalScoretext.transform.gameObject.SetActive(true) ;
			// Time_Show.instances._minute = _minutetime.transform.guiText;
			 //Time_Show.instances._second = _second.transform.guiText ;
			
		}
		else
		{
		  if( challenge_bgEvent.instances.notdesScript1.challengeSelect==7)
		  {
			_withAibackground.transform.gameObject.SetActive(true) ;
			_playerscoretext.transform.gameObject.SetActive(true) ;
			_aiscoretext .transform.gameObject.SetActive(true) ;
		  }
		 else
			{
				_withoutTimebackground.transform.gameObject.SetActive(true) ;
				_totalScoretext.transform.gameObject.SetActive(true) ;
				_totalarrow .transform.gameObject.SetActive(true) ;
				
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
