using UnityEngine;
using System.Collections;

public class selectGamePlay : MonoBehaviour {
	
	public Rect rectindoor;
	public Rect rectOutdoor;
	public Rect MainBox;
	public Rect Challege_mod;
	public bool challengList;
	public Rect challengeListBox;
	public Rect[] challenge;
	public notDestroy notdesScript1;
	public Texture[] challengeTexture;
	public Texture[] mode;
	public Texture[] modeAfterTouch;
	private Texture currentIndoor;
	private Texture currentOutdoor;
	private Texture currentChallenge;
	public Texture[] currentchaTex;
	public Texture[] afterchallengeTexture;
	public bool k;
	private Texture t1;
	private Texture t2;
	private Texture t3;
	private Texture t4;
	private Texture t5;
	private Texture t6;
	private Texture t7;
	private Texture t8;
	private Texture t9;
	private Rect rect1;
	private Rect rect2;
	private Rect rect3;
	private Rect rect4;
	private Rect rect5;
	private Rect rect6;
	private Rect rect7;
	private Rect rect8;
	private Rect rect9;
	/*public Texture Privostexture1;
	public Texture Privostexture2;
	public Texture Privostexture3;
	public Texture Privostexture4;
	public Texture Privostexture5;
	public Texture Privostexture6;
	public Texture Privostexture7;
	public Texture Privostexture8;
	public Texture Privostexture9;
	
	public Texture aftertexture1;
	public Texture aftertexture2;
	public Texture aftertexture3;
	public Texture aftertexture4;
	public Texture aftertexture5;
	public Texture aftertexture6;
	public Texture aftertexture7;
	public Texture aftertexture8;
	public Texture aftertexture9;
	*/

	// Use this for initialization
	void Start () 
	{
	   notdesScript1=GameObject.Find("Nondestroy").GetComponent("notDestroy")as notDestroy;
		MainBox=new Rect(Screen.width/2-150,Screen.height/2-100,300,200);
		rectindoor=new Rect(Screen.width/2-150,Screen.height/2-30,100,60);
		rectOutdoor=new Rect((Screen.width/2+50),Screen.height/2-30,100,60);
		Challege_mod=new Rect((Screen.width/2-80),Screen.height/2+30,160,60);
		challengeListBox=new Rect((Screen.width/2-150),Screen.height/2-200,300,450);
		rect1=new Rect((Screen.width/2-80),Screen.height/2-200,160,50);
		rect2=new Rect((Screen.width/2-80),Screen.height/2-150,160,50);
	rect3=new Rect((Screen.width/2-80),Screen.height/2-100,160,50);
		rect4=new Rect((Screen.width/2-80),Screen.height/2-50,160,50);
		rect5=new Rect((Screen.width/2-80),Screen.height/2,160,50);
		rect6=new Rect((Screen.width/2-80),Screen.height/2+50,160,50);
		rect7=new Rect((Screen.width/2-80),Screen.height/2+100,160,50);
		rect8=new Rect((Screen.width/2-80),Screen.height/2+150,160,50);
		rect9=new Rect((Screen.width/2-80),Screen.height/2+200,160,50);
		
		currentIndoor=mode[0];
		currentOutdoor=mode[1];
		currentChallenge=mode[2];
		t1=challengeTexture[0];
		t2=challengeTexture[1];
		t3=challengeTexture[2];
		t4=challengeTexture[3];
		t5=challengeTexture[4];
		t6=challengeTexture[5];
		t7=challengeTexture[6];
		t8=challengeTexture[7];
		t9=challengeTexture[8];
		
		
		
		
		//challenge[8]=new Rect((Screen.width/2-80),Screen.height/2+200,160,50);
	
		if(notdesScript1.checkchallengemode==true)
		{
			//challengList=true;
		}
		else
		{
			//challengList=false;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	  if(challengList==false)
	{
		if(CheckInsideRect(rectindoor))
		{
			currentIndoor=modeAfterTouch[0];
			if(Input.GetMouseButtonDown(0))
			{
				notdesScript1.checkchallengemode=false;
			    Application.LoadLevel(2);
			}
		}
		else
		{
			currentIndoor=mode[0];
		}
		 if(CheckInsideRect(rectOutdoor))
		{
			currentOutdoor=modeAfterTouch[1];
			if(Input.GetMouseButtonDown(0))
			{
				notdesScript1.checkchallengemode=false;
			    Application.LoadLevel(3);
			}
		}
		else
		{
			currentOutdoor=mode[1];
		}
		 if(CheckInsideRect(Challege_mod))
		{
			currentChallenge=modeAfterTouch[2];
			if(Input.GetMouseButtonDown(0))
			{
				notdesScript1.checkchallengemode=true;
			    challengList=true;
			}
		}
		else
		{
			currentChallenge=mode[2];
		}
	}
		
	  if(challengList==true&&k==true)
	{
		if(CheckInsideRect(rect1))
		{
			//currentchaTex[0]=
				t1=afterchallengeTexture[0];
			if(Input.GetMouseButtonDown(0))
		  {
			notdesScript1.challengeSelect=1;
				
			Application.LoadLevel(2);
				
			}
		}
		else
		{
			//currentchaTex[0]
				t1=challengeTexture[0];
		}
		if(CheckInsideRect(rect2))
		{
			//currentchaTex[1]
				t2=afterchallengeTexture[1];
			if(Input.GetMouseButtonDown(0))
		  {
			    notdesScript1.challengeSelect=2;
				notdesScript1.targetdistance=1;
				Application.LoadLevel(4);
				
			}
		}
		else
		{
			//currentchaTex[1]
				t2=challengeTexture[1];
		}
		if(CheckInsideRect(rect3))
		{
			//currentchaTex[2]
				t3=afterchallengeTexture[2];
			if(Input.GetMouseButtonDown(0))
		  {
			  notdesScript1.challengeSelect=3;
				
			  notdesScript1.targetdistance=2;
				
				Application.LoadLevel(4);
				
			}
		}
		else
		{
			//currentchaTex[2]
				t3=challengeTexture[2];
		}
		if(CheckInsideRect(rect4))
		{
			//currentchaTex[3]
				t4=afterchallengeTexture[3];
			if(Input.GetMouseButtonDown(0))
		  {
			    notdesScript1.challengeSelect=4;
				
				notdesScript1.targetdistance=2;
				
				Application.LoadLevel(4);
				
			}
		}
		else
		{
			//currentchaTex[3]
				t4=challengeTexture[3];
		}
			if(CheckInsideRect(rect5))
		{
			//currentchaTex[4]
				t5=afterchallengeTexture[4];
			if(Input.GetMouseButtonDown(0))
		  {
			    notdesScript1.challengeSelect=5;
				
				notdesScript1.targetdistance=1;
				
				Application.LoadLevel(4);
				
			}
		}
		else
		{
			//currentchaTex[4]
				t5=challengeTexture[4];
		}
			if(CheckInsideRect(rect6))
		{
			//currentchaTex[5]
				t6=afterchallengeTexture[5];
			if(Input.GetMouseButtonDown(0))
		  {
			   notdesScript1.challengeSelect=6;
				Application.LoadLevel(2);
				
			}
		}
		else
		{
			//currentchaTex[5]
				t6=challengeTexture[5];
		}
		if(CheckInsideRect(rect7))
		{
			//currentchaTex[6]
				t7=afterchallengeTexture[6];
			if(Input.GetMouseButtonDown(0))
		  {
			  notdesScript1.challengeSelect=7;
				
			}
		}
		else
		{
			//currentchaTex[6]
				t7=challengeTexture[6];
		}
		if(CheckInsideRect(rect8))
		{
			//currentchaTex[7]
				t8=afterchallengeTexture[7];
			if(Input.GetMouseButtonDown(0))
		  {
			 notdesScript1.challengeSelect=8;
			 Application.LoadLevel(2);
				
			}
		}
		else
		{
			//currentchaTex[7]
				t8=challengeTexture[7];
		}
		if(CheckInsideRect(rect9))
		{
			//currentchaTex[8]
				t9=afterchallengeTexture[8];
			if(Input.GetMouseButtonDown(0))
		  {
			   notdesScript1.challengeSelect=9;
				
				notdesScript1.targetdistance=2;
				
				Application.LoadLevel(4);
				
			}
		}
		else
		{
			//currentchaTex[8]
				t9=challengeTexture[8];
		}
		
	}
		
	}
	void OnGUI()
	{
		
	  if(challengList==false)
	{
		GUI.Box( MainBox,"");
		
		GUI.DrawTexture(rectindoor,currentIndoor);
		GUI.DrawTexture(rectOutdoor,currentOutdoor);
		GUI.DrawTexture(Challege_mod,currentChallenge);
		/*if(GUI.Button(rectindoor,mode[0],GUIStyle.none))
		{
			notdesScript1.checkchallengemode=false;
			Application.LoadLevel(2);
		}
		if(GUI.Button(rectOutdoor,mode[1],GUIStyle.none))
		{
			notdesScript1.checkchallengemode=false;
			Application.LoadLevel(3);
		}
		if(GUI.Button(Challege_mod,mode[2],GUIStyle.none))
		{
			notdesScript1.checkchallengemode=true;
			challengList=true;
		}*/
	}
  
	if(challengList==true)
	{
		GUI.Box(challengeListBox,"");
		
		GUI.DrawTexture(rect1,t1);	
		GUI.DrawTexture(rect2,t2);	
		GUI.DrawTexture(rect3,t3);	
		GUI.DrawTexture(rect4,t4);	
		GUI.DrawTexture(rect5,t5);	
		GUI.DrawTexture(rect6,t6);	
		GUI.DrawTexture(rect7,t7);	
		GUI.DrawTexture(rect8,t8);	
		GUI.DrawTexture(rect9,t9);	
	    k=true;
		/*if(GUI.Button(challenge[0],challengeTexture[0],GUIStyle.none))//"Challenge 1"
			{
				notdesScript1.challengeSelect=1;
				
				Application.LoadLevel(2);
			}
		if(GUI.Button(challenge[1],challengeTexture[1],GUIStyle.none))
			{
				notdesScript1.challengeSelect=2;
				notdesScript1.targetdistance=1;
				Application.LoadLevel(4);
			}
		if(GUI.Button(challenge[2],challengeTexture[2],GUIStyle.none))
			{
				notdesScript1.challengeSelect=3;
				
				notdesScript1.targetdistance=2;
				
				Application.LoadLevel(4);
			}
	   if(GUI.Button(challenge[3],challengeTexture[3],GUIStyle.none))
			{
				notdesScript1.challengeSelect=4;
				
				notdesScript1.targetdistance=2;
				
				Application.LoadLevel(4);
			}
		if(GUI.Button(challenge[4],challengeTexture[4],GUIStyle.none))
			{
				notdesScript1.challengeSelect=5;
				
				notdesScript1.targetdistance=1;
				
				Application.LoadLevel(4);
			}
		if(GUI.Button(challenge[5],challengeTexture[5],GUIStyle.none))
			{
				notdesScript1.challengeSelect=6;
				Application.LoadLevel(2);
			}
		if(GUI.Button(challenge[6],challengeTexture[6],GUIStyle.none))
			{
				notdesScript1.challengeSelect=7;
			}
		if(GUI.Button(challenge[7],challengeTexture[7],GUIStyle.none))
			{
				notdesScript1.challengeSelect=8;
				Application.LoadLevel(2);
			}
		if(GUI.Button(challenge[8],challengeTexture[8],GUIStyle.none))
			{
				notdesScript1.challengeSelect=9;
				
				notdesScript1.targetdistance=2;
				
				Application.LoadLevel(4);
			}*/
	}
	
}
	
	bool CheckInsideRect(Rect rectToCheck) 
 {
   
   rectToCheck.y=Screen.height-rectToCheck.y-rectToCheck.height;   
   return rectToCheck.Contains(Input.mousePosition);
 }
	
}
