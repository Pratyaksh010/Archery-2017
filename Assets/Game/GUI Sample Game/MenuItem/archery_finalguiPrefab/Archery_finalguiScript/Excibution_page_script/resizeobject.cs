using UnityEngine;
using System.Collections;

public class resizeobject : MonoBehaviour {

	// Use this for initialization
	
	float mfDefaultResolution = 4.0f/3.0f;
	float mfCurrentResolution;
	float mfResMultiplier = 1.0f;
	
	public bool _alignCenterAccordingToScreen = true;
	public bool _adjustSizeAccordingToScreen = true;
	
	void Start()
	{
		mfCurrentResolution = (float)Screen.width/(float)Screen.height;
		mfResMultiplier = mfDefaultResolution/mfCurrentResolution;
		
		if(_alignCenterAccordingToScreen)
		{
			Vector3 startPos = gameObject.transform.position;
			startPos.x -= 0.5f;
			startPos.x *= mfResMultiplier;
			startPos.x += 0.5f;
			gameObject.transform.position = startPos;
			
		}
	
		if(_adjustSizeAccordingToScreen)
		{
			Vector3 scale = gameObject.transform.localScale;
			scale.x *= mfResMultiplier;
			gameObject.transform.localScale = scale;
		}
		
	
	}
	
}
