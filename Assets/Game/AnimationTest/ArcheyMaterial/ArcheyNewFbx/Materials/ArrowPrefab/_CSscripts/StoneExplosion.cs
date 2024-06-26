using UnityEngine;
using System.Collections;

public class StoneExplosion : MonoBehaviour {

	// Use this for initialization
	public float radius;
	public float force;
	
   private Collider[] colliders=new Collider[12]; 
	
	private float explosionTime;
	public float delayTime=1;
	
	private Transform cam;
	
	public string playerName;
	private Transform player;
	
	void Start () {
		
		
		cam=GameObject.Find("Main Camera").transform;
		player=GameObject.Find(playerName).transform;
		
		for(int i=0;i<transform.childCount;i++)
			colliders[i]=transform.GetChild(i).GetComponent<Collider>();
		
	    Explosion();
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position=player.position;
		
		transform.LookAt(cam);
		
		if(Time.time-explosionTime>=delayTime)
		{
		    for(int i=0;i<transform.childCount;i++)
			{
				colliders[i].GetComponent<Rigidbody>().velocity=(transform.position-colliders[i].transform.position.normalized)*(colliders[i].GetComponent<Rigidbody>().velocity.magnitude+0.1f);
			    
				if(Vector3.Distance(transform.position,colliders[i].transform.position)<0.3f)
					colliders[i].gameObject.gameObject.SetActive(false);
			}
		}   
	}
	
	
	void Explosion(){
		
		
		 
		  colliders = Physics.OverlapSphere (transform.position, radius);
		
		  foreach (Collider  hit1  in colliders) 
			 {
				   if (hit1.GetComponent<Rigidbody>())
				   {
						  if(hit1.GetComponent<Rigidbody>().transform.tag=="stone")
						 {
							 hit1.GetComponent<Rigidbody>().AddExplosionForce(force,transform.position, radius, .0f);
					
							 
						 }
				   }
				
			 }
		
		explosionTime=Time.time;
		
	}
}
