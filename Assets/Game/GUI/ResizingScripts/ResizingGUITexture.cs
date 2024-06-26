using UnityEngine;
using System.Collections;

public class ResizingGUITexture : MonoBehaviour 
{	
	private GUITexture myTexture;

    public float pi_X;
    public float pi_Y;
    public float pi_Width;
    public float pi_Height;
	
    private Rect tempRect;

	// Use this for initialization
	void Start () 
    {
        myTexture = gameObject.GetComponent<GUITexture>();
		//UpdateSizeWithViewPort();
		
		pi_X = myTexture.pixelInset.x;
		pi_Y = myTexture.pixelInset.y;
		pi_Width =  myTexture.pixelInset.width;
		pi_Height = myTexture.pixelInset.height;
		
		if(pi_Width < 1.0f)
			pi_Width =  myTexture.texture.width * (ResizingDefaultSizes.Instance.DefaultResolutionWidth/Screen.width);
		if(pi_Height < 1.0f)
			pi_Height = myTexture.texture.height* (ResizingDefaultSizes.Instance.DefaultResolutionHeight/Screen.height);
	}
	
	void UpdateSizeWithViewPort()
	{
		Rect pixelOffset = myTexture.pixelInset;
		pixelOffset.width = myTexture.texture.width * (ResizingDefaultSizes.Instance.DefaultResolutionWidth/Screen.width);
		pixelOffset.height = myTexture.texture.height * (ResizingDefaultSizes.Instance.DefaultResolutionHeight/Screen.height);
		Debug.Log("-- Tex width " + myTexture.texture.width  + " ht " +  myTexture.texture.height +
			" w -> " + pixelOffset.width + "ht -> " + pixelOffset.height);
		myTexture.pixelInset = pixelOffset;
	}
	// Update is called once per frame
	void Update () 
    {
       	tempRect.x = pi_X * ResizingViewport.instance.ratio;
        tempRect.y = pi_Y * ResizingViewport.instance.ratio;
        tempRect.width = pi_Width * ResizingViewport.instance.ratio;
        tempRect.height = pi_Height * ResizingViewport.instance.ratio;
		//Debug.Log(ResizingViewport.instance.ratio);
        if (myTexture.pixelInset != tempRect)
        {
            myTexture.pixelInset = tempRect;
		}
	}
}
