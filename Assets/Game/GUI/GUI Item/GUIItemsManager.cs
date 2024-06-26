using UnityEngine;
using System.Collections;

public enum eGUI_ITEMS_MANAGER_STATE
{
	Enter = 0, 		//On Insantiate
	Settled,		//After AllAnimations
	Exiting,		//On Exit called from Screen manager
	ExitComplete,	//After All Items Exit
}

public class GUIItemsManager : MonoBehaviour 
{
	//Delegate Methods
	public delegate void actionComplete();
	public actionComplete onEnterCompleteCallBack = null;
	public actionComplete onExitCompleteCallBack = null;
	public ScreenManager _screenManager = null;
		
	//State
	protected eGUI_ITEMS_MANAGER_STATE meState = eGUI_ITEMS_MANAGER_STATE.Enter;
	protected GameObject[] mTabButtonArray = new GameObject[0];
	public GameObject[] _menuItems = null;
	int numberOfActiveItems = 0;
	
	// Use this for initialization
	void Start () 
	{
		//Init();	
	}
	
	//for Tab Button
	public void setAsTabButton(string buttonName)
	{
		GameObject tObj;
		for(int i = 0; i < _menuItems.Length; i++)
		{
			tObj = _menuItems[i];
			if(tObj.name == buttonName)
			{
				GameObject[] tempArray = new GameObject[mTabButtonArray.Length+1];
				mTabButtonArray.CopyTo(tempArray,0);
				tempArray[tempArray.Length-1] = tObj;
				mTabButtonArray = tempArray;
				break;
			}
		}
	}
	
	public void setTabButtonActive(int index,bool activeState)
	{
		GameObject tObj = null;
		if(mTabButtonArray.Length > 0 && index < mTabButtonArray.Length)
		{		
			tObj = mTabButtonArray[index];
			GUIItemButton buttonScr = tObj.GetComponent<GUIItemButton>();
			if(buttonScr != null)
			{
				buttonScr.setDisabled(activeState);
			}
		}
	}
	
	
	//Normal button Condition
	public void Init()
	{
		numberOfActiveItems = 0;
		//Debug.Log("--- Add Menu Items -----");
		_menuItems = new GameObject[transform.childCount];
		for(int i = 0; i < transform.childCount; i++)
		{
			_menuItems[i] = transform.GetChild(i).gameObject;
		}
		State = eGUI_ITEMS_MANAGER_STATE.Enter;
	}
	
	public void OnEnterCallBack(GameObject pGameObject)
	{
		numberOfActiveItems++;
		if(numberOfActiveItems >= _menuItems.Length)
		{
			OnEntryAnimationCompleted();
			State = eGUI_ITEMS_MANAGER_STATE.Settled;
			if(onEnterCompleteCallBack != null)
				onEnterCompleteCallBack();
		}
	}
		
	public void OnExitComplete(GameObject pObject)
	{
		//CHECK IF ALL OBJECTS COMPLETED ACTIONS 
		numberOfActiveItems--;
		if(numberOfActiveItems <= 0)
		{
			//DESTROY CONTAINER OBJECT IF REQUIRED
			OnExitAnimationCompleted();
			State = eGUI_ITEMS_MANAGER_STATE.ExitComplete;
			if(onExitCompleteCallBack != null)
				onExitCompleteCallBack();
		}
	}
	
	//NEED TO OVERRIDE THIS FUNCTION
	public virtual void OnSelectedEvent(GUIItem item)
	{
		//ON CALL BACK FROM THE BUTTONS
		Debug.Log("------- IN base Class.. GUI item selected : " + item.name);
		if(_screenManager.subScreenDelegate != null)
		{
			_screenManager.subScreenDelegate(item);	
		}
	}
	
	public virtual void OnExitAnimationCompleted()
	{
		
	}
	
	public virtual void OnEntryAnimationCompleted()
	{
		
	}

	public eGUI_ITEMS_MANAGER_STATE State
    {
		//Setter Getter For State
        get { return meState; }
        set 
		{ 
			meState = value; 
			UpdateState();
		}
    }

	public void DisableAllButtons()
    {		
        if(_menuItems != null)
        {
            for(int i = 0; i< _menuItems.Length;i++)
            {
                GameObject tMenuItem = _menuItems[i];
                GUIItemButton buttonScr = tMenuItem.GetComponent<GUIItemButton>();
             //   GUIToggleButton buttonScr2 = tMenuItem.GetComponent<GUIToggleButton>();
                if(buttonScr != null)
                    buttonScr.setRespondToInput(false);
//                else if(buttonScr2 != null)
//                    buttonScr2.setRespondToInput(false);
            }
        }
		
    }
	
	public void EnableAllButtons()
    {
        if(_menuItems != null)
        {
            for(int i = 0; i< _menuItems.Length;i++)
            {
                GameObject tMenuItem = _menuItems[i];
                GUIItemButton buttonScr = tMenuItem.GetComponent<GUIItemButton>();
                //GUIToggleButton buttonScr2 = tMenuItem.GetComponent<GUIToggleButton>();
                if(buttonScr != null)
                    buttonScr.setRespondToInput(true);
                //else if(buttonScr2 != null)
                  //  buttonScr2.setRespondToInput(true);
            }
        }
    }
	
	protected void UpdateState()
	{
		switch(meState)
		{
			case eGUI_ITEMS_MANAGER_STATE.Enter:
			//Debug.Log("--- enter state ----");
				if(_menuItems != null)
				{
					for(int i = 0; i< _menuItems.Length;i++)
					{
						GameObject tMenuItem = _menuItems[i];
						MenuItemEntryAnim tMenuEntryAnim = tMenuItem.GetComponent<MenuItemEntryAnim>();
						if(tMenuEntryAnim != null)
							tMenuEntryAnim.beginAnimationWithCallBack(OnEnterCallBack);
					}
				}
				break;
			case eGUI_ITEMS_MANAGER_STATE.Exiting:
				//Do action for exiting
				if(_menuItems != null)
				{
					//ANIMATE ALL ACTIVE
					for(int i = 0; i< _menuItems.Length;i++)
					{
						GameObject tMenuItem = _menuItems[i];
						MenuItemExitAnim tMenuEntryAnim = tMenuItem.GetComponent<MenuItemExitAnim>();
						if(tMenuEntryAnim != null)
							tMenuEntryAnim.beginAnimationWithCallBack(OnExitComplete);
					}
				}
				break;
			default:
				break;
		}
	}
}
