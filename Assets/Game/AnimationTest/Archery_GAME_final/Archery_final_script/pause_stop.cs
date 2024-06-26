using UnityEngine;
using System.Collections;

public class pause_stop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if(transform.GetComponent<GUITexture>().HitTest(Input.mousePosition,Camera.main))
		{
			if(notDestroy.instances.checkchallengemode==false)
			{
			controll.instance.flsahscript.gameplaystart=false;
			}
			if(notDestroy.instances.checkchallengemode==true)
			{
			challenge_Controll.instances.flashcontrollingscript.gameplaystart=false;
			}
		}
		else{
			if(notDestroy.instances.checkchallengemode==false)
			{
			controll.instance.flsahscript.gameplaystart=true;
			}
			if(notDestroy.instances.checkchallengemode==true)
			{
			challenge_Controll.instances.flashcontrollingscript.gameplaystart=true;
			}
		}
	
	}
}
