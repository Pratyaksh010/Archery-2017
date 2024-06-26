// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;
public class SmoothLookAtCS : MonoBehaviour {
//public static SmoothLookAtCS instance;
public GameObject target;
public float damping= 6.0f;
public bool smooth= true;

	
//@script AddComponentMenu("Camera-Control/Smooth Look At")
// this script are use camera smooth follow
//void Awake()
//{
  
// instance=this;
	
//}
   void  LateUpdate ()// Late
	{
		
	   if (target) 
		{
		       // if (smooth)
		     // {       reset();
			       // Look at and dampen the rotation
			        //  Quaternion rotation= Quaternion.LookRotation(target.transform.position - transform.position);
			         // transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
		      //}
		      // else
		     // {
			// Just lookat
				     
		              transform.LookAt(target.transform);
		     // }
	       }
    }


public void reset()
{
		
		 // rigidbody.freezeRotation = true;
		if (GetComponent<Rigidbody>())
		
			GetComponent<Rigidbody>().freezeRotation = true;
		     
		  
	   target=GameObject.Find("ArrowParrent(Clone)")as GameObject;

}
	

}