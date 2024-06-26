using UnityEngine;
using System.Collections;

public class GameStatistics : MonoBehaviour {
	
	
	public GameObject arrow;
	
	public static GameStatistics instance;
	// Use this for initialization
	void Start () {
	
		loadObject();
	}
	
	void Awake()
	{
		instance=this;
	}
	
	// Update is called once per frame
	/*void Update () {
	
	}*/
	
	public void loadObject()
	{
		GameObject.Instantiate(arrow,arrow.transform.position,arrow.transform.rotation);
		
	}
	
	void OnGUI()
	{
	    if(GUI.Button(new Rect(Screen.width-100,0,100,75),"Menu"))
           Application.LoadLevel(0); 	
		
	}
		
}
