using UnityEngine;
using System.Collections;

public class storeScoreInboard : MonoBehaviour {
	
	// Use this for initialization
	
	public GUIText[] text;
	
	public bool show;
	void Start () 
	{
		controll.instance.pause=true;// not show wind 
		
		
		if(controll.instance.showend1)
		{
			text[0].text=""+controll.instance.firstendsum;
			
			text[5].text=""+enemy_score.instances.firstsetscore;
			show=true;
		}
		
		if(challenge_Controll.instances.showend1)
		{
			text[0].text=""+challenge_Controll.instances.firstendsum;
			
			text[5].text=""+enemy_score.instances.firstsetscore;
			show=true;
		}
		if(controll.instance.showend2)
		{
			text[1].text=""+controll.instance.secondendsum;
			text[6].text=""+enemy_score.instances.secondsetscore;
			show=true;
		}
		if(challenge_Controll.instances.showend2)
		{
			text[1].text=""+challenge_Controll.instances.secondendsum;
			text[6].text=""+enemy_score.instances.secondsetscore;
			show=true;
		}
		if(controll.instance.showend3)
		{
			text[2].text=""+controll.instance.thirdendsum;
			text[7].text=""+enemy_score.instances.thirdsetscore;
			show=true;
		}
		if(challenge_Controll.instances.showend3)
		{
			text[2].text=""+challenge_Controll.instances.thirdendsum;
			text[7].text=""+enemy_score.instances.thirdsetscore;
			show=true;
		}
		
		if(controll.instance.showend4)
		{
			text[3].text=""+controll.instance.fourendsum;
			text[8].text=""+enemy_score.instances.foursetscore;
			show=true;
		}
		if(challenge_Controll.instances.showend4)
		{
			text[3].text=""+challenge_Controll.instances.fourendsum;
			text[8].text=""+enemy_score.instances.foursetscore;
			show=true;
		}
		  if(show==true) 
			
		{
		    if(controll.instance.challenge_mode==false)
			{
		  text[4].text=""+controll.instance.totalsum;
		  
		  text[9].text=""+enemy_score.instances.enemyScoreSum;
				
				
			}
			else{
				 text[4].text=""+challenge_Controll.instances.totalsum;
		  
		         text[9].text=""+enemy_score.instances.enemyScoreSum;
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
