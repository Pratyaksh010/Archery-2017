using UnityEngine;
using System.Collections;

public class disablepause : MonoBehaviour {

	// Use this for initialization
	
	public GameObject[] guiobject;
	
	public bool guitexturedisble;
	
	public static disablepause instances;
	void Start () 
	{
	
		instances=this;
		
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		if(guitexturedisble==false)
			
		{
			guiobject[0].gameObject.SetActive(true);
		}
		if(guitexturedisble==true)
		{
			guiobject[0].gameObject.SetActive(false);
		}
		
	}
}
