using UnityEngine;
using System.Collections;

public class rotateground : MonoBehaviour {
	
	public float a;
    public float b;
    public float x;
    public float y;
    public float alpha ;
    public float X;
    public float Y;
   public Transform cu;
	public int i=1;
	float check;
 void Start()
	{
		store_currentStatus.instances._rewards();
		
	}
void Update () {
   
   //if(alpha<=180)
		//{
    X = a+ (a* Mathf.Cos((alpha*.005f)));//*.005f)));
    Y= b+(b* Mathf.Sin((alpha*.005f)));//.005f)));
    this.gameObject.transform.position = new Vector3(X,3.23859f,Y);
		//check=((180f-0f)/(3-(-6.5f)))*(transform.position.x);
		 alpha +=Time.deltaTime*50f;
		
		//}
	//transform.LookAt(cu);
}
	// Use this for initialization
	
}
