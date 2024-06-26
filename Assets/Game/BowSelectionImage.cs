using UnityEngine;
using System.Collections;

public class BowSelectionImage :GUIItemsManager
{
	int _countLeftButtonPressed ;
    int _countRightButtonPressed ;
	public GUITexture _leftButtonImage ;
	public GUITexture _rightButtonImage;
	public Texture[] _bowImage ;
	public GUITexture _currentBowImage ;
	public Texture _dummytexture ;
	public Texture _leftButtonTexture ;
	public Texture _rightButtonTexture ;
	public GUITexture _currentBowPower;
	public Texture[] _BowPowerImage ;
	public GUITexture _currentBowDescriptionImage ;
	public Texture[] _bowDescriptionImage ;
	public GUITexture _currentbowCostImage;
	public Texture[] _bowCostImage;
    public Texture[] _rightButtonImageUI ;
	public Texture[] _leftButtonImageUI ;
	public GUITexture _currentSelecton ;
	public Texture[] _bowBuy ;
	public int curentbowselected;
	bool onetimecall ;
	public Texture[] _afterPurchaseBow ;
	
	//public Texture _dummytexture ;
	// Use this for initialization
	void Start ()
	{
		 base.Init(); 
		curentbowselected = 0;//PlayerPrefs.GetInt("bowselected");
		 changeButtonImage(curentbowselected);
		_countRightButtonPressed = 2 ;
		_countLeftButtonPressed  = 0 ;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(onetimecall == false)
		{
			BowSelectionImage1(curentbowselected);
			onetimecall  = true ;
		}
		if(Input.GetMouseButtonDown(0)&&_leftButtonImage.HitTest(Input.mousePosition)==true)
		{
			 if( _countLeftButtonPressed>0)
			{
			_leftButtonImage.texture = _leftButtonImageUI[1];
			}
		}
		if(Input.GetMouseButtonDown(0)&&_rightButtonImage.HitTest(Input.mousePosition)==true)
		{
			 if( _countRightButtonPressed>0)
			{
			_rightButtonImage.texture = _rightButtonImageUI[1];
			}
		}
		if(Input.GetMouseButtonUp(0)&&(_leftButtonImage.texture != _leftButtonImageUI[0]||_rightButtonImage.texture!=_rightButtonImageUI[0]))
		{
			  if( _countLeftButtonPressed>0)
			{
			_leftButtonImage.texture =  _leftButtonImageUI[0];
			}
			 if( _countRightButtonPressed>0)
			{
			 _rightButtonImage.texture =  _rightButtonImageUI[0];
			}
		}
		
		
	}
	
	public override void OnSelectedEvent(GUIItem item)
	{
		if(meState == eGUI_ITEMS_MANAGER_STATE.Settled)
		{
			
			if(item.name == "LeftButton"&&_countLeftButtonPressed>0)
			{
				_countLeftButtonPressed = _countLeftButtonPressed -1 ;
					
				_countRightButtonPressed = _countRightButtonPressed +1 ;
				
				changeButtonImage(_countLeftButtonPressed);
			}
			else
			{
				if(item.name == "RightButton"&&_countRightButtonPressed>0)
			    {
				   _countLeftButtonPressed = _countLeftButtonPressed +1 ;
					
				   _countRightButtonPressed = _countRightButtonPressed -1 ;
					
					changeButtonImage(_countLeftButtonPressed);
			    }
				else
				{
					if(item.name == "BuyButton")
					{
					 
						PurchaseBow(_countLeftButtonPressed);
						
					}
				}
		
		
	
	       }
    }
}
	void BowSelectionImage1(int _currentBow)
	{
		
	}
	void changeButtonImage(int i)
	{
		 _currentBowImage.texture = _bowImage[i];
		 _currentBowDescriptionImage.texture = _bowDescriptionImage[i];
		 _currentBowPower.texture = _BowPowerImage[i];
		 _currentbowCostImage.texture = _bowCostImage[i] ;
		 if(i==0&&store_currentStatus.instances.currentbowtexture==store_currentStatus.instances.bowtexture[0])
		{
			 _currentSelecton.texture = _bowBuy[1];
			
		}
		if(i==0&&store_currentStatus.instances.currentbowtexture!=store_currentStatus.instances.bowtexture[0])
		{
			 _currentSelecton.texture = _bowBuy[2];
		}
		if(i==1&&store_currentStatus.instances.currentbowtexture==store_currentStatus.instances.bowtexture[1]&&PlayerPrefs.GetInt("Secondbowactivate")==1)
		{
			 _currentSelecton.texture = _bowBuy[1];
		}
		if(i==1&&PlayerPrefs.GetInt("Secondbowactivate")==0)
		{
			 _currentSelecton.texture = _bowBuy[0];
		}
		if(i==1&&store_currentStatus.instances.currentbowtexture!=store_currentStatus.instances.bowtexture[1]&&PlayerPrefs.GetInt("Secondbowactivate")==1)
		{
			 _currentSelecton.texture = _bowBuy[2];
		}
		if(i==2&&store_currentStatus.instances.currentbowtexture==store_currentStatus.instances.bowtexture[2]&&PlayerPrefs.GetInt("Thirdbowactivate")==1)
		{
			 _currentSelecton.texture = _bowBuy[1];
		}
		if(i==2&&PlayerPrefs.GetInt("Thirdbowactivate")==0)
		{
			 _currentSelecton.texture = _bowBuy[0];
		}
		if(i==2&&store_currentStatus.instances.currentbowtexture!=store_currentStatus.instances.bowtexture[2]&&PlayerPrefs.GetInt("Thirdbowactivate")==1)
		{
			 _currentSelecton.texture = _bowBuy[2];
		}
		 switch(i)
		{
		    
		    case 1:
			   if(PlayerPrefs.GetInt("Secondbowactivate")==1)
			   {
				 _currentbowCostImage.texture = _bowCostImage[0] ;
			   }
			break;
		    case 2:
			
			  if(PlayerPrefs.GetInt("Thirdbowactivate")==1)
			   {
				 _currentbowCostImage.texture = _bowCostImage[0] ;
			   }
			break ;
		}
		
		
		if(i==0)
		{
			_leftButtonImage.texture = _dummytexture ;
			_rightButtonImage.texture =  _rightButtonTexture ;
			//_noarrowValue.text = ""+PlayerPrefs.GetInt("Firstnumberofarrow");
		}
		if(i==1)
		{
			_leftButtonImage.texture  =   _leftButtonTexture ;
		    _rightButtonImage.texture =  _rightButtonTexture ;
			//_noarrowValue.text = ""+PlayerPrefs.GetInt("Secondnumberofarrow");
		}
		if(i==2)
		{
			_rightButtonImage.texture = _dummytexture ;
			_leftButtonImage.texture  =   _leftButtonTexture ;
			//_noarrowValue.text = ""+PlayerPrefs.GetInt("Thirdnumberofarrow");
		}
		
		
	}
	
	void PurchaseBow(int itemno)
	{
		switch(itemno)
		{
		  case 0:
			if(_currentSelecton.texture == _bowBuy[2])
			  {
				  PlayerPrefs.SetInt("bowselected",0);
				 _currentSelecton.texture = _bowBuy[1];
				  store_currentStatus.instances.currentbowtexture=store_currentStatus.instances.bowtexture[0];
					
			  }
			
		  break;
		  case 1:
			  if(_currentSelecton.texture == _bowBuy[0])
			  {
				store_currentStatus.instances.bowpurchase(2);
				changeBowafterPurchase1(2);
			  }
			else
			{
			  if(_currentSelecton.texture == _bowBuy[2])
			  {
				  PlayerPrefs.SetInt("bowselected",1);
				 _currentSelecton.texture = _bowBuy[1];
				  store_currentStatus.instances.currentbowtexture=store_currentStatus.instances.bowtexture[1];
					
			  }
			}
			
		  break;
		  case 2:
			if(_currentSelecton.texture == _bowBuy[0])
			  {
				store_currentStatus.instances.bowpurchase(3);
				changeBowafterPurchase1(3);
			  }
			else
			{
			  if(_currentSelecton.texture == _bowBuy[2])
			  {
				  PlayerPrefs.SetInt("bowselected",2);
				 _currentSelecton.texture = _bowBuy[1];
				  store_currentStatus.instances.currentbowtexture=store_currentStatus.instances.bowtexture[2];
					
			  }
			}
		  break;
			
		//}
		
	}
	
		
	
}
	void changeBowafterPurchase1(int itemno1)
	{
	   switch(itemno1)
		{
		    case 2:
			
			    if(PlayerPrefs.GetInt("Secondbowactivate")==1)
			    {
				
				    PlayerPrefs.SetInt("bowselected",1);
				   _currentSelecton.texture = _bowBuy[1];
				    store_currentStatus.instances.currentbowtexture=store_currentStatus.instances.bowtexture[1];
				   _currentbowCostImage.texture = _bowCostImage[0] ;
			    }
			
			break;
		    case 3:
			 if(PlayerPrefs.GetInt("Thirdbowactivate")==1)
			    {
				
				    PlayerPrefs.SetInt("bowselected",2);
				   _currentSelecton.texture = _bowBuy[1];
				    store_currentStatus.instances.currentbowtexture=store_currentStatus.instances.bowtexture[2];
				   _currentbowCostImage.texture = _bowCostImage[0] ; 
			    }
			break ;
		}
		
		
	}
}