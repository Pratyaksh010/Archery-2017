using UnityEngine;
using System.Collections;

public class GUIMenu : MonoBehaviour {
	
	
	public Rect modeFPS;
	
	public Rect modeSide;
	
	// Use this for initialization
	void Start () {
	
		modeFPS=ResulutionHelper.instance.SetResulution(modeFPS);
		
		modeSide=ResulutionHelper.instance.SetResulution(modeSide);
	}
	
	// Update is called once per frame
	void OnGUI() {
	
		if(GUI.Button(modeFPS,"3D View"))
		{
			Application.LoadLevel(1);
			
		}
		
		if(GUI.Button(modeSide,"2D View"))
		{
			Application.LoadLevel(2);
			
		}
	}
}
