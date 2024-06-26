using UnityEngine;
using System.Collections;

public class aiscore : MonoBehaviour {
	int sum ;
	Transform _mytransform ;
	// Use this for initialization
	void Start ()
	{
	   _mytransform = transform ;
	}
	
	// Update is called once per frame
	void Update ()
	{
	   if(sum!=challenge_Controll.instances.enemyScoresum)
		{
	       _mytransform.GetComponent<GUIText>().text = ""+challenge_Controll.instances.enemyScoresum ;
			sum =challenge_Controll.instances.enemyScoresum ;
		}
	}
}
