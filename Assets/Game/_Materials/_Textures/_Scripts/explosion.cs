using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	    transform.GetComponent<Rigidbody>().AddExplosionForce( 30f, transform.localPosition, 3f, 3.0f);
		transform.GetComponent<Rigidbody>().AddExplosionForce(15f, new Vector3(0f,transform.localPosition.y,0f), 10f, 3.0f);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
