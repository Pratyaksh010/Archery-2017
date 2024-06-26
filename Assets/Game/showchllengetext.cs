using UnityEngine;
using System.Collections;

public class showchllengetext : MonoBehaviour {


	// Use this for initialization
	
	
	void Start () 
	{
	
		switch( notDestroy.instances.challengeSelect)
	{	
		case 1:
			
			transform.GetComponent<GUIText>().text="\nSCORE MORE THAN 75 WITHIN 12 ARROWS";
			
		break;
			
		case 2:
			
			transform.GetComponent<GUIText>().text="\nSCORE MORE THAN 150 IN LESS THAN \n\n90 SECONDS";
			
			
		break;
			
		case 3:
			
			transform.GetComponent<GUIText>().text="\nYOU HAVE 20 ARROWS,SCORE MORE THAN\n\n150";
			
		break;
			
		case 4:
			
			transform.GetComponent<GUIText>().text="\n HIT 7,7,7 CONTINUOUSLY USING\n\n4 ARROWS ";
			
		break;
			
			case 5:
			
			transform.GetComponent<GUIText>().text="\nGET SCORE EXACTLY 57 WITH \n\n8 ARROWS";//
			
		break;
			
		case 6:
			
			transform.GetComponent<GUIText>().text="\nGET SCORE BETWEEN 80-90 WITHIN \n\n60 SECONDS";
			
		break;
			
		case 7:
			
			transform.GetComponent<GUIText>().text="\nBEAT THE OPPONENT IN AN ACTUAL\n\nMATCH INHEAVY WIND CONDITIONS ";
			
		break;
			
		case 8:
			
			transform.GetComponent<GUIText>().text="BEAT THE OPPONENT IN AN ACTUAL MATCH \nIN HEAVY WIND CONDITIONS ";//"SCORE\n MORE THAN 110\n WITH 12\nARROWS ";
			
		break;
			case 9:
			
			transform.GetComponent<GUIText>().text="\nHIT THE BULLS EYE FIVE TIMES WITHIN\n\n 8 ARROWS";
				 
			
			
		break;
			
		case 10:
			
			transform.GetComponent<GUIText>().text="\nGET SCORE BETWEEN 60-65 IN WITHIN\n\n7 ARROWS";
			
			
		break ;
			
		case 11:
			
			transform.GetComponent<GUIText>().text="\nGET SCORE 151 WITHIN 10 ARROWS";///"SCORE\nMORE THAN 42\n WITHIN 4 2XARROWS";
			
		break ;
		case 12:
			
			transform.GetComponent<GUIText>().text="\nGET SCORE 0 WITHIN 10 ARROWS \n\nIN HEAVY WIND CONDITIONS";
			
		break ;
		case 13:
			
			transform.GetComponent<GUIText>().text="\nGET SCORE EXACTLY 60 WITHIN\n\n2 6XARROWS HEAVY WIND CONDITIONS";
			
		break ;
		case 14:
			
			transform.GetComponent<GUIText>().text="\nSCORE MORE THAN 42 WITHIN \n\n4 2XARROWS";//"GET SCORE\n 400 \nWITHIN 15 ARROWS";
			
		break ;
		case 15:
			
			transform.GetComponent<GUIText>().text="\nHIT THE BULLS EYE THREE TIMES\n\nWITHIN 3 6XARROWS";
			
		break ;
		case 16:
			
			transform.GetComponent<GUIText>().text="\nSCORE MORE THAN 600 WITHIN\n\n20 ARROWS ";
		break ;
			
		}
	}
	
	
}


