using UnityEngine;
using System.Collections;

public class resizeguitex : MonoBehaviour {
	private GUITexture myGUITexture;
	
	///public GUITexture t;
	
	public float _posx;
	public float _posy;
	public float widthx;
	public float widthy;
	
	void Awake()
	{
		myGUITexture = this.gameObject.GetComponent("GUITexture") as GUITexture;
	}
	
	// Use this for initialization
	void Start()
	{
		// Position the billboard in the center, 
		// but respect the picture aspect ratio
		
		if(Application.platform!=RuntimePlatform.Android)//&&(iPhone.generation==iPhoneGeneration.iPad3Gen))
		{
			/*  float textureHeight =guiTexture.pixelInset.height;// guiTexture.texture.height;
    float textureWidth = guiTexture.pixelInset.width;//guiTexture.texture.width;
    float screenHeight = Screen.height/factor;
    float screenWidth = Screen.width/factor;
 
    float screenAspectRatio = (screenWidth / screenHeight);
    float textureAspectRatio = (textureWidth / textureHeight);
 
    float scaledHeight;
    float scaledWidth;
    if (textureAspectRatio <= screenAspectRatio)
    {
        // The scaled size is based on the height
        scaledHeight = screenHeight;
        scaledWidth = (screenHeight * textureAspectRatio);
    }
    else
    {
        // The scaled size is based on the width
        scaledWidth = screenWidth;
        scaledHeight = (scaledWidth / textureAspectRatio);
    }
    float xPosition = screenWidth / factor - (scaledWidth / factor);
    myGUITexture.pixelInset = new Rect(_posx, _posy,scaledWidth, scaledHeight);//scaledHeight - scaledHeight
}
		}*/
			
			
			///////////////// myGUITexture.pixelInset = new Rect(_posx, _posy,widthx,widthy);//scaledHeight - scaledHeight	
			
		}	
		if(transform.name == "LeftPad")
		Debug.Log("LeftJoystickPixelInset--"+this.GetComponent<GUITexture>().pixelInset);
		if(transform.name == "RightPad")
		Debug.Log("RightJoystickPixelInset--"+this.GetComponent<GUITexture>().pixelInset);
	}
	
	
}
