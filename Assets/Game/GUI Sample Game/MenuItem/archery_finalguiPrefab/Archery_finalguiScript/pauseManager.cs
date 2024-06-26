using UnityEngine;
using System.Collections;

public class pauseManager : MonoBehaviour 
{
	public GameObject[] _GUIItmManagerArr = null;
	GUIItemsManager mcurGUIItemsManager = null;
	string mStrNextScreenToLoad = null;
	bool mbShouldRemove = false;
	
	public delegate void actionComplete();
	public actionComplete onScreenExitComplete = null;

	// Use this for initialization
	void Start () 
	{
	
			if(_GUIItmManagerArr != null)
		{
			
			LoadScreen(_GUIItmManagerArr[0].name);
		}		
	}
	
	public void LoadScreen(string strName)
	{
		//SEARCH FOR PREFAB WITH THIS NAME
		mStrNextScreenToLoad = strName;
		GameObject managerObj = null;
		int screenIndex = 0;
		if(_GUIItmManagerArr == null || _GUIItmManagerArr.Length < 1)
			return;
		foreach(GameObject go in _GUIItmManagerArr)
		{
			if(go.name == strName)
			{
				mStrNextScreenToLoad = go.name;
				managerObj = go;
				break;
			}
		}
		
		//DONT LOAD IF THIS PREFAB DOESNT EXIST
		if(managerObj == null)
			return;
		
		if(mcurGUIItemsManager == null)
		{
			//Debug.Log("Loading screen " +strName);
			//CREATING NEW ITEM MANAGER FROM PREFAB ARRAY
			GameObject go = Instantiate(managerObj, Vector3.zero, Quaternion.identity) as GameObject;
			mcurGUIItemsManager = go.GetComponent<GUIItemsManager>();
			mcurGUIItemsManager.onEnterCompleteCallBack = onEnterCompleteCallBack;
			mcurGUIItemsManager.onExitCompleteCallBack = onExitCompleteCallBack;
		///////////	mcurGUIItemsManager._pauseManager = this;
		}
		else
		{
			//IF A ITEMS MANAGER EXISTS MAKE IT EXIT
			mcurGUIItemsManager.State = eGUI_ITEMS_MANAGER_STATE.Exiting;
		}	
	}
		
	public void onEnterCompleteCallBack()
	{
		//NEW MENU ENTERED
		//Debug.Log("Entry Complete");
	}
		
	public void onExitCompleteCallBack()
	{
		//CALLED AFTER ALL ITEM ANIMATIONS
		if(mbShouldRemove == false)
		{
			if(mcurGUIItemsManager != null)
			{
				//Debug.Log("Exit Complete");
				Destroy(mcurGUIItemsManager.gameObject);
				mcurGUIItemsManager = null;
			}
			LoadScreen(mStrNextScreenToLoad);
		}
		else
		{
			//SEND MESSAGE THAT THE SCREEN HAS EXITED
			if(onScreenExitComplete != null)
				onScreenExitComplete();
			
			//REMOVING THE GAME OBJECTS
			Destroy(mcurGUIItemsManager.gameObject);
			Destroy(gameObject);
		}
	}
	
	public void closeScreenManager()
	{
		//CLOSE THIS SCREEN MANAGER AFTER ALL ANIMATIONS
		mbShouldRemove = true;
		if(mcurGUIItemsManager != null)
		{
			mcurGUIItemsManager.State = eGUI_ITEMS_MANAGER_STATE.Exiting;
		}
	}
	
}

