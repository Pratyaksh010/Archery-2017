using UnityEngine;
using System.Collections;

public class RagDollAnimation : MonoBehaviour {

	 public Rigidbody[] bodies;
	
	 public static RagDollAnimation instance;
void  Start () {

  for(int i =0;i<bodies.Length;i++)
     {
         bodies[i].isKinematic=true;
         
      }
   
}
	
void Awake()
	{
		
	  instance=this;	
	}
public void  ApplyAnimation(string  hitedBody ,Vector3 hitPosition,Vector3 hitDirection)
	{

		//animation.Stop();
	     for(int i=0;i<bodies.Length;i++)
	     {
	         bodies[i].isKinematic=false;
	         
	         if(bodies[i].transform.name==hitedBody)
			{
			  if(hitedBody!="Apple")	
	            bodies[i].AddForceAtPosition(hitDirection*100,hitPosition,ForceMode.Impulse);
				
			  else
				bodies[i].AddForceAtPosition(hitDirection*2,hitPosition,ForceMode.Impulse);	
				
			}
			
		 if(bodies[i].name=="Apple" && hitedBody!="Apple")
			bodies[i].GetComponent<Rigidbody>().velocity=-Vector3.up;
	           
	          //if(hitedBody!="Apple" && i==bodies.Length-1)
	            //bodies[i].rigidbody.velocity=-Vector3.up*1; 
	     
	     
	     }
   }
}
