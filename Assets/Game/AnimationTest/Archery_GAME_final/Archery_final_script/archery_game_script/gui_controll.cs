using UnityEngine;
using System.Collections;

public class gui_controll : MonoBehaviour {
    public Rect pauseshowrect;
	public Rect MainMenushowrect;
	public Rect Resumeshowrect;
	public Texture[] guishowtexture;
	public Texture[] aftertouchguiTexture;
	private Texture currentMainmenu;
	private Texture currentResume;
	private Texture currentpause;
	private bool pauseshow;//   game start than show the pause
	
	
 
	// Use this for initialization
	void Start () 
	{
	   pauseshowrect=new Rect (0,0,40,40);
	   
	   MainMenushowrect=new Rect(Screen.width/2-60,Screen.height/2-30,120,60);
	   
	   Resumeshowrect=new Rect(Screen.width/2-60,Screen.height/2+40,120,60);
	   
	   currentpause=guishowtexture[0];
	   
	   currentMainmenu=guishowtexture[1];
	  
	   currentResume=guishowtexture[2];
		//Resumeshowrect
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*if(pauseshow==false)
		{
		if(CheckInsideRect(pauseshowrect))
		{
			currentpause=aftertouchguiTexture[0];
			if(Input.GetMouseButtonDown(0))
			{
				pauseshow=true;
				Time.timeScale=0;
			}
		}
		else
		{
			 currentpause=guishowtexture[0];
		}*/
	//}
	   
	if(pauseshow==true)
			
{
		if(CheckInsideRect(MainMenushowrect))
		{
			 currentMainmenu=aftertouchguiTexture[1];
			if(Input.GetMouseButtonDown(0))
			{
				Time.timeScale=1;
				
				challenge_Controll.instances.starttargetChallenge=false;
				challenge_Controll.instances.setchallengefirstscene();
				controll.instance.starttarget=false;
				Application.LoadLevel(1);
			}
		}
		else
		{
			 currentMainmenu=guishowtexture[1];
		}
		if(CheckInsideRect(Resumeshowrect))
		{
			 currentResume=aftertouchguiTexture[2];
			if(Input.GetMouseButtonDown(0))
			{
				
				pauseshow=false;
				Time.timeScale=1;
			}
		}
		else
		{
			currentResume=guishowtexture[2];
		}
	}
	
}
	void OnGUI()
	
	{
		
	 if(pauseshow==false)
	
	{
		//GUI.DrawTexture( pauseshowrect,currentpause);
			
	}
	//if(pauseshow==true)
	
	//{
		//GUI.DrawTexture( MainMenushowrect,currentMainmenu);
		
		//GUI.DrawTexture( Resumeshowrect,currentResume);
			
	//}
		
		
	}
	
	 bool CheckInsideRect(Rect rectToCheck) 
    {
   
        rectToCheck.y=Screen.height-rectToCheck.y-rectToCheck.height;   
        
		return rectToCheck.Contains(Input.mousePosition);
    }
	
}
