using UnityEngine;
using System.Collections;

public class reawrds : MonoBehaviour {

	// Use this for initialization
	
	//public int _currentrewards;
	//public static reawrds instances;
	void Start () 
	{
	 //instances=this;
	  getcoins();
	}
	
	// Update is called once per frame
	void Update () 
	{
	    
		//transform.guiText.text=""+ _currentrewards;
	}
	
	void  getcoins()
	
	{
		
		
			
	  switch(notDestroy.instances._selectchallenge)//notDestroy.instances.challengeSelect)
			
		{
		case 1: transform.GetComponent<GUIText>().text=""+store_currentStatus.instances._firstrewards;
				// reawrds.instances._currentrewards=store_currentStatus.instances._firstrewards;
			break;
		
		case 2:transform.GetComponent<GUIText>().text=""+store_currentStatus.instances._secondrewards;
				//reawrds.instances._currentrewards=store_currentStatus.instances._secondrewards;
			break;
			
		case 3: transform.GetComponent<GUIText>().text=""+store_currentStatus.instances._thirdrewards;
				//reawrds.instances._c+urrentrewards=store_currentStatus.instances._thirdrewards;
			break;
		
		case 4:transform.GetComponent<GUIText>().text=""+store_currentStatus.instances._fourthrewards;
				//reawrds.instances._currentrewards=store_currentStatus.instances._fourthrewards;
			break;
		case 5: transform.GetComponent<GUIText>().text=""+store_currentStatus.instances._fifthrewards;
				//reawrds.instances._currentrewards=store_currentStatus.instances._fifthrewards;
			break;
		
		case 6:  transform.GetComponent<GUIText>().text=""+store_currentStatus.instances._sixthrewards;
				//reawrds.instances._currentrewards=store_currentStatus.instances._sixthrewards;
			break;
			
		case 7:  transform.GetComponent<GUIText>().text=""+store_currentStatus.instances._sevenrewards;
				
			break;
		
		case 8:  transform.GetComponent<GUIText>().text=""+store_currentStatus.instances._eightrewards;
				//reawrds.instances._currentrewards=store_currentStatus.instances._eightrewards;
			break;
			
		case 9: transform.GetComponent<GUIText>().text=""+store_currentStatus.instances._ninethrewards;
				//reawrds.instances._currentrewards=store_currentStatus.instances._ninethrewards;
			
			break;
			
		case 10:
			   transform.GetComponent<GUIText>().text=""+store_currentStatus.instances._tenrewards ;
			break ;
		case 11:
			  transform.GetComponent<GUIText>().text=""+store_currentStatus.instances._elvenrewards ;
			break ;
		case 12:
			  transform.GetComponent<GUIText>().text=""+store_currentStatus.instances._tewelrewards ;
			break ;
		case 13:
			  transform.GetComponent<GUIText>().text=""+store_currentStatus.instances._thirteenrewards;
			break ;
		case 14:
			  transform.GetComponent<GUIText>().text=""+store_currentStatus.instances._fourteenrewards ;
			break ;
		case 15:
			  transform.GetComponent<GUIText>().text=""+store_currentStatus.instances._fifteenrewards ;
			break ;
		}

	}
}
