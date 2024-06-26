///// var updateInterval = 0.5;
//private var lastInterval : double; // Last interval end time
//private var frames = 0; // Frames over current interval
//private var fps0 : float; // Current F



function Start()
{
   
  //if( Application.platform==RuntimePlatform.IPhonePlayer&&((iPhone.generation==iPhoneGeneration.iPodTouch1Gen) || (iPhone.generation==iPhoneGeneration.iPodTouch2Gen) || (iPhone.generation==iPhoneGeneration.iPodTouch3Gen) || (iPhone.generation==iPhoneGeneration.iPodTouch4Gen)))
  // {
  // Application.targetFrameRate=30.0f;
  // }
   //else
   //{
       if(Application.platform==RuntimePlatform.IPhonePlayer)
       {
           Application.targetFrameRate=60.0f;
       }
  /// }
   
}
function Update () 
{ 
// ++frames;
 /////var timeNow = Time.realtimeSinceStartup;
 /////////////if( timeNow > lastInterval + updateInterval )
	 ///////////{
		////////fps0 = frames / (timeNow - lastInterval);
		////////frames = 0;
		/////////lastInterval = timeNow;
	 /////////}
}

function OnGUI()
 {
		// if( Application.platform==RuntimePlatform.IPhonePlayer)
		  /// GUI.Label( Rect( Screen.width/2-125, 0, 250, 125 ), "fps : " + fps0.ToString());
		 
		  //if(GUI.Button(Rect(Screen.width-100,0,100,100),"Restart"))
		  // Application.LoadLevel(0); 
		
		  
}