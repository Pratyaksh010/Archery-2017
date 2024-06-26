using UnityEngine;
using System.Collections;

public class slider : MonoBehaviour {
	 public float vSliderValue = 45.0F;
     void OnGUI() {
        vSliderValue = GUI.VerticalSlider(new Rect(100, 25, 100, 400), vSliderValue, 45.0F,1F);
		transform.GetComponent<Camera>().fieldOfView= vSliderValue;
		GUI.Box(new Rect(20,20,100,20),"=="+transform.GetComponent<Camera>().fieldOfView);
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	     
	}
}
