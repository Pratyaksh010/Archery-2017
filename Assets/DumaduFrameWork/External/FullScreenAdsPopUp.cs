using UnityEngine;
using System.Collections;

public class FullScreenAdsPopUp : MonoBehaviour {
	public Texture2D _LoadingPage;
	public GUIStyle _BgStyle;
	public GUIStyle _GuiText;
	// Use this for initialization
	void Start () {
		Invoke("DestroyGameObject",ExternalInterfaceHandler.Instance._AdsDelayTime +0.2f);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		GUI.depth = -1;
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),_LoadingPage);
		GUI.Label(new Rect(Screen.width/2,Screen.height/2,Screen.width/10,Screen.height/10),"PLEASE WAIT . . . ",_GuiText);
	}
	void DestroyGameObject()
	{
		Destroy(gameObject);
	}
}
