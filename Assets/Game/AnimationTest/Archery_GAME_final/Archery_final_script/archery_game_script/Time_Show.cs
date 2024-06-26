using UnityEngine;
using System.Collections;

public class Time_Show : MonoBehaviour 
{

public float startTime;

public int restSeconds;

private int roundedRestSeconds;

public int displaySeconds;

public int displayMinutes;

public  int guiTime;

public int countDownSeconds;

public string text;
	
public bool showtimestart;
	
//public Texture timetexure;
	
public bool timecomplete;
	
public GUIStyle style1;
	
public int afterpausestoretime;
	
public bool timestop;// when click the pause than time stop
	
public int currenttimestore;// game start than current time store;

public GUIText minute;
	
public GUIText second;
 
public AudioSource timeaudio;
	
public float _currenttime;
	
public bool chekchallengemode;	
	
public static Time_Show instances ;
	
float checksecond ;
	
int decreaseTime ;
//public GUIText _minute ;
	
//public GUIText _second ;
	
void Start()
	{
		instances = this ;
		
		minute.material.color=Color.black;
		
		second.material.color=Color.black;
		
		_currenttime=Time.time;
		
		
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge2||challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge6)
		{
			chekchallengemode=true;
			timeaudio.GetComponent<AudioSource>().volume=1f;
		}
	}

void OnGUI ()
	
{
     
     
    //make sure that your time is based on when this script was first called
    //instead of when your game started
	
      if(timestop==true&&chekchallengemode==true)//&&challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge2||challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge6)
		{
			timeaudio.GetComponent<AudioSource>().Stop();
		}
  
  if(timestop==false&&controll.instance.challenge_mode==true)
			
{
		
	if(showtimestart==true&& restSeconds>=0)
			
    {
          
		
		if(Time.time-_currenttime>=1f&&chekchallengemode==true)//&&challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge2||challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge6)
			{
				timeaudio.GetComponent<AudioSource>().Play();
				_currenttime=Time.time;
			}
				
				
		guiTime = (int)(Time.time - startTime);
   
        checksecond  = Time.time - startTime ;
		
		if(checksecond>.6f)
		{
			decreaseTime = decreaseTime+1 ;
		    ////restSeconds = countDownSeconds - (decreaseTime) ;
		    checksecond = 0f;
		    
			startTime = Time.time ;
		}
				print (" checksecond=="+guiTime);
		//restSeconds = countDownSeconds - (guiTime);
				
	   restSeconds = countDownSeconds - (decreaseTime) ;
    //display messages or whatever here -->do stuff based on your timer
                    
		if (restSeconds == 60) 
		            
		{
        
				     print ("One Minute Left");
       }
                
	   if (restSeconds == 0)
		           
		{
       
		            print ("Time is Over");
                  //gameguiscript.gameover=true;
                 //do stuff here
       }

    //display the timer
      roundedRestSeconds = Mathf.CeilToInt(restSeconds);
    
	  displaySeconds = roundedRestSeconds % 60;
    
	  displayMinutes = roundedRestSeconds / 60; 
   
     if(restSeconds==0)
	        
    {
				
     timecomplete=true;		
		
     showtimestart=false;
	 store_currentStatus.instances.offcontrolling=true;	
		
	 }
   
   }
  
  if(restSeconds>=0)
              
   {
               minute.text=""+displayMinutes;
				
			   second.text=""+displaySeconds;
				//if(_minute!=null)
				//{
			     // _minute.text = ""+displayMinutes;
				//}
				//if(_second!=null)
				//{
			     // _second.text = ""+displaySeconds;
				//}
    }			
	
}		
 	
			
		

		
	
	
		
}

	
}