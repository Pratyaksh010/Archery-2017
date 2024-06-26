using UnityEngine;
using System.Collections;

public class showAiscore : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	     transform.GetComponent<GUIText>().text = ""+controll.instance.enemyScoresum ;
	}
}
