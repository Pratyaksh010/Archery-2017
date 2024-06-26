using UnityEngine;
using System.Collections;

public class ScreenManager : MonoBehaviour
{
		public GameObject[] _GUIItmManagerArr = null;
		public GUIItemsManager mcurGUIItemsManager = null;
		string mStrNextScreenToLoad = null;
		bool mbShouldRemove = false;
		bool mbPersistentObjAnimPending = false;
	
		public delegate void actionComplete ();
		public actionComplete onScreenExitComplete = null;
	
		public ArrayList mPersistantGameObjects = new ArrayList ();	
		public ArrayList mUnwantedPersistantGameObjects = new ArrayList ();
		public string _PersistantObjectState = null;
		public string userdata = "";
	
		public delegate void subScreenDelegateFunction (GUIItem item);
		public subScreenDelegateFunction subScreenDelegate;
	
		public delegate void subScreenCallBackDelegateFunction ();
		public subScreenCallBackDelegateFunction subScreenPreEntryDelegate = null;
		public subScreenCallBackDelegateFunction subAnimationEntryCompleteDelegate = null;
		public subScreenCallBackDelegateFunction subAnimationExitCompleteDelegate = null;
		public string defaultScreen = "";
	
	
	
	
		void Start ()
		{
				//LOAD THE FIRST SCREEN	
				if (_GUIItmManagerArr != null && defaultScreen == "") {
						LoadScreen (_GUIItmManagerArr [0].name);
				} else {
						LoadScreen (defaultScreen);
				}
		}
	
		public void AddPersistantObject (GameObject obj)
		{
				mPersistantGameObjects.Add (obj);
				MenuItemEntryAnim anim = obj.GetComponent<MenuItemEntryAnim> ();
				if (anim != null)
						anim.beginAnimationWithCallBack (null);
		}
	
		public void AnimateAllPersistantGameObjects ()
		{
				//SEND EXIT ANIMATION TO ALL PERSISTANT OBJECTS AND TREAT THEM AS UNWANTED
				foreach (GameObject obj in mPersistantGameObjects) {
						mUnwantedPersistantGameObjects.Add (obj);
						MenuItemEntryAnim anim = obj.GetComponent<MenuItemEntryAnim> ();
						if (anim != null)
								anim.beginAnimationWithCallBack (null);
				}
		}
	
		public void RemoveAllPersistantGameObjects ()
		{
				//SEND EXIT ANIMATION TO ALL PERSISTANT OBJECTS AND TREAT THEM AS UNWANTED
				foreach (GameObject obj in mPersistantGameObjects) {
						mUnwantedPersistantGameObjects.Add (obj);
						MenuItemExitAnim anim = obj.GetComponent<MenuItemExitAnim> ();
						if (anim != null)
								anim.beginAnimationWithCallBack (RemovePersistantGameObjectCallBack);
				}
				mPersistantGameObjects.RemoveRange (0, mPersistantGameObjects.Count);
				_PersistantObjectState = null;
		}
	
		public void RemovePersistantGameObjectCallBack (GameObject pObj)
		{
				//FIRST REMOVE ITE FORM ARRAY THEN DESTROY IT
				mUnwantedPersistantGameObjects.Remove (pObj);
				DestroyObject (pObj);
				if (mUnwantedPersistantGameObjects.Count <= 0 && mbPersistentObjAnimPending) {
						//ANIMATE NEXT
						mbPersistentObjAnimPending = false;
						onExitCompleteCallBack ();			
				}
		}
	
		public void LoadScreen (string strName)
		{
				//SEARCH FOR PREFAB WITH THIS NAME		
//		Debug.Log("Loading screen "+strName);
		
				mStrNextScreenToLoad = strName;
				GameObject managerObj = null;
				if (_GUIItmManagerArr == null || _GUIItmManagerArr.Length < 1)
						return;
		
				foreach (GameObject go in _GUIItmManagerArr) {
						if (go.name == strName) {
								mStrNextScreenToLoad = go.name;
								managerObj = go;
								break;
						}
				}
		
				//DONT LOAD IF THIS PREFAB DOESNT EXIST
				if (managerObj == null)
						return;

				if (mcurGUIItemsManager == null) {
						//Debug.Log("Loading screen " +strName);
						//CREATING NEW ITEM MANAGER FROM PREFAB ARRAY
			

//						if (managerObj != null)
//								Debug.Log ("Not Null" + managerObj .name);
//						else
//								Debug.Log ("<----Null----->");
			
						GameObject go = Instantiate (managerObj, Vector3.zero, Quaternion.identity) as GameObject;
			
						// if(go!=null)
						//{
						mcurGUIItemsManager = go.GetComponent<GUIItemsManager> ();
						mcurGUIItemsManager.onEnterCompleteCallBack = onEnterCompleteCallBack;
						mcurGUIItemsManager.onExitCompleteCallBack = onExitCompleteCallBack;
						mcurGUIItemsManager._screenManager = this;
						if (subScreenPreEntryDelegate != null)
								subScreenPreEntryDelegate ();
						//}
				} else {
						//IF A ITEMS MANAGER EXISTS MAKE IT EXIT
						mcurGUIItemsManager.State = eGUI_ITEMS_MANAGER_STATE.Exiting;
				}	
		}
		
		public void onEnterCompleteCallBack ()
		{
				//NEW MENU ENTERED
				//Debug.Log("Entry Complete");
				if (subAnimationEntryCompleteDelegate != null)
						subAnimationEntryCompleteDelegate ();
		}
		
		public void onExitCompleteCallBack ()
		{
				//CALLED AFTER ALL ITEM ANIMATIONS
				if (mUnwantedPersistantGameObjects.Count > 0) {
						mbPersistentObjAnimPending = true;
						return;
				}
		
				if (subAnimationExitCompleteDelegate != null)
						subAnimationExitCompleteDelegate ();
		
				if (mbShouldRemove == false) {
						if (mcurGUIItemsManager != null) {
								//Debug.Log("Exit Complete");
								Destroy (mcurGUIItemsManager.gameObject);
								mcurGUIItemsManager = null;
						}
						LoadScreen (mStrNextScreenToLoad);
				} else {
						//SEND MESSAGE THAT THE SCREEN HAS EXITED
						if (onScreenExitComplete != null)
								onScreenExitComplete ();
			
						//REMOVING THE GAME OBJECTS
						Destroy (mcurGUIItemsManager.gameObject);
						Destroy (gameObject);
				}
		}
	
		public void closeScreenManager ()
		{
				//CLOSE THIS SCREEN MANAGER AFTER ALL ANIMATIONS
				mbShouldRemove = true;
				if (mcurGUIItemsManager != null) {
						mcurGUIItemsManager.State = eGUI_ITEMS_MANAGER_STATE.Exiting;
				}
		}
	
		public void DisableInput ()
		{
				if (mcurGUIItemsManager != null) {
						mcurGUIItemsManager.DisableAllButtons ();
				}
		}
	
		public void EnableInput ()
		{
				if (mcurGUIItemsManager != null) {
						mcurGUIItemsManager.EnableAllButtons ();
				}
		}
	
}
