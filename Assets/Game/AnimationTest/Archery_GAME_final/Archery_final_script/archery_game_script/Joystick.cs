// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class Joystick : MonoBehaviour {
	//////////////////////////////////////////////////////////////
	// Joystick.js
	// Penelope iPhone Tutorial
	//
	// Joystick creates a movable joystick (via GUITexture) that 
	// handles touch input, taps, and phases. Dead zones can control
	// where the joystick input gets picked up and can be normalized.
	//
	// Optionally, you can enable the touchPad property from the editor
	// to treat this Joystick as a TouchPad. A TouchPad allows the finger
	// to touch down at any point and it tracks the movement relatively 
	// without moving the graphic
	//////////////////////////////////////////////////////////////
	
	
	
	//@script RequireComponent( GUITexture )
	
	// A simple class for bounding how far the GUITexture will move
	public class Boundary 
	{
		public Vector2 min = Vector2.zero;
		public Vector2 max = Vector2.zero;
	}
	
	private static  Joystick[] joysticks;					// A static collection of all joysticks
	private static  bool  enumeratedJoysticks = false;
	private static  float tapTimeDelta = 0.3f;				// Time allowed between taps
	public bool  touchPad; 									// Is this a TouchPad?
	public Rect touchZone;
	public Vector2 deadZone = Vector2.zero;						// Control when position is output
	public bool  normalize = false; 							// Normalize output after the dead-zone?
	public Vector2 position; 									// [-1, 1] in x,y
	public int tapCount;											// Current tap count
	private int lastFingerId= -1;								// Finger last used for this joystick
	private float tapTimeWindow;							// How much time there is left for a tap to occur
	private Vector2 fingerDownPos;
	///////private float fingerDownTime;
	//private float firstDeltaTime = 0.5f;
	private GUITexture gui;								// Joystick graphic
	private Rect defaultRect;								// Default position / extents of the joystick graphic
	private Boundary guiBoundary = new Boundary();			// Boundary for joystick graphic
	private Vector2 guiTouchOffset;						// Offset to apply to touch input
	private Vector2 guiCenter;	
	public SpeedThumb setThumb;	
	public GameObject tab;
	public GUITexture tabGUI;
	public Rect rect;
	
	public bool pauseone;
	
	public float _starttime;
	
	private bool _runjoystick;
	//public FPSControls arrowSpeedController;			// Center of joystick
	
	/////HandAnimation handanimation;
	public AudioSource pullsound;
	private bool onetimecallpull;
	
	void  Start (){
		
		tab=GameObject.Find("SPEEDTHUMB")as GameObject;
		setThumb=GameObject.Find("SPEEDTHUMB").GetComponent("SpeedThumb")as SpeedThumb;
		tabGUI = GameObject.Find("SPEEDTHUMB").GetComponent<GUITexture>();
		rect=tabGUI.pixelInset;
		gui = GetComponent<GUITexture>();
		defaultRect = gui.pixelInset;
		if(Application.platform!=RuntimePlatform.Android)//&&(iPhone.generation==iPhoneGeneration.iPad3Gen))
		{
			gui .pixelInset = new Rect(-90f,75f,200f,200f);
			
			defaultRect.x += transform.position.x * Screen.width;// + gui.pixelInset.x; // -  Screen.width * 0.5f;
			defaultRect.y += transform.position.y * Screen.height;// - Screen.height * 0.5f;
			transform.position = new Vector3(0.0f,0.0f,transform.position.z);
			if ( touchPad )
			{
				// If a texture has been assigned, then use the rect ferom the gui as our touchZone
				if ( gui.texture )
				{
					touchZone = defaultRect;
				}
			}
			else
			{				
				// This is an offset for touch input to match with the top left
				// corner of the GUI
				guiTouchOffset.x = defaultRect.width * 0.0f;
				guiTouchOffset.y = defaultRect.height * 0.5f;
				
				// Cache the center of the GUI, since it doesn't change
				guiCenter.x = defaultRect.x + guiTouchOffset.x;
				guiCenter.y = defaultRect.y + guiTouchOffset.y;
				
				// Let's build the GUI boundary, so we can clamp joystick movement
				guiBoundary.min.x = defaultRect.x - guiTouchOffset.x;
				guiBoundary.max.x = defaultRect.x + guiTouchOffset.x;
				guiBoundary.min.y = defaultRect.y - 800;//guiTouchOffset.y;
				guiBoundary.max.y = defaultRect.y;//+ guiTouchOffset.y;
			}
		}
		
		else{
			defaultRect.x += transform.position.x * Screen.width;// + gui.pixelInset.x; // -  Screen.width * 0.5f;
			defaultRect.y += transform.position.y * Screen.height;// - Screen.height * 0.5f;
			transform.position = new Vector3(0.0f,0.0f,transform.position.z);
			if ( touchPad )
			{
				// If a texture has been assigned, then use the rect ferom the gui as our touchZone
				if ( gui.texture )
				{
					touchZone = defaultRect;
				}
			}
			else
			{				
				// This is an offset for touch input to match with the top left
				// corner of the GUI
				guiTouchOffset.x = defaultRect.width * 0.0f;
				guiTouchOffset.y = defaultRect.height * 0.5f;
				
				// Cache the center of the GUI, since it doesn't change
				guiCenter.x = defaultRect.x + guiTouchOffset.x;
				guiCenter.y = defaultRect.y + guiTouchOffset.y;
				
				// Let's build the GUI boundary, so we can clamp joystick movement
				guiBoundary.min.x = defaultRect.x - guiTouchOffset.x;
				guiBoundary.max.x = defaultRect.x + guiTouchOffset.x;
				guiBoundary.min.y = defaultRect.y - 400;//guiTouchOffset.y;
				guiBoundary.max.y = defaultRect.y;//+ guiTouchOffset.y;
			}
		}
		//	print ("guiPixelInset"+gui.pixelInset);
		ResetJoystick ();
		Debug.Log("JoystickPosition--"+transform.position);
		Debug.Log("JoystickPixelInset--"+this.GetComponent<GUITexture>().pixelInset);
	}
	
	void  Disable ()
	{
		gameObject.gameObject.SetActive(false);
		enumeratedJoysticks = false;
	}
	
	void  ResetJoystick ()
	{
		// Release the finger control and set the joystick back to the default position
		gui.pixelInset = defaultRect;
		lastFingerId = -1;
		position = Vector2.zero;
		fingerDownPos = Vector2.zero;
		if ( touchPad )
			gui.color = new Color(gui.color.r,gui.color.g,gui.color.b,0.025f);	
		tabGUI.pixelInset=rect;// reset intial postion SpeedThumb guiTexture
	}
	
	bool IsFingerDown ()
	{
		return (lastFingerId != -1);
	}
	
	void  LatchedFinger (int fingerId)
	{
		// If another joystick has latched this finger, then we must release it
		if ( lastFingerId == fingerId )
			ResetJoystick();
	}
	
	float yoffset;
	private float difference;
	
	void  Update ()
	{	
		
		if(_runjoystick==false) 
		{
			
			if(notDestroy.instances.checkchallengemode==true)
			{
				_runjoystick=challenge_Controll.instances. _joystickfirsttimecreate;//_restartjoystick;
			}
			if(notDestroy.instances.checkchallengemode==false)
			{
				_runjoystick=controll.instance. _joystickfirsttimecreate;//_startjoystick;
			}
		}
		
		if(_runjoystick==true&&pauseone==false&&store_currentStatus.instances.offcontrolling==false&&store_currentStatus.instances.joystickactive==true)
		{
			
			if ( !enumeratedJoysticks )
			{
				// Collect all joysticks in the game, so we can relay finger latching messages
				joysticks = (Joystick[])FindObjectsOfType(typeof( Joystick ));
				enumeratedJoysticks = true;
			}	
			int count= Input.touchCount;
			// Adjust the tap time window while it still available
			if ( tapTimeWindow > 0 )
			{
				tapTimeWindow -= Time.deltaTime;
			}
			else
			{
				tapCount = 0;
			}
			
			if ( count == 0 )
			{
				ResetJoystick();
			}
			else
			{
				for(int i = 0;i < count; i++)
				{    
					
					Touch touch = Input.GetTouch(i);			
					Vector2 guiTouchPos = touch.position - guiTouchOffset;
					bool shouldLatchFinger= false;
					
					if ( touchPad )
					{				
						if ( touchZone.Contains( touch.position ))
							shouldLatchFinger = true;
					}
					else 
						if (gui.HitTest( touch.position ) )//
					{
						shouldLatchFinger = true;
						if(touch.phase==TouchPhase.Began)
						{      
							print ("tabGUI====="+tabGUI.pixelInset.y);
							setThumb.ypos =tab.transform.position.y*Screen.height-Mathf.Abs(tabGUI.pixelInset.y);
							// setThumb.difference=(touch.position.y-setThumb.ypos);
							print("Difference is one=:"+setThumb.ypos);
							_starttime=Time.time;
							onetimecallpull=true;
							// pullsound.audio.Play();
						}
						
					}		
					
					// Latch the finger if this is a new touch
					if ( shouldLatchFinger && ( lastFingerId == -1 || lastFingerId != touch.fingerId ) )
					{
						
						if ( touchPad )
						{
							gui.color = new Color(gui.color.r,gui.color.g,gui.color.b,0.15f);
							lastFingerId = touch.fingerId;
							fingerDownPos = touch.position;
							////// fingerDownTime = Time.time;
						}
						lastFingerId = touch.fingerId;
						
						// Accumulate taps if it is within the time window
						if ( tapTimeWindow > 0 )
							tapCount++;
						else
						{
							tapCount = 1;
							tapTimeWindow = tapTimeDelta;
						}
						// Tell other joysticks we've latched this finger
						foreach( Joystick j in joysticks )
						{
							if ( j != this )
								j.LatchedFinger( touch.fingerId );
						}						
					}			
					
					if (lastFingerId == touch.fingerId )
					{	
						// Override the tap count with what the iPhone SDK reports if it is greater
						// This is a workaround, since the iPhone SDK does not currently track taps
						// for multiple touches
						if ( touch.tapCount > tapCount )
							tapCount = touch.tapCount;
						
						if ( touchPad )
						{	
							// For a touchpad, let's just set the position directly based on distance from initial touchdown
							position.x = Mathf.Clamp( ( touch.position.x - fingerDownPos.x ) / ( touchZone.width / 2 ), -1, 1 );
							position.y = Mathf.Clamp( ( touch.position.y - fingerDownPos.y ) / ( touchZone.height / 2 ), -1, 1 );
						}
						else
						{					
							// Change the location of the joystick graphic to match where the touch is
							gui.pixelInset =  new Rect(Mathf.Clamp( guiTouchPos.x, guiBoundary.min.x, guiBoundary.max.x ),Mathf.Clamp( guiTouchPos.y, guiBoundary.min.y, guiBoundary.max.y),gui.pixelInset.width,gui.pixelInset.height);
							//gui.pixelInset.y =  Mathf.Clamp( guiTouchPos.y, guiBoundary.min.y, guiBoundary.max.y );
							float ypos=(float)touch.position.y;
							SpeedThumb.instance.sift(ypos);
							if(touch.phase==TouchPhase.Moved)
							{
								print ("touch.fingerId  "+touch.fingerId);
								
								if( setThumb.timestop==false)
								{
									FPSControls.instance.MoveHand(touch.fingerId);
								}
								
								//if(onetimecallpull==true&&Time.time-_starttime<=.1f)
								//{
								
								///  pullsound.audio.volume=1;
								//onetimecallpull=false;
								//}
								//if(SpeedThumb.instance.guione.pixelInset.y<=(SpeedThumb.instance.defaultY-150))
								//{
								//if(Time.time-_starttime<=.1f&&SpeedThumb.instance.guione.pixelInset.y<=SpeedThumb.instance.defaultY-)
								//{
								// audioManager.instances._currentaudio.audio.clip=audioManager.instances._audioclip[27];
								// audioManager.instances.playcurrentaudio();
								// pullsound.audio.Play();
								// pullsound.audio.volume=1;
								// _starttime=Time.time;
								//}
								//}
							}
							
							
						}
						if(touch.phase==TouchPhase.Stationary&&SpeedThumb.instance.guione.pixelInset.y>=SpeedThumb.instance.defaultY-200)
						{
							//pullsound.audio.Pause();
							// pullsound.audio.volume=0;
							//   
							//if(touch.deltaPosition)
						} // if(touch.p)
						if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled )
						{
							print ("release");
							
							if(SpeedThumb.instance.guione.pixelInset.y<=(SpeedThumb.instance.defaultY-200))//150))
							{
								if(store_currentStatus.instances.offcontrolling==false)
								{
									FPSControls.instance.Unparrent();
									pullsound.GetComponent<AudioSource>().volume=0;
									store_currentStatus.instances.realsearrow();
									
									SpeedThumb.instance. secondaryboard.transform.GetComponent<Renderer>().material.color=new Color( SpeedThumb.instance.secondaryboard.transform.GetComponent<Renderer>().material.color.r, SpeedThumb.instance.secondaryboard.transform.GetComponent<Renderer>().material.color.g, SpeedThumb.instance.secondaryboard.transform.GetComponent<Renderer>().material.color.b,0f);
									
									SpeedThumb.instance.point.transform.GetComponent<Renderer>().material.color=new Color( SpeedThumb.instance.point.transform.GetComponent<Renderer>().material.color.r, SpeedThumb.instance.point.transform.GetComponent<Renderer>().material.color.g, SpeedThumb.instance.point.transform.GetComponent<Renderer>().material.color.b,0f);
									//_runjoystick=false;
								} 
							}
							else
							{
								FPSControls.instance.resetArrow=true;
							}
							
							ResetJoystick();
						}					
					}			
				}
			}
			
			if ( !touchPad )
			{
				// Get a value between -1 and 1 based on the joystick graphic location
				position.x = ( gui.pixelInset.x + guiTouchOffset.x - guiCenter.x ) / guiTouchOffset.x;
				position.y = ( gui.pixelInset.y + guiTouchOffset.y - guiCenter.y ) / guiTouchOffset.y;
			}
			
			// Adjust for dead zone	
			float absoluteX= Mathf.Abs( position.x );
			float absoluteY= Mathf.Abs( position.y );
			
			if ( absoluteX < deadZone.x )
			{
				// Report the joystick as being at the center if it is within the dead zone
				position.x = 0;
			}
			else if ( normalize )
			{
				// Rescale the output after taking the dead zone into account
				position.x = Mathf.Sign( position.x ) * ( absoluteX - deadZone.x ) / ( 1 - deadZone.x );
			}
			
			if ( absoluteY < deadZone.y )
			{
				// Report the joystick as being at the center if it is within the dead zone
				position.y = 0;
			}
			else if ( normalize )
			{
				// Rescale the output after taking the dead zone into account
				position.y = Mathf.Sign( position.y ) * ( absoluteY - deadZone.y ) / ( 1 - deadZone.y );
			}
			
			
		}
		/*public bool CheckInsideRect(Rect rectToCheck) 
 {
		
   rectToCheck.y=Screen.height-rectToCheck.y-rectToCheck.height;   
   return rectToCheck.Contains(Input.mousePosition);
 }*/
	}
	
}