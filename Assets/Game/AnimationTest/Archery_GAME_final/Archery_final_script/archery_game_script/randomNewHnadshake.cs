using UnityEngine;
using System.Collections;

public class randomNewHnadshake : MonoBehaviour {
	public float idle;
	
	public float idlemov; 
	
	public float smooth;
	
	public Vector3 midpoint;
	
	public float timer;
	
	private float idlespeed  ; 

    private float idleamount ;
	
	public bool k;
	
	public float currenidlespeed;
	
	public float i;
	
	Vector3 currentPosition ;
	
	public bool startshaking;
	
	public static randomNewHnadshake instances;
	
	public float startidlemov;
	// Use this for initialization
	
	void Awake()
	{
	    instances=this;
		midpoint = transform.localPosition;
	    k=true;
		idlemov=startidlemov;
		idlemov=idlemov-PlayerPrefs.GetFloat("stabilityvalue");
	}
	// Update is called once per frame
	
	void FixedUpdate ()
	{
		if(startshaking==true)
		
	  {
		
		currenidlespeed=idle;
		
		float wave1 = 0.0f;  
        
		float wave2 = 0.0f;
       
		wave1 = Mathf.Sin(timer*2); 
       
		wave2 = Mathf.Sin(timer);
        
		timer = timer + idlespeed ; 
		
		if (timer > Mathf.PI * 2f) { 
         
		 timer = timer - (Mathf.PI * 2f); 
       } 
   
	if (wave1!= 0f) 
	  { 
		
		float TranslateChange = wave1 * idleamount; 
		
		float TranslateChange2 = wave2* idleamount;
		
		float TotalAxes = Mathf.Clamp (1.0f, 0.0f, 1.0f); 
		
		float translateChange = TotalAxes * TranslateChange; 
		
		float translateChange2 = TotalAxes * TranslateChange2; 
		
		if(k)
		{
			//Player walk
		  currentPosition = new Vector3( midpoint.x + translateChange2,midpoint.y + translateChange,transform.position.z);
			//currentPosition = midpoint.x + translateChange2;
   	    }
   		
    }else
	  {
    	//Player not move
    	currentPosition = midpoint;
       } 
		if(k){
		idlespeed  = currenidlespeed;
		idleamount =idlemov*0.3f;
		
	}
	
	
	   i += Time.deltaTime * smooth;
	
	transform.localPosition = Vector3.Lerp(transform.localPosition,currentPosition, i);
	}
}

}