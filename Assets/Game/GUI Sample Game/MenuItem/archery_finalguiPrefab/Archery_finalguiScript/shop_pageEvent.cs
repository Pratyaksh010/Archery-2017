using UnityEngine;
using System.Collections;

public class shop_pageEvent :GUIItemsManager
{
	public Transform Pauseprefab;
	public GUIText firstbowtext;
	
	public GUIText secondbowtext;
	
	public GUIText thirdbowtext;
	
	public int curentArrowselected;
	
	
	// Use this for initialization
	void Start ()
	{
	  base.Init(); 
	
	  curentArrowselected=PlayerPrefs.GetInt("Arrowselected");
		
	  PlayerPrefs.SetInt("Arrowselected",curentArrowselected);
		
	  thirdbowtext.text=""+PlayerPrefs.GetInt("Thirdnumberofarrow");
		
	  secondbowtext.text=""+PlayerPrefs.GetInt("Secondnumberofarrow");
		
	  firstbowtext.text=""+PlayerPrefs.GetInt("Firstnumberofarrow");
		
	
	  // secondbowtext.text="1000 coins";
	  
	  // thirdbowtext.text="1500 coins";
	}
	
	
	void Update()
	{
		
		
		
		
		
		
		/*
		if(PlayerPrefs.GetInt("FirstArrowactivate")==1&&PlayerPrefs.GetString("FirstArrowtext")=="SELECTED"&& PlayerPrefs.GetInt("Arrowselected")!=0)
		{
			
			firstbowtext.text="ACTIVATE";
			
		}
		if(PlayerPrefs.GetInt("SecondArrowactivate")==1&&PlayerPrefs.GetString("Secondarrowtext")=="Activate"&& PlayerPrefs.GetInt("Arrowselected")!=1)
		{
			
			secondbowtext.text="ACTIVATE";
			
		}
		if(PlayerPrefs.GetInt("ThirdArrowactivate")==1&&PlayerPrefs.GetString("Thirdarrowtext")=="Activate"&& PlayerPrefs.GetInt("Arrowselected")!=2)
		{
			
			thirdbowtext.text="ACTIVATE";
			
		}
		
		if(PlayerPrefs.GetInt("Arrowselected")==0)//&&PlayerPrefs.GetString("Firstbowtext")=="Activate")
		{
			firstbowtext.text="SELECTED";
			store_currentStatus.instances.currentgravity=0f;
		}
		if(PlayerPrefs.GetInt("Arrowselected")==1&&PlayerPrefs.GetString("Secondarrowtext")=="Activate")
		{
			secondbowtext.text="SELECTED";
			store_currentStatus.instances.currentgravity=.04f;
			//store_currentStatus.instances.currentbowtexture=store_currentStatus.instances.bowtexture[1];
		}
		if(PlayerPrefs.GetInt("Arrowselected")==2&&PlayerPrefs.GetString("Thirdarrowtext")=="Activate")
		{
			thirdbowtext.text="SELECTED";
			store_currentStatus.instances.currentgravity=.07f;
			//store_currentStatus.instances.currentbowtexture=store_currentStatus.instances.bowtexture[2];
		}*/
		
	}
	// Update is called once per frame
		public override void OnSelectedEvent(GUIItem item)
	{
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			
			
		
				
		
				if(item.name == "Thirdcobu"&&store_currentStatus.instances._chekoutofcoins==false)
			{
			
				 Debug.Log("----- In Derived class event handle : " + item.name);
				
				
				
				
				  //if(thirdbowtext.text=="1500 coins")
				//{
					//store_currentStatus.instances.Arrowpurchase(3);
					 store_currentStatus.instances.arrowpurchase(3);
					addthirdarrow();
					
				//}
				// if(thirdbowtext.text=="ACTIVATE")
				// {
					//curentArrowselected=2;
					
					//PlayerPrefs.SetInt("Arrowselected", curentArrowselected);
					
				// }
				
			 
			}
				if(item.name == "firstcobu"&&store_currentStatus.instances._chekoutofcoins==false)
			{
			
				 Debug.Log("----- In Derived class event handle : " + item.name);
				
				  //if(firstbowtext.text=="500 coins")
				//{
					
					 store_currentStatus.instances.arrowpurchase(1);
					 addfirstarrow();
					//store_currentStatus.instances.Arrowpurchase(1);
				//}
				 // if(firstbowtext.text=="ACTIVATE")
				// {
					//curentArrowselected=0;
					
					//PlayerPrefs.SetInt("Arrowselected", curentArrowselected);
					
				// }
				
			 
			}
			if(item.name == "fsecondcobu"&&store_currentStatus.instances._chekoutofcoins==false)
			{
			
				 Debug.Log("----- In Derived class event handle : " + item.name);
				// if(secondbowtext.text=="1000 coins")
				//{
					 store_currentStatus.instances.arrowpurchase(2);
					 addsecondarrow();
					//store_currentStatus.instances.Arrowpurchase(2);
				//}
				 
				//if(secondbowtext.text=="ACTIVATE")
				// {
				//	curentArrowselected=1;
					
					//PlayerPrefs.SetInt("Arrowselected", curentArrowselected);
					
				// }
				
				
			 
			}
			
			
        }
		
	}
	public void addthirdarrow()
	{
		thirdbowtext.text=""+PlayerPrefs.GetInt("Thirdnumberofarrow");
	}
	
	public void addsecondarrow()
	{
		secondbowtext.text=""+PlayerPrefs.GetInt("Secondnumberofarrow");
	}
	public void addfirstarrow()
	{
		firstbowtext.text=""+PlayerPrefs.GetInt("Firstnumberofarrow");
	}
}
