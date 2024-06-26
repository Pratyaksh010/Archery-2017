using UnityEngine;
using System.Collections;

public class shopThirdPageEvent :GUIItemsManager
{
	public Transform Pauseprefab;
	
	public Texture currenttexture;
	
	public GUITexture[] stabilitytexture;
	
	public GUITexture[] accuracytexture;
	
	public GUITexture[] powertexture;
	
	public GUIText stabilitytext;
	
	public GUIText powertext;
	
	public GUIText acctext;
	
	
	// Use this for initialization
	void Awake()
	{
		 ableacc();
		 ablePower();
		 ablestability();
	}
	void changecostvalue()
	{
		 switch(PlayerPrefs.GetInt("acc_active"))
		{
		case 0:acctext.text="\n500\nCOINS";
			    break;
		case 1:
			   acctext.text="\n1500\nCOINS";
			    break;
		case 2: acctext.text="\n3000\nCOINS";
			    break;
		case 3:
			    acctext.text="\n5000\nCOINS";
			    break;
		case 4:
			    acctext.text="\n10000\nCOINS";
			    break;
			
		}
		switch(PlayerPrefs.GetInt("stabilityactive"))
		{
		case 0:  stabilitytext.text="\n500\nCOINS";
			    break;
		case 1:
			     stabilitytext.text="\n1500\nCOINS";
			    break;
		case 2:  stabilitytext.text="\n3000\nCOINS";
			    break;
		case 3:
			     stabilitytext.text="\n5000\nCOINS";
			    break;
		case 4:
			     stabilitytext.text="\n10000\nCOINS";
			    break;
			
		}
		switch(PlayerPrefs.GetInt("poweractive"))
		{
		case 0:  powertext.text="\n500\nCOINS";
			    break;
		case 1:
			     powertext.text="\n1500\nCOINS";
			    break;
		case 2:   powertext.text="\n3000\nCOINS";
			    break;
		case 3:
			   powertext.text="\n5000\nCOINS";
			    break;
		case 4:
			    powertext.text="\n10000\nCOINS";
			    break;
			
		}
		 //stabilitytext.text="\n1000\nCOINS";
		// powertext.text="\n1000\nCOINS";
	}
	//acctext.text="\n1000\nCOINS";
	void Start()
	{
	 base.Init();  	
	changecostvalue();	 
	}
	
	
	void Update()
	{
		
		
		
	}
	// Update is called once per frame
		public override void OnSelectedEvent(GUIItem item)
	{
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			
			
			
			
				
			if(item.name == "Accurbutton"&&store_currentStatus.instances._chekoutofcoins==false)
			{
			    if(PlayerPrefs.GetInt("acc_active")<5)
				{
				 Debug.Log("----- In Derived class event handle : " + item.name);
				 store_currentStatus.instances.accShop();
				 ableacc();
				}
				 
			}
			
				
			if(item.name == "Powerbutton"&&store_currentStatus.instances._chekoutofcoins==false)
			{
			   if(PlayerPrefs.GetInt("poweractive")<5)
				{
				 Debug.Log("----- In Derived class event handle : " + item.name);
				store_currentStatus.instances.powerShop();
				 ablePower();
				}
				
			}
			if(item.name == "stabilitybutton"&&store_currentStatus.instances._chekoutofcoins==false)
			{
				if(PlayerPrefs.GetInt("stabilityactive")<5)
				{
			     store_currentStatus.instances.stabilityshop();
				 Debug.Log("----- In Derived class event handle : " + item.name);
				 ablestability();
				}
				
				
			}
			
			
		
			
			
			
		
			
		
			
			
		
			
			
			
			
        }
		
	}
	
	void  ableacc()
	{
		for(int i=0;i<PlayerPrefs.GetInt("acc_active");i++)
		{
			accuracytexture[i].texture=currenttexture;
			
			changecostvalue();
		}
		
	}
	void  ablestability()
	{
		for(int i=0;i<PlayerPrefs.GetInt("stabilityactive");i++)
		{
			stabilitytexture[i].texture=currenttexture;
			changecostvalue();
		}
		
	}
	void  ablePower()
	{
		for(int i=0;i<PlayerPrefs.GetInt("poweractive");i++)
		{
			powertexture[i].texture=currenttexture;
			changecostvalue();
		}
		
	}
	
}

