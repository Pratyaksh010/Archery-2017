using UnityEngine;
using System.Collections;

public class playerS : MonoBehaviour
{
	
	int sum ;
	Transform _mytransform ;
	public bool check ;
	// Use this for initialization
	void Start ()
	{
	   _mytransform = transform ;
	}
	
	// Update is called once per frame
	void Update () 
	{
		  if(check ==false)
		{
		
	       _mytransform.GetComponent<GUIText>().text = ""+challenge_mode_gui.instances.PlayerTotalScore ;
			
		}
		if(check ==true)
		{
			_mytransform.GetComponent<GUIText>().text = ""+ challenge_mode_gui.instances._sum ;
			
		}
	}
}
