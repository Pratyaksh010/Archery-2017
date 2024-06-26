using UnityEngine;
using System.Collections;

public class DestroyArrowparrent : MonoBehaviour {
	//public bool destroy;
	public static DestroyArrowparrent instance;
	public GameObject ArrowPa;
	public Vector3 pos;
	public Transform ParrentArrow;// store LeftArmParent Object
	///public FPSControls fps;// FPS control Script store
	//public DestroyObject des;
	public Transform[] objectactive;
	public Transform cam;
	public Vector3 Postion;
	public Quaternion rot;
	public Transform human;
	public Transform bow;
	public Vector3 bowpostion;
	public Vector3 humanpostion;
	public Quaternion humanrot;
	public Quaternion bowrotatio;
	public Transform Right_Hand;
	public Transform string_ctrl;
	public Vector3 Right_handpos;
	//public Quaternion Right_handrot;
	public Vector3 string_ctrlpos;
	public Quaternion string_ctrlsrot;
	public Vector3 cameulerangles;
	public Transform arrowcreationpoint;
	public Transform crosshear;
	public Quaternion crosshearrot;
	public BoardScore boardscore;
	public Vector3 _targetctrl;
	public Transform targetc;
	public Quaternion target_ctrlsrot;

	//public SmoothLookAtCS smoothLook;
	public Vector3 handpos;
	public Vector3 angle;
	public bool joystickstart;
	// Use this for initialization
	void Start () 
	{ 
		instance=this;
	    Postion=cam.position;
		rot=cam.rotation;
		boardscore=gameObject.GetComponent("BoardScore")as BoardScore;
		///smoothLook=cam.transform.gameObject.GetComponent("SmoothLookAtCS")as SmoothLookAtCS;
		crosshearrot=crosshear.transform.localRotation;
		cameulerangles=cam.transform.eulerAngles;
		bowpostion=bow.position;
		humanpostion=human.position;
	    humanrot=human.transform.localRotation;// store intial human rotation
		bowrotatio=bow.transform.localRotation;// store intial bow rotation
	    Right_handpos=Right_Hand.position;
		//Right_handrot=Right_Hand.rotation;
		string_ctrlpos=string_ctrl.position;
		string_ctrlsrot=string_ctrl.rotation;
		_targetctrl=targetc.localPosition;
		target_ctrlsrot=targetc.localRotation;
	}
	
	// Update is called once per frame
	
	public void recreate()
	{   
		
		crosshear.transform.localRotation=crosshearrot;
		crosshear.localEulerAngles=new Vector3(0,0,0);
		CamRotations.instance.senstivityX=0;
		CamRotations.instance.senstivityY=0;
		cam.position=Postion;
		cam.rotation=rot;
		cam.transform.eulerAngles=cameulerangles;
		
		if(!cam.GetComponent<Rigidbody>().isKinematic)
	    {
		 cam.GetComponent<Rigidbody>().velocity=Vector3.zero;
		 cam.GetComponent<Rigidbody>().isKinematic=true;
		}
		GameObject clone;
		for(int i=0;i<5;i++)
		{
			objectactive[i].gameObject.SetActive(true);
		}
		
		//Right_Hand.position=righth.position;
		//Right_Hand.rotation=righth.rotation;
		//targetc.position=targetpos.localPosition;
		//targetc.rotation=targetpos.rotation;
		//string_ctrl.position=stringput.position;
		//string_ctrl.rotation=stringput.rotation;
		targetc.localPosition=_targetctrl;
		targetc.localRotation=target_ctrlsrot;
		string_ctrl.position=string_ctrlpos;
		string_ctrl.rotation=string_ctrlsrot;
		Right_Hand.position=handpos;//Right_handpos;
		Right_Hand.eulerAngles=angle;//Right_handrot;
		clone=Instantiate(ArrowPa, arrowcreationpoint.position, ArrowPa.transform.rotation)as GameObject ;// instiate ArrowPrefab
		clone.transform.parent=ParrentArrow;
		//Right_Hand.position=Right_handpos;
		///Right_Hand.rotation=Right_handrot;
		joystickstart=true;
		string_ctrl.transform.parent=clone.transform;
		bow.position=bowpostion;
		bow.transform.parent=ParrentArrow;
		human.position=humanpostion;
		human.transform.parent=cam;
		human.transform.localRotation= humanrot;// reset human current rotation in intial rotation
		bow.transform.localRotation=bowrotatio;// reset bow current rotation in intial rotation
	  	boardscore.fadestart=false;
		boardscore.fadein=false;
		boardscore.alpha=0f;
		
	}
	

}
