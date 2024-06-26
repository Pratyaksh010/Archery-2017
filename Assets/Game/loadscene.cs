using UnityEngine;
using System.Collections;

public class loadscene : MonoBehaviour {

	// Use this for initialization
	int i;
	void Start ()
	{
	
	  // store_currentStatus.instances.currentscene=store_currentStatus.instances.rematchscene;
		  notDestroy.instances._activeArrowPopUp = false ;
		  i=store_currentStatus.instances.currentscene;
		
		if(i==1)  // reset purpose
		{
			notDestroy.instances.checkchallengemode=false;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	  //  notDestroy.instances.checkchallengemode=store_currentStatus.instances.challengemodecheck;
	  // store_currentStatus.instances.currentscene=store_currentStatus.instances.rematchscene;
		//if(store_currentStatus.instances.rematchscene<4)
		//{
			//Application.LoadLevel(store_currentStatus.instances.rematchscene);
		//}
		//else
		//{store_currentStatus.instances.loadingcheck==false
		 
			Application.LoadLevel(i);
		//}
		
	}
}
