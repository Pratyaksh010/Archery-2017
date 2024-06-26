using UnityEngine;
using System.Collections;


public class SpriteData : MonoBehaviour 
{
	//[SerializeField]
	public AnimationDataParams[] _ArrAnimationdata = null;
	public LinkedSpriteManager _SpriteManager = null;
	public SpriteAtlasDataHandler _SpriteAtlasDataHandler = null;
	public string _SpriteFrameName = null;
	public Sprite _Sprite = null;
	public int _ZOrder = 0;
	
	//ANIMATION DELEGATE
	public delegate void animationComplete();
	public animationComplete animationCompleteCallBack = null;
	
	private Vector2 mvSpriteOriginalSize;
	private float mfInversePTMRatio = 0.03125f; // 1 divided by PTM RATIO (unity 1 unit == 32 pixcel)
	private Vector2 mfScale = new Vector2(1.0f,1.0f);
	private bool mbInitialized = false;
	private string mdefaultAnimation;
	private SpriteStartUpScript tStartupScript = null;
	
	// Use this for initialization
	void Start () 
	{
		tStartupScript = gameObject.AddComponent<SpriteStartUpScript>();
	}
		
	//INIT WITH DEFAULT VALUES
	public void Init()
	{
		//DON'T INITIALIZE MORE THAN ONCE
		if(mbInitialized == true)
		{
			Debug.Log("Initiailization more than once");
			return;
		}
		
		if(_SpriteManager == null || _SpriteAtlasDataHandler == null)
		{
			Debug.Log("Sprite manager or atlas not available");
			return;
		}
				
		if(tStartupScript != null)
		{
			Destroy(tStartupScript);
			tStartupScript = null;
		}
		
		mbInitialized = true;		
		LoadedSpriteDataParams loadedSpriteData = getSpriteDataParamWithName(_SpriteFrameName);	
		if(loadedSpriteData == null)
			return;
		
		_Sprite = _SpriteManager.AddSprite(gameObject,loadedSpriteData._iLeftPixel,loadedSpriteData._iBottomPixel,
				loadedSpriteData._iWidth,loadedSpriteData._iHeight,false);
		mvSpriteOriginalSize = new Vector2(_Sprite.width,_Sprite.height);
		
		//SETTING SPRITE SIZE TO MATCH TRANSFORM
		_Sprite.SetSizeXY(_Sprite.width*mfInversePTMRatio*mfScale.x,_Sprite.height*mfInversePTMRatio*mfScale.y);
		
		if(_ArrAnimationdata != null)
		{
			for(int i = 0; i < _ArrAnimationdata.Length; i++)
			{
				UVAnimation anim = new UVAnimation();
				AnimationDataParams animParams = _ArrAnimationdata[i];
				for(int j = 0; j < animParams._frameNames.Length; j++)
				{
					addAnimationFrametoAnimation(animParams._frameNames[j],anim);
				}
			
				anim.name = animParams._name;
				anim.loopCycles = animParams._loopCycles;
				anim.framerate = animParams._fps;
		        _Sprite.AddAnimation(anim);
				_Sprite.SetAnimCompleteDelegate(onAnimationCompleted);
			}
		}
			
		_Sprite.SetDrawLayer(_ZOrder);
		
		if(mdefaultAnimation != null)
		{
			runAnimationWithAnimationName(mdefaultAnimation);
			mdefaultAnimation = null;
		}
	}	
		
	//SET SPRITE SCALE
	public void setScale(Vector2 pScale)
	{
		mfScale = pScale;
		
		if(_Sprite != null)
		{
			_Sprite.SetSizeXY(mvSpriteOriginalSize.x*mfInversePTMRatio*mfScale.x,mvSpriteOriginalSize.y*mfInversePTMRatio*mfScale.y);
			if(mfScale.x*mfScale.y < 0)
			{
				//USE REVERSE WINDING
			}
		}
	}
	
	public void setColor(Color pSpriteColor)
	{
		_Sprite.SetColor(pSpriteColor);
	}
	
	//CREATE ANIMATIONS
	void createAnimationWithFrameNames(string[] pFrameNames,string animationName, int loops, int fps)
	{
		UVAnimation anim = new UVAnimation();
		for(int i = 0; i < pFrameNames.Length; i++)
		{
			addAnimationFrametoAnimation(pFrameNames[i],anim);
		}
	
		anim.name = animationName;
		anim.loopCycles = loops;
		anim.framerate = fps;
        _Sprite.AddAnimation(anim);			
	}
	
	//ANIMATION HELPER METHODS
	void addAnimationFrametoAnimation(string p_frameName,UVAnimation p_animation)
	{
		if(p_frameName == null)
			Debug.Log("No name present for frame please add in animation frame array");
		
		LoadedSpriteDataParams param1 = getSpriteDataParamWithName(p_frameName);
		if(param1 != null)
		{
			Vector2 startPosUV = _SpriteManager.PixelCoordToUVCoord(param1._iLeftPixel, param1._iBottomPixel);
        	Vector2 spriteSize = _SpriteManager.PixelSpaceToUVSpace(param1._iWidth, param1._iHeight);
			p_animation.appendFrame(startPosUV,spriteSize);
		}
	}
	
	//LOADING SPRITE PARAMS
	private LoadedSpriteDataParams getSpriteDataParamWithName(string p_filename)
	{
		//GET LOADED SPRITE PARAMS FOR FRAME NAME
		LoadedSpriteDataParams loadedSpriteData = null;
		loadedSpriteData = _SpriteAtlasDataHandler.getLoadedSpriteData(p_filename);	

		if(loadedSpriteData == null)
			Debug.Log("Sprite frame named "+p_filename+" unavailable");
		
		return loadedSpriteData;
	}
	
	//RUNNING AN ANIMATION
	public void runAnimationWithAnimationName(string p_name)
	{
		//PLAY ANIMATION ON SPRITE
		if(_Sprite != null && mbInitialized)
			_Sprite.PlayAnim(p_name);
		else if(mbInitialized == false)
			mdefaultAnimation = p_name;
	}
	
	//REMOVE THE SPRITE ONLY
	public void removeSprite()
	{
		if(_Sprite != null)
		{
			_SpriteManager.RemoveSprite(_Sprite);
			_Sprite = null;
		}
	}
	
	//TOGGLE SPRITE VISIBILILTY
	public void setVisible(bool p_boolVal)
	{
		if(_Sprite != null)
			_Sprite.hidden = !p_boolVal;
	}
	
	public void onAnimationCompleted()
	{
		if(animationCompleteCallBack != null)
			animationCompleteCallBack();
	}
}
