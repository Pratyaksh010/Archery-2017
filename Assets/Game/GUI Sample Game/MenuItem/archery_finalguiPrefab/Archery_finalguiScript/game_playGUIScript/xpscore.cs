using UnityEngine;
using System.Collections;

public class xpscore : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		//////transform.guiText.text=""+PlayerPrefs.GetInt("XpScore");
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		transform.GetComponent<GUIText>().text=""+PlayerPrefs.GetInt("XpScore");
		
		
	}
}
