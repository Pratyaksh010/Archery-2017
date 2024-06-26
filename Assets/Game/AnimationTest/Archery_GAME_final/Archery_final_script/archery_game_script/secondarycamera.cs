using UnityEngine;
using System.Collections;

public class secondarycamera : MonoBehaviour {
	public Transform targetObject;
    public Ray ray;
	public RaycastHit hit;
	public Transform board;
	public Transform SecondaryCam;
	public float boarddistance;
	public int max;
	public int min;
    private float widthFactor;
	private float  heightFactor;
	//public Texture plus;
	//////public Texture minus;
	public static secondarycamera instance;
	public Vector3 checkRect;
	private Rect camrect;
	public float radius;
	private Vector3 offset;
	private float distance;
	public Transform mainarcheryboard;
	private bool controlStart;
	private bool challengeStart;
	// Use this for initialization
	
	void Awake () 
	{
	     // SecondaryCam.position=new Vector3(board.position.x,board.position.y-.4f,board.position.z-3);
		
		 /////// widthFactor=Screen.width/517.0f;
        /////  heightFactor=Screen.height/388.0f;
		  instance=this;
		  //board.position=new Vector3(mainarcheryboard.position.x,mainarcheryboard.position.y,mainarcheryboard.position.z);
		  //SecondaryCam.position=new Vector3( board.position.x, board.position.y, board.position.z-3f);
		//print ("camera_rect11=="+Vector3.Distance(new Vector3(0f,1f,0f),new Vector3(3.5f,1f,3.5f)));
	}
	void Start()
	{
		controlStart=controll.instance.starttarget;
		challengeStart=challenge_Controll.instances.starttargetChallenge;
		
	}
   Rect ResolutionHelper ( Rect rect  )
   {
    
     return (new Rect(rect.x*widthFactor,rect.y*heightFactor,rect.width*widthFactor,rect.height*heightFactor));
   }
	// Update is called once per frame
	void Update () 
	{

		Debug.Log(controll.instance.starttarget);
		Debug.Log(challenge_Controll.instances.starttargetChallenge);
	         //ray=Camera.main.ScreenPointToRay(new Vector3(FPSControls.instance.crossHairRect.x+FPSControls.instance.crossHairRect.width/2,Screen.height-FPSControls.instance.crossHairRect.y-FPSControls.instance.crossHairRect.height/2,0));
		  if(controll.instance.starttarget==true)//||challenge_Controll.instances.starttargetChallenge==true) 
		 {
		     Vector3 projectPoint2D=Camera.main.WorldToScreenPoint(FPSControls.instance.crosshairobject.transform.position);
		     ray=Camera.main.ScreenPointToRay(projectPoint2D);//new Ray(FPSControls.instance.crosshairobject.transform.position,FPSControls.instance.crosshairobject.transform.forward);//Camera.main.ScreenPointToRay(new Vector3(FPSControls.instance.projectionpoint.x,FPSControls.instance.projectionpoint.y,0));//new Ray(FPSControls.instance.crosshairobject.transform.position,FPSControls.instance.crosshairobject.transform.forward);//Camera.main.ScreenPointToRay(FPSControls.instance.crosshairobject.transform.position,FPSControls.instance.crosshairobject.transform.forward,0);
		     Debug.DrawLine( ray.origin,ray.GetPoint(100),Color.black);   
		   if(Physics.Raycast(ray.origin,ray.direction,out hit,Mathf.Infinity))
		  {
                Debug.Log("In physics ray cast condition 1");
                targetObject.position=new Vector3(hit.point.x,hit.point.y,targetObject.position.z);
			
			///offset=targetObject.position-board.position;
			/////distance =Vector2.Distance(new Vector2(targetObject.position.x,targetObject.position.y),new Vector2(board.position.x,board.position.y));
			///if(distance>radius) 
			//{
				//Vector2 norm=offset.normalized;
				///targetObject.position=new Vector3(((norm.x*radius)+board.position.x),((norm.y*radius)+board.position.y),targetObject.position.z);
				//targetObject.renderer.material.color=new Color(1f,1f,1f,targetObject.renderer.material.color.a); 
			    //targetObject.renderer.material.color=new Color(1f,0f,0f,targetObject.renderer.material.color.a);
			//}
			//else
			///{
				///targetObject.renderer.material.color=new Color(1f,1f,1f,targetObject.renderer.material.color.a); 
			//}
		
		}
	}
		
	if(challenge_Controll.instances.starttargetChallenge==true)
	{
		     Vector3 projectPoint2D=Camera.main.WorldToScreenPoint(FPSControls.instance.crosshairobject.transform.position);
		     ray=Camera.main.ScreenPointToRay(projectPoint2D);//new Ray(FPSControls.instance.crosshairobject.transform.position,FPSControls.instance.crosshairobject.transform.forward);//Camera.main.ScreenPointToRay(new Vector3(FPSControls.instance.projectionpoint.x,FPSControls.instance.projectionpoint.y,0));//new Ray(FPSControls.instance.crosshairobject.transform.position,FPSControls.instance.crosshairobject.transform.forward);//Camera.main.ScreenPointToRay(FPSControls.instance.crosshairobject.transform.position,FPSControls.instance.crosshairobject.transform.forward,0);
		     Debug.DrawLine( ray.origin,ray.GetPoint(100),Color.black);   
		   if(Physics.Raycast(ray.origin,ray.direction,out hit,Mathf.Infinity))
		  {
                Debug.Log("IN physics ray cast condition 2");
                targetObject.position=new Vector3(hit.point.x,hit.point.y,targetObject.position.z);
			
			///offset=targetObject.position-board.position;
			/////distance =Vector2.Distance(new Vector2(targetObject.position.x,targetObject.position.y),new Vector2(board.position.x,board.position.y));
			///if(distance>radius) 
			//{
				//Vector2 norm=offset.normalized;
				///targetObject.position=new Vector3(((norm.x*radius)+board.position.x),((norm.y*radius)+board.position.y),targetObject.position.z);
				//targetObject.renderer.material.color=new Color(1f,1f,1f,targetObject.renderer.material.color.a); 
			    //targetObject.renderer.material.color=new Color(1f,0f,0f,targetObject.renderer.material.color.a);
			//}
			//else
			///{
				///targetObject.renderer.material.color=new Color(1f,1f,1f,targetObject.renderer.material.color.a); 
			//}
		
		}	
	}
}
	
	

}
