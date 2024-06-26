using UnityEngine;
using System.Collections;

public class loadingDelay : MonoBehaviour {
	
	
	public GameObject _GuiManager;
	
	private ScreenManager _screenmanagerSc;
	
	private float _mdelayTime;
	
	public float _delayTimeLimit;
	
	public string _loadingScreen;
	
	bool onetimeCall ;
	
	bool ometime2call;
	
	public bool ongamePlay;
	
	public GameObject _gameObject ;
	
	public Vector3 genPoint ;
	
	GameObject clone ;
	// Use this for initialization
	void Start ()
	{
		if(_gameObject!=null)
		{
	    clone	= Instantiate(_gameObject,genPoint,Quaternion.identity)as GameObject;
		}
	 //MainControll.instancse._barclone = Instantiate(_gameObject,genPoint,Quaternion.identity)as GameObject;
		 _GuiManager = GameObject.Find("GuiManager");
	   
		_screenmanagerSc = _GuiManager.GetComponent<ScreenManager>();
		
		 _mdelayTime = Time.time ;
		
		
	/////	DallyBonus.instances.checkDallyBouns();
	}
	
	// Update is called once per frame
	void Update () 
	{
	   
		
		 if(Time.time - _mdelayTime> _delayTimeLimit && onetimeCall == false)
		{
				
			 
			 _screenmanagerSc.LoadScreen(_loadingScreen);
			 if(clone!=null)
			{
              Destroy(clone,.15f);
			} 
			 onetimeCall = true ;
			
		}
		
	}
}
