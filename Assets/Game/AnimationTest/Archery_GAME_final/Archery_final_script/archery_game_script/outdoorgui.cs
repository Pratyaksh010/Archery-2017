using UnityEngine;
using System.Collections;

public class outdoorgui : MonoBehaviour 
{
	public Texture bacgroundtexture;
	public Rect backgroundrect;
	public Texture play;
	public Texture Distance;
	public Rect playrect;
	public Rect distancerect;
	public Texture level;
	public Rect levelrect;
	public Texture decreaselevel;
	public Texture increaselevel;
	public Rect decreaserect;
	public Rect increaserect;
	public Texture aftertouchde;
	public Texture aftertouchince;
	public Texture[] distancenum;
	public Texture[] instancenum;
	public Rect dec;
	public Rect inc;
	public int inc1;
	public int inc2;
	public bool changecolor;
	public Texture currende;
	public Texture currenin;
	public notDestroy notdetroysc;
	public Transform notdestroyObject;
	public Texture afterPlay;
	public Texture currentplay;
	// Use this for initialization
	void Start () 
	{
	    backgroundrect=new Rect (0,0,Screen.width,Screen.height);
		playrect=new Rect(Screen.width/2-100,Screen.height-100,200,100);
		levelrect=new Rect(Screen.width/2-100,Screen.height/2-100,200,100);
		distancerect=new Rect(Screen.width/2-100,Screen.height/2+10,200,100);
		decreaserect=new Rect(Screen.width/2-170,Screen.height/2+10,50,100);
		increaserect=new Rect(Screen.width/2+125,Screen.height/2+10,50,100);
		//dec=new Rect(Screen.width/2-220,Screen.height/2+10,50,100);
		inc=new Rect(Screen.width/2+220,Screen.height/2+10,50,100);
		currende=decreaselevel;
		currenin=increaselevel;
		notdetroysc=GameObject.Find("Nondestroy").GetComponent("notDestroy")as notDestroy;
		currentplay=play;
		//inc1=0;
		//inc2=0;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    
		 if(CheckInsideRect(playrect))
		{
			currentplay= afterPlay;
			if(Input.GetMouseButtonDown(0))
			{
				Application.LoadLevel(4);
			}
		}
		else
		{
			currentplay=play;
		}
		
		  if(CheckInsideRect(decreaserect))
		 {
			currende=aftertouchde;
			if(Input.GetMouseButtonDown(0)&&notdetroysc.targetdistance>0)
			{
				notdetroysc.targetdistance=notdetroysc.targetdistance-1;
				//notdetroysc.targetdistance=inc2;
			}
		 }
		else
		{
		   currende=decreaselevel;
		}
		if(CheckInsideRect(increaserect))
		{
			currenin=aftertouchince;
			if(Input.GetMouseButtonDown(0)&&notdetroysc.targetdistance<2)
			{
				notdetroysc.targetdistance=notdetroysc.targetdistance+1;
				//notdetroysc.targetdistance=inc2;
			}
		}
		else
		{
			currenin=increaselevel;
		}
		
	}
	void OnGUI()
	{
		GUI.DrawTexture( backgroundrect,bacgroundtexture);
		GUI.depth=1;
		GUI.DrawTexture( playrect,currentplay);
		GUI.DrawTexture( levelrect,level);
		GUI.DrawTexture( distancerect,Distance);
		if(notdetroysc.targetdistance>0)
		{
		GUI.DrawTexture( decreaserect,currende);
		}
		if(notdetroysc.targetdistance<2)
		{
		GUI.DrawTexture( increaserect,currenin);
		
		}
		
		GUI.DrawTexture( inc,instancenum[notdetroysc.targetdistance]);
	}

  bool CheckInsideRect(Rect rectToCheck) 
 {
   rectToCheck.y=Screen.height-rectToCheck.y-rectToCheck.height;   
   return rectToCheck.Contains(Input.mousePosition);
 }
	
}