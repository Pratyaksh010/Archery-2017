using UnityEngine;
 
public class FillScreen:MonoBehaviour
{
    public Camera targetCamera; 
	public float height;
	public float depth;
	Vector3 calculatedPos;
	float h;
	void Start()
	{
		float pos = (targetCamera.nearClipPlane + depth);
  		h = Mathf.Tan(targetCamera.fov*Mathf.Deg2Rad*0.5f)*pos*2f;
		
        calculatedPos = targetCamera.transform.position + targetCamera.transform.forward * pos+ height*Vector3.up;
 
       
 		Debug.Log(h);
        transform.localScale = new Vector3(h*targetCamera.aspect*1.15f,h,1);
		calculatedPos.y -= h; //- height;
		transform.position = new Vector3(calculatedPos.x-20f,calculatedPos.y,calculatedPos.z);
		Destroy(this);
	}
	void Update()
	{
		
	}
	
}
