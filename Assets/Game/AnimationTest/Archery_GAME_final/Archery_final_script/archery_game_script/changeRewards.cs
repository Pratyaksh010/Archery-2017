using UnityEngine;
using System.Collections;

public class changeRewards : MonoBehaviour
{

	// Use this for initialization
	public int _comaprevar;
	
	public int _rewardscost;
	void Start () 
	{
		if(_comaprevar<=PlayerPrefs.GetInt("currentchalleneg"))//PlayerPrefs.GetInt("numberOfChallenge"))
		{
			transform.GetComponent<GUIText>().text=""+_rewardscost+"  "+ "COINS";
		}
	
	}
	
	
}
