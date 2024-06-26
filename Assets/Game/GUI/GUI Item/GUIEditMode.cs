using UnityEngine;
using System.Collections;


public enum eFadeConditions
{
		NoFade = 0,
		FadeInOnly,
		FadeOutOnly,
		FadeInAndOut,
}

[ExecuteInEditMode]
public class GUIEditMode : MonoBehaviour
{

		// Use this for initialization
		public bool _CorrectWidth = false;
		public bool _CorrectHeight = false;
		public bool _SaveStartCondition = false;
		public bool _SaveEndCondition = false;
		public bool _ShowStartConditions = false;
		public bool _ShowEndConditions = false;
		public eFadeConditions _fadeCondition = eFadeConditions.NoFade;
		public bool _CorrectAnimation = false;

		private eFadeConditions _CurFadeCondition = eFadeConditions.NoFade;
		private bool _fadeInOnEntry = false;
		private bool _fadeOutOnExit = false;
	
		void Start ()
		{
				//SETUP FADE OPTION
				MenuItemAnim anim = GetComponent<MenuItemAnim> ();
				if (anim != null) {
						_fadeInOnEntry = anim._FadeIn;
						_fadeOutOnExit = anim._FadeIn;
				}

				MenuItemEntryAnim animEntry = GetComponent<MenuItemEntryAnim> ();
				if (animEntry != null)
						_fadeInOnEntry = animEntry._FadeIn;
				
				MenuItemExitAnim animExit = GetComponent<MenuItemExitAnim> ();
				if (animExit != null)
						_fadeOutOnExit = animExit._FadeOut;
		
				if (_fadeInOnEntry && _fadeOutOnExit)
						_fadeCondition = eFadeConditions.FadeInAndOut;
				else if (_fadeInOnEntry)
						_fadeCondition = eFadeConditions.FadeInOnly;
				else if (_fadeOutOnExit)
						_fadeCondition = eFadeConditions.FadeOutOnly;
				else
						_fadeCondition = eFadeConditions.NoFade;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (_CorrectHeight == true) {
						correctAspectRatioX ();
						_CorrectHeight = false;	
				} else if (_CorrectWidth == true) {
						correctAspectRatioY ();
						_CorrectWidth = false;	
				} else if (_SaveStartCondition == true) {
						saveStartCondition ();
						_SaveStartCondition = false;
				} else if (_SaveEndCondition == true) {
						saveEndCondition ();
						_SaveEndCondition = false;
				} else if (_ShowStartConditions == true) {
						restoreStartCondition ();
						_ShowStartConditions = false;
				} else if (_ShowEndConditions == true) {
						restoreEndCondition ();
						_ShowEndConditions = false;
				} else if (_CorrectAnimation == true) {
						correctAnimation ();
						_CorrectAnimation = false;
				}
		
				if (_fadeCondition != _CurFadeCondition) {
						_CurFadeCondition = _fadeCondition;
						switch (_CurFadeCondition) {
						case eFadeConditions.NoFade:
								_fadeInOnEntry = false;
								_fadeOutOnExit = false;
								break;
						case eFadeConditions.FadeInOnly:
								_fadeInOnEntry = true;
								_fadeOutOnExit = false;
								break;
						case eFadeConditions.FadeOutOnly:
								_fadeInOnEntry = false;
								_fadeOutOnExit = true;
								break;
						case eFadeConditions.FadeInAndOut:
								_fadeInOnEntry = true;
								_fadeOutOnExit = true;
								break;
						default:
								break;
						}
						FadeOnEntry (_fadeInOnEntry);
						FadeOnExit (_fadeOutOnExit);
				}
		}
	
		void FadeOnEntry (bool bShouldFade)
		{
				MenuItemAnim anim = GetComponent<MenuItemAnim> ();
				if (anim != null) {
						anim._FadeIn = bShouldFade;
						anim._VisibleOnStart = !bShouldFade;
				}
			
				MenuItemEntryAnim animEntry = GetComponent<MenuItemEntryAnim> ();
				if (animEntry != null) {
						animEntry._FadeIn = bShouldFade;
						animEntry._VisibleOnStart = !bShouldFade;
				}
		}
	
		void FadeOnExit (bool bShouldFade)
		{
				MenuItemAnim anim = GetComponent<MenuItemAnim> ();
				if (anim != null)
						anim._FadeIn = bShouldFade;
		
				MenuItemExitAnim animExit = GetComponent<MenuItemExitAnim> ();
				if (animExit != null) {
						animExit._VisibleOnStart = true;
						animExit._FadeOut = bShouldFade;
				}
		}
	
	
		void correctAspectRatioX ()
		{
				GUITexture tGUITexture = GetComponent<GUITexture> ();
				Texture tTexture = tGUITexture.texture;
				if (tTexture != null) {
						float correctAspectRatio = (float)tTexture.width / (float)tTexture.height;
						Debug.Log ("AspectRatio = " + correctAspectRatio);
						gameObject.transform.localScale = new Vector3 (gameObject.transform.localScale.x, gameObject.transform.localScale.x / correctAspectRatio, gameObject.transform.localScale.z);
				}
		}
	
		void correctAspectRatioY ()
		{
				GUITexture tGUITexture = GetComponent<GUITexture> ();
				Texture tTexture = tGUITexture.texture;
				if (tTexture != null) {
						float correctAspectRatio = (float)tTexture.width / (float)tTexture.height;
						Debug.Log ("AspectRatio = " + correctAspectRatio);
						gameObject.transform.localScale = new Vector3 (gameObject.transform.localScale.y * correctAspectRatio, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
				}
		}
	
		void saveStartCondition ()
		{
				MenuItemAnim anim = GetComponent<MenuItemAnim> ();
				if (anim != null) {
						anim._StartPos = gameObject.transform.position;
						anim._StartScale = new Vector2 (gameObject.transform.localScale.x, gameObject.transform.localScale.y);
				}
		
				MenuItemEntryAnim animEntry = GetComponent<MenuItemEntryAnim> ();
				if (animEntry != null) {
						animEntry._StartScale = new Vector2 (gameObject.transform.localScale.x, gameObject.transform.localScale.y);
				}
		
				MenuItemExitAnim animExit = GetComponent<MenuItemExitAnim> ();
				if (animExit != null) {
						animExit._EndPos = gameObject.transform.position;
						animExit._EndScale = new Vector2 (gameObject.transform.localScale.x, gameObject.transform.localScale.y);
				}
		}
	
		void saveEndCondition ()
		{
				MenuItemAnim anim = GetComponent<MenuItemAnim> ();
				if (anim != null) {
						anim._EndPos = gameObject.transform.position;
						anim._EndScale = new Vector2 (gameObject.transform.localScale.x, gameObject.transform.localScale.y);
				}
		
				MenuItemEntryAnim animEntry = GetComponent<MenuItemEntryAnim> ();
				if (animEntry != null) {
						animEntry._EndPos = gameObject.transform.position;
						animEntry._EndScale = new Vector2 (gameObject.transform.localScale.x, gameObject.transform.localScale.y);
				}
		
				MenuItemExitAnim animExit = GetComponent<MenuItemExitAnim> ();
				if (animExit != null) {
						animExit._StartScale = new Vector2 (gameObject.transform.localScale.x, gameObject.transform.localScale.y);
				}
		}
	
		void restoreStartCondition ()
		{
				MenuItemAnim anim = GetComponent<MenuItemAnim> ();
				if (anim != null) {
						gameObject.transform.position = anim._StartPos;
						gameObject.transform.localScale = new Vector3 (anim._StartScale.x, anim._StartScale.y, gameObject.transform.localScale.z);
				}
		
				MenuItemEntryAnim animEntry = GetComponent<MenuItemEntryAnim> ();
				if (animEntry != null) {
						gameObject.transform.localScale = new Vector3 (animEntry._StartScale.x, animEntry._StartScale.y, gameObject.transform.localScale.z);
				}
		
				MenuItemExitAnim animExit = GetComponent<MenuItemExitAnim> ();
				if (animExit != null) {
						gameObject.transform.position = animExit._EndPos;
						gameObject.transform.localScale = new Vector3 (animExit._StartScale.x, animExit._StartScale.y, gameObject.transform.localScale.z);
				}
		}
	
		void restoreEndCondition ()
		{
				MenuItemAnim anim = GetComponent<MenuItemAnim> ();
				if (anim != null) {
						gameObject.transform.position = anim._EndPos;
						gameObject.transform.localScale = new Vector3 (anim._EndScale.x, anim._EndScale.y, gameObject.transform.localScale.z);
				}
		
				MenuItemEntryAnim animEntry = GetComponent<MenuItemEntryAnim> ();
				if (animEntry != null) {
						gameObject.transform.position = animEntry._EndPos;
						gameObject.transform.localScale = new Vector3 (animEntry._EndScale.x, animEntry._EndScale.y, gameObject.transform.localScale.z);
				}
		
				MenuItemExitAnim animExit = GetComponent<MenuItemExitAnim> ();
				if (animExit != null) {
						gameObject.transform.localScale = new Vector3 (animExit._EndScale.x, animExit._EndScale.y, gameObject.transform.localScale.z);
				}
		}
	
		void correctAnimation ()
		{
				MenuItemAnim anim = GetComponent<MenuItemAnim> ();
				if (anim != null) {
						MenuItemEntryAnim animEntry = GetComponent<MenuItemEntryAnim> ();
						if (animEntry == null)
								animEntry = gameObject.AddComponent<MenuItemEntryAnim> ();
			
						animEntry._EndPos = anim._EndPos;
						animEntry._StartScale = anim._StartScale;
						animEntry._EndScale = anim._EndScale;

						MenuItemExitAnim animExit = GetComponent<MenuItemExitAnim> ();
						if (animExit == null)
								animExit = gameObject.AddComponent<MenuItemExitAnim> ();

						animExit._EndPos = anim._StartPos;
						animExit._StartScale = anim._EndScale;
						animExit._EndScale = anim._StartScale;
			
						//Destroy(anim);
				}
		}
}
