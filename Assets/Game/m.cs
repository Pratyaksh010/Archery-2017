using UnityEngine;
using System.Collections;

public class m : MonoBehaviour {

	// Use this for initialization
	public Texture t;
	 private float rotAngle = 0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		
	
	   
		  
		
	}
	  void OnGUI() {
      Vector2  pivotPoint = new Vector2(Screen.width/2-50, 100);
        GUIUtility.RotateAroundPivot(rotAngle, pivotPoint);
		
        GUI.DrawTexture(new Rect(Screen.width / 2 - 25, Screen.height / 2 - 25, 50, 50),t);
        rotAngle=  rotAngle+1;
		
    }
	
}
