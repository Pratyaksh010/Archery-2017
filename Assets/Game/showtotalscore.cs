using UnityEngine;
using System.Collections;

public class showtotalscore : MonoBehaviour {

public Transform _mytransform ;
	int i;
	// Use this for initialization
	void Start ()
	{
	   _mytransform = transform ;
	}
	
	// Update is called once per frame
	void Update () 
	{
		// if(i!=challenge_mode_gui.instances.numberofarrow)
		//{
		   _mytransform.GetComponent<GUIText>().text = " "+challenge_mode_gui.instances.PlayerTotalScore ;
		//}
	
	}
}
