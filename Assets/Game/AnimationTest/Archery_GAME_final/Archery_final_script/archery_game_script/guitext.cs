using UnityEngine;
using System.Collections;

public class guitext : MonoBehaviour {
	 public Rect rect;
	 public string mess;
	 private bool check;
	// Use this for initialization
	void Start () 
	{
	  rect=new Rect((Screen.width/2)-200,(Screen.height/2-160),400,100);
	  mess="Hold left mouse button to pull the Arrow\n               \n Move Mouse to set the direction\n           \nRelease Left Mouse button to release Arrow     \n";
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	 void OnGUI()
	{    
		if(check==false)
		{ GUI.Box(rect,mess);
		 if (GUI.Button(new Rect((Screen.width/2)-50,(Screen.height/2-50),100,100), "PLAY"))
		{  
			check=true;
			Application.LoadLevel(1);
		}
		}
		if(check==true)
		{
			GUI.Label(new Rect((Screen.width/2)-50,(Screen.height/2-50),100,100), "Loading.....");
		}
	}
}
