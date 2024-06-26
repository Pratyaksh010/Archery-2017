using UnityEngine;
using System.Collections;

public class ArrowSelectionEvent:GUIItemsManager{
	
	public GUITexture _leftButtonImage ;
	public GUITexture _rightButtonImage;
	
	
	
	

	
	
	public GUIText _noarrowValue ;
	public Texture[] _arrowImage ;
	
	public GUITexture _currentArrowImage ;
	
    int _countLeftButtonPressed ;
	
	int _countRightButtonPressed ;
	
	public Texture _dummytexture ;
	
	public Texture _leftButtonTexture ;
	
	public Texture _rightButtonTexture ;
	
	bool onetimecall ;
	
	
	
	public GUITexture _currentarrowPower;
	
	public Texture[] _arrowPowerImage ;
	
	public GUITexture _currentarrowDescriptionImage ;
	
	public Texture[] _arrowDescriptionImage ;
	
	public GUITexture _currentarrowCostImage;
	
	public Texture[] _arrowCostImage;
	
	public Texture[] _rightButtonImageUI ;
	
	public Texture[] _leftButtonImageUI ;
   // Use this for initialization
	void Start ()
	{   
		 base.Init();
		_countLeftButtonPressed  = 0 ;
		_countRightButtonPressed = 2 ;
		_currentArrowImage.texture = _arrowImage[0];
		_currentarrowDescriptionImage.texture = _arrowDescriptionImage[0];
		_currentarrowPower.texture = _arrowPowerImage[0];
		_currentarrowCostImage.texture = _arrowCostImage[0];
		_leftButtonImage.texture = _leftButtonImageUI[0];
		_rightButtonImage.texture = _rightButtonImageUI[0];
	    
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(onetimecall == false)
		{
			changeButtonImage(0);
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
						purchaseArrow(_countLeftButtonPressed);
						
					}
				}
		
		
	
	       }
    }
}
	
	void changeButtonImage(int i)
	{
		_currentArrowImage.texture = _arrowImage[i];
		_currentarrowDescriptionImage.texture = _arrowDescriptionImage[i];
		_currentarrowPower.texture = _arrowPowerImage[i];
		_currentarrowCostImage.texture = _arrowCostImage[i] ;
		
		if(i==0)
		{
			_leftButtonImage.texture = _dummytexture ;
			_rightButtonImage.texture =  _rightButtonTexture ;
			_noarrowValue.text = ""+PlayerPrefs.GetInt("Firstnumberofarrow");
		}
		if(i==1)
		{
			_leftButtonImage.texture  =   _leftButtonTexture ;
		    _rightButtonImage.texture =  _rightButtonTexture ;
			_noarrowValue.text = ""+PlayerPrefs.GetInt("Secondnumberofarrow");
		}
		if(i==2)
		{
			_rightButtonImage.texture = _dummytexture ;
			_leftButtonImage.texture  =   _leftButtonTexture ;
			_noarrowValue.text = ""+PlayerPrefs.GetInt("Thirdnumberofarrow");
		}
		
		
	}
	void purchaseArrow(int currentArrow)
	{
		switch(currentArrow)
		{
		  case 0:
			 
			 store_currentStatus.instances.arrowpurchase(1);
			// if(store_currentStatus.instances._chekoutofcoins==false)
			//{
			_noarrowValue.text = ""+PlayerPrefs.GetInt("Firstnumberofarrow");
			//}
		  break ;
		  case 1:

			 store_currentStatus.instances.arrowpurchase(2);
			// if(store_currentStatus.instances._chekoutofcoins==false)
			// {
			 _noarrowValue.text = ""+PlayerPrefs.GetInt("Secondnumberofarrow");
			// }
		  break ;
		  case 2:
			 
			store_currentStatus.instances.arrowpurchase(3);
			//if(store_currentStatus.instances._chekoutofcoins==false)
			//{
			_noarrowValue.text = ""+PlayerPrefs.GetInt("Thirdnumberofarrow");
			//}
		  break ;
		}
	}
	
	
}