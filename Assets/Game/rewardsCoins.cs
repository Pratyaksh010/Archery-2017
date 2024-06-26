using UnityEngine;
using System.Collections;

public class rewardsCoins : MonoBehaviour 
{
	int i ;
	// Use this for initialization
	void Start () 
	{
		if(store_currentStatus.instances.currentchall==store_currentStatus.currentChallengedis.current_distance30)
		{
			if(store_currentStatus.instances.currentwin==store_currentStatus.currentChallengewind.current_windeasy)
			{
				transform.GetComponent<GUIText>().text = ""+100 ;
			    i = PlayerPrefs.GetInt("Total_Coins");
				i= i+100 ;
				PlayerPrefs.SetInt("Total_Coins",i);
			}
			if(store_currentStatus.instances.currentwin==store_currentStatus.currentChallengewind.current_windMed)
			{
				transform.GetComponent<GUIText>().text = ""+200 ;
			    i = PlayerPrefs.GetInt("Total_Coins");
				i= i+200 ;
				PlayerPrefs.SetInt("Total_Coins",i);
			}
			if(store_currentStatus.instances.currentwin==store_currentStatus.currentChallengewind.current_windHard)
			{
				transform.GetComponent<GUIText>().text = ""+300 ;
				i = PlayerPrefs.GetInt("Total_Coins");
				i= i+300 ;
				PlayerPrefs.SetInt("Total_Coins",i);
			}
		}
		else
		{
			if(store_currentStatus.instances.currentchall==store_currentStatus.currentChallengedis.current_distance50)
		    {
			if(store_currentStatus.instances.currentwin==store_currentStatus.currentChallengewind.current_windeasy)
			{
				transform.GetComponent<GUIText>().text = ""+200 ;
			    i = PlayerPrefs.GetInt("Total_Coins");
				i= i+200 ;
				PlayerPrefs.SetInt("Total_Coins",i);
			}
			if(store_currentStatus.instances.currentwin==store_currentStatus.currentChallengewind.current_windMed)
			{
				transform.GetComponent<GUIText>().text = ""+400 ;
				i = PlayerPrefs.GetInt("Total_Coins");
				i= i+400 ;
				PlayerPrefs.SetInt("Total_Coins",i);
			}
			if(store_currentStatus.instances.currentwin==store_currentStatus.currentChallengewind.current_windHard)
			{
				transform.GetComponent<GUIText>().text = ""+500 ;
				i = PlayerPrefs.GetInt("Total_Coins");
				i= i+500 ;
				PlayerPrefs.SetInt("Total_Coins",i);
			}
		    }
			else
			{
				if(store_currentStatus.instances.currentchall==store_currentStatus.currentChallengedis.current_distance70)
		        {
			       if(store_currentStatus.instances.currentwin==store_currentStatus.currentChallengewind.current_windeasy)
			       {
				      transform.GetComponent<GUIText>().text = ""+500 ;
					  i = PlayerPrefs.GetInt("Total_Coins");
				      i= i+500 ;
				      PlayerPrefs.SetInt("Total_Coins",i);
			       }
			      if(store_currentStatus.instances.currentwin==store_currentStatus.currentChallengewind.current_windMed)
			      {
                          transform.GetComponent<GUIText>().text = ""+600 ;
						  i = PlayerPrefs.GetInt("Total_Coins");
				          i= i+600 ;
				          PlayerPrefs.SetInt("Total_Coins",i);
			      }
			    if(store_currentStatus.instances.currentwin==store_currentStatus.currentChallengewind.current_windHard)
			     {
				       transform.GetComponent<GUIText>().text = ""+800 ;
					   i = PlayerPrefs.GetInt("Total_Coins");
				       i= i+800 ;
				       PlayerPrefs.SetInt("Total_Coins",i);
			     }
		        }
			}
		}
	   
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
