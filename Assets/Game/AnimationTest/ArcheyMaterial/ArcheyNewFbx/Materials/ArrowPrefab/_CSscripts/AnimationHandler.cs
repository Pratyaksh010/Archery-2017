using UnityEngine;
using System.Collections;

public class AnimationHandler : MonoBehaviour {
	
	
	
	
	// Use this for initialization
	public static AnimationHandler instance;
	void Start () {
	
	}
	
	
	void Awake()
	{
		
	   instance=this;	
	}
	// Update is called once per frame
	/*void Update () {
	
	}*/
	
	public void Animate()
	{
		   GameStatistics.instance.loadObject();
		
	}
	
	
}
