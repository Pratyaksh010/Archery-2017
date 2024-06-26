/*
using UnityEngine;
using System.Collections;

public class ArrowController : MonoBehaviour {
	
	
	public enum ArrowState
	{
	     ACTIVE,
		 IDLE,
		
		
	};
	
	public	ArrowState arrowState;
	// Use this for initialization
	public float arrowSpeed =14;
	public float arrowMaxSpeed=14;
	public float arrowMinSpeed=2;
	
	public Rect ForceBgRect;
	public Texture ForceBgImage;
	public Rect ForceValueRect;
	public Texture ForceValueBgImage;
	
	private Vector3 startTouchPosition;
	private Vector3 endTouchPosition;
	
	private  float maxDistance =250;
	
	private float IdleSetTime;
	private Transform bow;
	private Transform bowTransform;
	private GameObject inputArea;
	private Transform playerHead;
	
	public Transform rightUpperArm;
	
	public Transform rightLowerArm;
	
	public Transform spine;
	
	public float upperArmSpeed ;
	public float lowerArmSpeed;
	public float ArrowSpeed;
	public float spinSpeed;
	
	void Start () {
	
		
		
	    bow=GameObject.Find("LeftArmParent").transform;
		
		inputArea=GameObject.Find("InputArea");
		
		playerHead=GameObject.Find("Head").transform;
		
		rightUpperArm=GameObject.Find("RightArm").transform;
		
		rightLowerArm=GameObject.Find("RightForeArm").transform;
		
		spine=GameObject.Find("Spine").transform;
		
		spine.eulerAngles=new Vector3(274.3944f,262.213f,15.92502f);
		
		playerHead.eulerAngles=new Vector3(-90,-90,0);
		
		rightUpperArm.localEulerAngles=new  Vector3(273.5573f,0.0006408691f,180.4879f);
		
		rightLowerArm.localEulerAngles=new Vector3(85.35733f,182.6244f,198.9651f);
		
		inputArea.collider.enabled=true;
		
		bowTransform=bow;
		
		bow.eulerAngles=new Vector3(0,90,0);
		
		transform.parent=bow;
		
		transform.localEulerAngles=Vector3.zero;
		//bow.localEulerAngles=new Vector3(0,270,180);
		
		if(Application.platform==RuntimePlatform.IPhonePlayer)
		{
			upperArmSpeed/=10.0f;
			lowerArmSpeed/=10.0f;
			ArrowSpeed/=10.0f;
			spinSpeed/=10.0f;
		}
		
		
		transform.localPosition=new Vector3(0,-0.1490947f,0.571631f);
		 
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		
	
		
		if(GameStates.instance.gameStates==GameStates.States.Active && rigidbody.isKinematic && arrowState==ArrowState.ACTIVE)
		{
			
			if(InputHandler.instance.isTouchBegan())
				startTouchPosition=InputHandler.instance.touchPositions();
			
			if(rigidbody.isKinematic && InputHandler.instance.isTouchStationary())
			{
				 
				 Ray ray=Camera.main.ScreenPointToRay(InputHandler.instance.touchPositions());
				
				 RaycastHit hitForDirection;
				
				if(Physics.Raycast(ray.origin,ray.direction,out hitForDirection,10) && Mathf.Abs(InputHandler.instance.deltaXAndDeltaY().y)>Mathf.Abs(InputHandler.instance.deltaXAndDeltaY().x))
					bow.LookAt(new Vector3(hitForDirection.point.x,hitForDirection.point.y,transform.position.z));
				
				playerHead.Rotate(10*InputHandler.instance.deltaXAndDeltaY().y *Time.deltaTime,0,0);
				
				
			 if(Mathf.Abs(InputHandler.instance.deltaXAndDeltaY().x)>Mathf.Abs(InputHandler.instance.deltaXAndDeltaY().y) && ForceValueRect.width<ForceBgRect.width-4 && startTouchPosition.x<Input.mousePosition.x)
				{
				rightUpperArm.transform.Rotate(0,0,-upperArmSpeed*InputHandler.instance.deltaXAndDeltaY().x *Time.deltaTime,Space.World);
				
				rightLowerArm.transform.Rotate(0,0,lowerArmSpeed*InputHandler.instance.deltaXAndDeltaY().x *Time.deltaTime,Space.World);
					
					spine.Rotate(0,spinSpeed*InputHandler.instance.deltaXAndDeltaY().x*Time.deltaTime,0,Space.World);
					
					
					transform.Translate(0,0,-ArrowSpeed*InputHandler.instance.deltaXAndDeltaY().x*Time.deltaTime);
				}
				//else
					//rightUpperArm.transform.Rotate(0,0,60*InputHandler.instance.deltaXAndDeltaY().y *Time.deltaTime,Space.World);
				//bowTransform.eulerAngles=new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,transform.eulerAngles.z);
				//Debug.Log(transform.GetChild(1).name);
				
			}
			float distance=0;
			
			if(InputHandler.instance.isTouchMoving() && InputHandler.instance.isTouchStationary() && startTouchPosition.x<Input.mousePosition.x)
			{
				distance=Vector3.Distance(Input.mousePosition,startTouchPosition);
				
			    ForceValueRect.width=(distance/maxDistance)*ForceBgRect.width;	
				
				if(ForceValueRect.width>ForceBgRect.width-4)
					ForceValueRect.width=ForceBgRect.width-4;
				
			}
			
			if(InputHandler.instance.isTouchEnded())
			{
				 endTouchPosition=InputHandler.instance.touchPositions();
				
				 distance=Vector3.Distance(endTouchPosition,startTouchPosition);
	    
			     float arrowSpeedonRelease =(distance/maxDistance)*arrowSpeed;
				
			    if(arrowSpeedonRelease<2)
			       arrowSpeedonRelease=2;
			    
			    if(arrowSpeedonRelease>arrowSpeed)
			      arrowSpeedonRelease=arrowSpeed;
			      
			     rigidbody.isKinematic=false;
				
			     rigidbody.velocity=transform.forward*arrowSpeedonRelease;
				
				inputArea.collider.enabled=false;
				///if(transform.childCount>=2 && transform.GetChild(1).parent!=null)
				// transform.GetChild(1).parent=null;
	 
				
			     	
				
			}
			
			
			
		}
		
		if(!rigidbody.isKinematic && arrowState==ArrowState.ACTIVE)
		{
			  transform.forward=rigidbody.velocity.normalized;
			   RaycastHit hit;
			  if(Physics.Raycast(transform.position,transform.forward,out hit,transform.localScale.z/2))
			  {
			     StopArrow(hit.collider.gameObject);
			  
			  }
			
		}
		
		if(arrowState==ArrowState.IDLE && Time.time-IdleSetTime>=5)
			Destroy(gameObject);
				
			
			
		
	}//End of Update Function
	
	
	
	void OnCollisionEnter(Collision other)
	{
	    if(arrowState==ArrowState.ACTIVE)
		 StopArrow(other.collider.gameObject);
	}
	
	void StopArrow(GameObject hitedObject)
	{
		gameObject.collider.enabled=false;
		
		rigidbody.isKinematic=true;	
		
		transform.parent=null;
		
		arrowState=ArrowState.IDLE;
		
		IdleSetTime=Time.time;
		
		AnimationHandler.instance.Animate();
		
	}
	
	void OnGUI()
	{
			if(arrowState==ArrowState.ACTIVE)
			{
		      GUI.DrawTexture(ForceBgRect,ForceBgImage);
			
			  GUI.DrawTexture(ForceValueRect,ForceValueBgImage);
			}
		
		 
		
	}
	
}
*/