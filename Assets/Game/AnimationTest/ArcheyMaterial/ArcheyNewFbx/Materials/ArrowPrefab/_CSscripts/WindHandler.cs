using UnityEngine;
using System.Collections;

public class WindHandler : MonoBehaviour {
	
	
	public float minWind;
	
	public float maxWind;
	
	public Rigidbody effectedBody;
	
	int direction;
	
	float windValue;
	// Use this for initialization
	void Start () {
	
		
		int randomValue=(int)Random.Range(0,10);
		
	     if(randomValue<5)
			direction=1;
		
		 else
			direction=-1;
		
		windValue=Random.Range(minWind,maxWind);
	}
	
	// Update is called once per frame
	void Update () {
	
		
		 if(!effectedBody.isKinematic)
			effectedBody.velocity=effectedBody.velocity+(Vector3.right)*windValue*direction;
			
	}
}
