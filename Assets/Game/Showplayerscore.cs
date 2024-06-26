using UnityEngine;
using System.Collections;

public class Showplayerscore : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	   transform.GetComponent<GUIText>().text =""+gamegui_play.instances.SUM ;//SUM
	}
}
