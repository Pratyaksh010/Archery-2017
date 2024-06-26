using UnityEngine;
using System.Collections;

public class quality_manager : MonoBehaviour {
	public float _ipad1deltatimechange;
	
	public float _ipad1maxdeltatimechange;
	public float _otheripaddeltatimechange;
	
	public float _otheripadmaxdeltatimechange;
	// Use this for initialization
	void Awake () 
	{
	
		 //if(Application.platform==RuntimePlatform.IPhonePlayer&&(iPhone.generation==iPhoneGeneration.iPad1Gen) || (iPhone.generation==iPhoneGeneration.iPodTouch1Gen) || (iPhone.generation==iPhoneGeneration.iPodTouch2Gen) || (iPhone.generation==iPhoneGeneration.iPodTouch3Gen) || (iPhone.generation==iPhoneGeneration.iPodTouch4Gen))
		if(Application.platform == RuntimePlatform.Android)
		{
         
		//  QualitySettings.
			if(Application.platform == RuntimePlatform.Android)
			{
				Time.fixedDeltaTime=_ipad1deltatimechange;
			   
				Time.maximumDeltaTime=_ipad1maxdeltatimechange;
				 QualitySettings.masterTextureLimit=0;
				 QualitySettings.antiAliasing=0;
			}
			else{
				
				Time.fixedDeltaTime=_otheripaddeltatimechange;// .01f
			    
				Time.maximumDeltaTime=_otheripadmaxdeltatimechange;//.01f
				 QualitySettings.antiAliasing=0;
		  
		        QualitySettings.masterTextureLimit=1;
			}
		}
	
	}

}
