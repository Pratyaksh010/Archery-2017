// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class ProjectileSpeed : MonoBehaviour {

	
/*public static ProjectileSpeed instance;
	
	void Awake()
	{
	   instance=this;	
		
	}
public float InitialVelocity ( Vector3 targetPoint ,  Transform objectToMove ,  float angle  ){
	
		Vector3 horizontalPoint= new Vector3(targetPoint.x,objectToMove.position.y,targetPoint.z);
	
	objectToMove.LookAt(horizontalPoint);
    
    Vector3 hitPointToObject=(targetPoint-objectToMove.position).normalized;
    
    float angleAlpha= Vector3.Angle(hitPointToObject,objectToMove.forward);
    
    objectToMove.Rotate(-angle,0,0);
    
    float twoTheta=2*angle;
    
    float range=Vector3.Distance(targetPoint,objectToMove.position);
    
   	float cos2Alpha=Mathf.Cos(angleAlpha*Mathf.Deg2Rad)*Mathf.Cos(angleAlpha*Mathf.Deg2Rad);		
   	
   	if(targetPoint.y>objectToMove.position.y)
   	{ 
	      float twoThetaMinusAlpha=(twoTheta-angleAlpha);
	    
	      float sin2ThetaMinusAlpha=Mathf.Sin(twoThetaMinusAlpha*Mathf.Deg2Rad);
	      
	      float sinAlpha=Mathf.Sin(angleAlpha*Mathf.Deg2Rad);
	      
	      float speed=Mathf.Sqrt(Mathf.Abs(range*Mathf.Abs(Physics.gravity.y)*cos2Alpha/(sin2ThetaMinusAlpha-sinAlpha)));
	      
	      return speed;
  	}
  	
  	else
  	{
	      float twoThetaPlusAlpha=(twoTheta+angleAlpha);
	    
	      float sin2ThetaPlusAlpha=Mathf.Sin(twoThetaPlusAlpha*Mathf.Deg2Rad);
	      
	      float sinAlpha2=Mathf.Sin(angleAlpha*Mathf.Deg2Rad);
	      
	      float speed2=Mathf.Sqrt(Mathf.Abs(range*Mathf.Abs(Physics.gravity.y)*cos2Alpha/(sin2ThetaPlusAlpha+sinAlpha2)));
	      
	      return speed2;  
  	}
}*/
}