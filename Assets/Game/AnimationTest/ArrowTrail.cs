using UnityEngine;
using System.Collections;

public class ArrowTrail : MonoBehaviour {
	
	
	public enum etrail
	{
		NormalTrail,
		BLAZING,
		FREEZE,
		IRON
		
		
	}
	
	public Texture[] _trailTexture ;
	
	public TrailRenderer _arrowTrail ;
	
	public static ArrowTrail  instances ;
	// Use this for initialization
	void Start () 
	{
	  instances = this ;
	 _arrowTrail.GetComponent<Renderer>().material.mainTexture  = _trailTexture[0];
	  notDestroy.instances._activeArrowPopUp = true ;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	public void changeTrail(int i)
	{
		if( notDestroy.instances._activeArrowPopUp==true)
		{
		   _arrowTrail.GetComponent<Renderer>().material.mainTexture = _trailTexture[i];
		}
	}
	
}
