using UnityEngine;
using System.Collections;

public class Taptocountwork : MonoBehaviour 
{
	
	public GUITexture[] texture;
	public ScreenManager screenmanagerscript;
	public Transform ScreenObject;
	public int length;
	public string lodingprefab;
	public bool check;
	public float checktime;
	//public string gameObjectname;
	// Use this for initialization
	void Start () 
	{
	  //  screenmanagerscript=ScreenObject.GetComponent("ScreenManager")as ScreenManager;
		//check=false;
		checktime=Time.time;
	}
	void Awake()
	{
		// screenmanagerscript=ScreenObject.GetComponent("ScreenManager")as ScreenManager;
		 check=false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		 screenmanagerscript=ScreenObject.GetComponent("ScreenManager")as ScreenManager;
		
		if(Time.time-checktime>=.5f&&check==false&&Input.GetMouseButtonDown(0)&&texture[0].HitTest(Input.mousePosition,Camera.main)==false&&texture[1].HitTest(Input.mousePosition,Camera.main)==false)
			
		{
			audioManager.instances._currentaudio.GetComponent<AudioSource>().clip=audioManager.instances._audioclip[19];
			audioManager.instances.playcurrentaudio();
		    //if()
			screenmanagerscript.LoadScreen(lodingprefab);
			check=true;
		}
		
	}
}
