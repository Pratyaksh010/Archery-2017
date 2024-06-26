using UnityEngine;
using System.Collections;

public class show_arrow : MonoBehaviour {
	
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
		   _mytransform.GetComponent<GUIText>().text = " "+challenge_Controll.instances.noArrow;;
		//}
	
	}
}
