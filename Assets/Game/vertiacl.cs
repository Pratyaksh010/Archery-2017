using UnityEngine;
using System.Collections;

public class vertiacl : MonoBehaviour {
public Transform _object ;
	public Color setcolor ;
	public Material o1 ;
	public Material o2 ;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	 public float vSliderValueR = 0.0F;
	 public float vSliderValueG = 0.0F;
	 public float vSliderValueB = 0.0F;
    void OnGUI()
	{
          vSliderValueR = GUI.VerticalSlider(new Rect(25, 25, 100, 200), vSliderValueR, 1.0F, 0.0F);
		  vSliderValueG = GUI.VerticalSlider(new Rect(200, 25, 100, 200), vSliderValueG, 1.0F, 0.0F);
		 vSliderValueB = GUI.VerticalSlider(new Rect(400, 25, 100, 200), vSliderValueB, 1.0F, 0.0F);
		
		GUI.Label(new Rect(25, 0, 100, 30), "R="+ vSliderValueR);
		GUI.Label(new Rect(150, 0, 100, 30), "G="+ vSliderValueG);
		GUI.Label(new Rect(300, 0, 100, 30), "B="+  vSliderValueB);
		_object.transform.GetComponent<Renderer>().material.color = new Color (vSliderValueR,vSliderValueG,vSliderValueB) ;
		o1.color = _object.transform.GetComponent<Renderer>().material.color ;
		o2 .color = o1.color ;
    }
}
