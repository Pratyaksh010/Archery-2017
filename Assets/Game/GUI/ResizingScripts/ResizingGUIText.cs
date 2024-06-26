using UnityEngine;
using System.Collections;

public class ResizingGUIText : MonoBehaviour 
{	
	private GUIText myText;

    public float pi_X;
    public float pi_Y;
    public float pi_Width;
    public float pi_Height;
	
    private Vector2 tempRect;

	// Use this for initialization
	void Start () 
    {
        myText = gameObject.GetComponent<GUIText>();		
		pi_X = myText.pixelOffset.x;
		pi_Y = myText.pixelOffset.y;
		//pi_Width = myText.pixelInset.width;
		//pi_Height = myText.pixelInset.height;
	}
	
	// Update is called once per frame
	void Update () 
    {
       	tempRect.x = pi_X * ResizingViewport.instance.ratio;
        tempRect.y = pi_Y * ResizingViewport.instance.ratio;
        //tempRect.width = pi_Width * ResizingViewport.instance.ratio;
        //tempRect.height = pi_Height * ResizingViewport.instance.ratio;
		//Debug.Log(ResizingViewport.instance.ratio);
        if (myText.pixelOffset != tempRect)
        {
            myText.pixelOffset = tempRect;
		}
	}
}
