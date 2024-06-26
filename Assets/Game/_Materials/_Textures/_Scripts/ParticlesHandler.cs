using UnityEngine;
using System.Collections;

public class ParticlesHandler : MonoBehaviour {
	
	
	public GameObject bloodSplash;
	
	private GameObject loadedParticles;
	
	public static ParticlesHandler instance;
	// Use this for initialization
	void Start () {
	
	}
	
	void Awake()
	{
	  instance=this;	
	}
	
	public void LoadParticled(Vector3 position,string name,GameObject hitObject)
	{
		if(loadedParticles==null)
		loadedParticles=(GameObject)GameObject.Instantiate(bloodSplash,position,Quaternion.identity);
		
		if(hitObject!=null)
			loadedParticles.transform.parent=hitObject.transform;
		
		
	}
}
