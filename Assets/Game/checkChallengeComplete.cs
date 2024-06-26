using UnityEngine;
using System.Collections;

public class checkChallengeComplete : MonoBehaviour {
	
	public int _challenegecomplete ;
	
	public Texture _changeTexture ;
	
	int i ;
	
	public bool check ;
	// Use this for initialization
	void Start ()
	{
		if(check == true )
		{
		if(_challenegecomplete>1)
		{
			i = _challenegecomplete - 1 ;
		}
		
		if(PlayerPrefs.GetInt("challenge"+i)==1)
		{
			GetComponent<GUITexture>().texture = _changeTexture ;
		}
		}
		else
		{
			if(PlayerPrefs.GetInt("challenge"+_challenegecomplete)==1)
		   {
			  GetComponent<GUITexture>().texture = _changeTexture ;
		   }
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
