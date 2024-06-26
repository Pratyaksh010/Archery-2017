using UnityEngine;
using System.Collections;

public class store_currentStatus:MonoBehaviour
{
	public static store_currentStatus instances;
	public int currentscene;
	public int currentdistances=0;
	public bool checkchallengemode;
	public int toatlcoins;// number of coins get by player
	public int Playermaxscore;// number of max score
	public Texture[] bowtexture;
	public int bow1cost;
	public int bow2cost;
	public int bow3cost;
	public int arrow1cost;
	public int arrow2cost;
	public int arrow3cost;
	public int secondbowactivate;
	public Texture currentbowtexture;
	public bool shoppagestart;
	//public float currentgravity;
	public float first_typeGravity;
	
	public float second_typeGravity;
	
	public float third_typeGravity;
	
	public int stabilitycost;
	public int acc_cost;
	public int powercost;
	public int currentstabilty;
	public int currentpowerability;
	public int currentaccability;
	public float stabilitylimit;
	public float accurcaylimit;
	public float pwerlimit;
	public float stabilityvalue;
	public float powervalue;
	public float addpowervalue;
	public float addstabilityvalue;
	public float addaccvalue;
	public float acc_ablityvalue;
	public int firstnuberarrow;
	public int secondnumberarrow;
	public int thirdnumberarrow;
	public bool Realasearrow;
	public int resetarrowvalue;
	public bool offcontrolling;// when gameplay arrow selection page open than stop controlling
	public bool loadingshoppage;
	
	public int _numberofcompleteChallenge;
	
	public bool _chekoutofcoins;
	
	public int _playerscore;
	
	
	public int xpcurrentscore;
	//public bool _openbuycoinspage;
	public bool _openshop;
	public int _firstrewards;
	public int _secondrewards;
	public int _thirdrewards;
	public int _fourthrewards;
	public int _fifthrewards;
	public int _sixthrewards;
	public int _sevenrewards;
	public int _eightrewards;
	public int _ninethrewards;
	public int _tenrewards ;
	public int _elvenrewards ;
	public int _tewelrewards ;
	public int  _thirteenrewards ;
	public int _fourteenrewards ;
	public int _fifteenrewards ;
	public int rematchscene;
	public bool challengemodecheck;
	public bool loadbuyscreen;
	public int resetscene;
	public bool loadingcheck;
	public bool joystickactive ;
	
	 public enum currentplayarea   // create ArcheryChallenge enum
   { 
		
	Practice= 0,
	EXHIBITION,
	Challenges
 
  }

  	
  
  public currentplayarea current;
  
  public enum currentChallengedis
	{
		
		
		current_distance30=0,
		
		current_distance50,
		
		current_distance70
		
		
		
		
	}
  
	public enum currentChallengewind
		
	{
		
		
		current_windeasy=0,
		
		current_windMed,
		
		current_windHard
		
		
		
		
	}
   
 public currentChallengewind currentwin=currentChallengewind.current_windeasy;
	
 public currentChallengedis currentchall=currentChallengedis.current_distance30;
	
	public enum ShopPage
	{
		first_shop_page=0,
		
		second_shop_page,
		
		third_shop_page,
		
		four_shop_page
	}
	
	public ShopPage shop_page=ShopPage.first_shop_page;
	
	
	/*public static store_currentStatus getInstance()
	{
		if(instances == null)
		{
			instances = new store_currentStatus();
			GC.SuppressFinalize(instances);
		}
		return instances;
	}
	*/
	void Awake()
	{
	    instances=this;
		 toatlcoins=PlayerPrefs.GetInt("Total_Coins");
		 PlayerPrefs.SetInt("Firstbowactivate",1);
		 PlayerPrefs.SetString("Firstbowtext", "SELECTED");
		 PlayerPrefs.SetInt("FirstArrowactivate",1);
		 PlayerPrefs.SetString("FirstArrowtext","SELECTED");
		 saveTotalCoins();
		xpcurrentscore=PlayerPrefs.GetInt("XpScore");
		UpdateBowStatus ();
		PlayerPrefs.SetInt("XpScore",xpcurrentscore);
			
		PlayerPrefs.SetInt("currentbow",0);
		
	}
	public void UpdateBowStatus()
	{
		if(PlayerPrefs.GetInt("bowselected")==0)
		{
			currentbowtexture=bowtexture[0];
		}
		if(PlayerPrefs.GetInt("bowselected")==1)
		{
			currentbowtexture=bowtexture[1];
		}
		if(PlayerPrefs.GetInt("bowselected")==2)
		{
			currentbowtexture=bowtexture[2];
		}
	}
	public void _rewards()
	{
		 if(PlayerPrefs.GetInt("challenge1")==1)
		{
			_firstrewards=100;
		}
		 if(PlayerPrefs.GetInt("challenge2")==1)
		{
			
			_secondrewards=100;
		}
		 if(PlayerPrefs.GetInt("challenge3")==1)
		{
			_thirdrewards = 100 ;
		}
		 if(PlayerPrefs.GetInt("challenge4")==1)
		{
			_fourthrewards = 100;
		}
		 if(PlayerPrefs.GetInt("challenge5")==1)
		{
			_fifthrewards = 100;
		}
		 if(PlayerPrefs.GetInt("challenge6")==1)
		{
			_sixthrewards = 50;//100;
		}
		 if(PlayerPrefs.GetInt("challenge7")==1)
		{
			_sevenrewards = 1200;
			
		}
		 if(PlayerPrefs.GetInt("challenge8")==1)
		{
			_eightrewards = 100 ;
		}
		 if(PlayerPrefs.GetInt("challenge9")==1)
		{
			_ninethrewards = 100;
		}
		 if(PlayerPrefs.GetInt("challenge10")==1)
		{
			_tenrewards = 2200;
		}
		 if(PlayerPrefs.GetInt("challenge11")==1)
		{
			_elvenrewards = 500;
		}
		if(PlayerPrefs.GetInt("challenge12")==1)
		{
			_tewelrewards =2000;// 500;
			
		}
		 if(PlayerPrefs.GetInt("challenge13")==1)
		{
			 _thirteenrewards = 3500;
		}
		 if(PlayerPrefs.GetInt("challenge14")==1)
		{
			_fourteenrewards = 500;//3500;
		}
		if(PlayerPrefs.GetInt("challenge15")==1)
		{
			_fifteenrewards = 12000;
		}
		
	}

     public void bowpurchase(int bownumber)
    
	{
		toatlcoins=PlayerPrefs.GetInt("Total_Coins");
		
	    if(bownumber==1&&PlayerPrefs.GetInt("Total_Coins")<bow1cost)
		{
			_chekoutofcoins=true;
		}
		if(bownumber==1&&PlayerPrefs.GetInt("Total_Coins")>=bow1cost)
		{
			
			toatlcoins=toatlcoins-bow1cost;
			saveTotalCoins();
			savefirstbowactivate();
		}
		
		if(bownumber==2&&PlayerPrefs.GetInt("Total_Coins")<bow2cost)
		{
			_chekoutofcoins=true;
		}
		if(bownumber==2&&PlayerPrefs.GetInt("Total_Coins")>=bow2cost)
		{
			toatlcoins=toatlcoins-bow2cost;
			saveTotalCoins();
			savesecondbowactivate();
		}
		
			if(bownumber==3&&PlayerPrefs.GetInt("Total_Coins")<bow3cost)
		{
			_chekoutofcoins=true;
		}
		if(bownumber==3&&PlayerPrefs.GetInt("Total_Coins")>=bow3cost)
		{
			toatlcoins=toatlcoins-bow3cost;
			saveTotalCoins();
			savethirdbowactivate();
		}
		
		
    
	}
	
	
	
	public void saveTotalCoins()
	{
		PlayerPrefs.SetInt("Total_Coins",toatlcoins);
	}
	public void savefirstbowactivate()
	{
		
		
	
	}
	public void savesecondbowactivate()
	{
		PlayerPrefs.SetInt("Secondbowactivate",1);
		PlayerPrefs.SetString("Secondbowtext", "Activate");
	}
	public void savethirdbowactivate()
	{
		PlayerPrefs.SetInt("Thirdbowactivate",1);
		PlayerPrefs.SetString("Thirdbowtext", "Activate");
	}
	
	
	public void savesecondarrowactivate()
	{
		PlayerPrefs.SetInt("SecondArrowactivate",1);
		PlayerPrefs.SetString("Secondarrowtext", "Activate");
	}
	public void savethirdarrowactivate()
	{
		PlayerPrefs.SetInt("ThirdArrowactivate",1);
		PlayerPrefs.SetString("Thirdarrowtext", "Activate");
	}
	
	public void accShop()
	{
		toatlcoins=PlayerPrefs.GetInt("Total_Coins");
		switch(PlayerPrefs.GetInt("acc_active"))
		{
		case 0:acc_cost=500;
			    break;
		case 1:
			   acc_cost=1500;
			    break;
		case 2: acc_cost=3000;
			    break;
		case 3:
			    acc_cost=5000;
			    break;
		case 4:
			    acc_cost=10000;
			    break;
			
		}
		if(PlayerPrefs.GetInt("Total_Coins")<acc_cost)
		{
				_chekoutofcoins=true;
		}
		if(PlayerPrefs.GetInt("Total_Coins")>=acc_cost)
		{
			toatlcoins=toatlcoins-acc_cost;
			currentaccability=PlayerPrefs.GetInt("acc_active")+1;
			PlayerPrefs.SetInt("acc_active",currentaccability);
			acc_ablityvalue=PlayerPrefs.GetFloat("acc_value")+addaccvalue;
			PlayerPrefs.SetFloat("acc_value",acc_ablityvalue);
			saveTotalCoins();
		}
		
		
	}
	public void stabilityshop()
	{
		toatlcoins=PlayerPrefs.GetInt("Total_Coins");	
		switch(PlayerPrefs.GetInt("stabilityactive"))
		{
		case 0: stabilitycost=500;
			    break;
		case 1:
			    stabilitycost=1500;
			    break;
		case 2: stabilitycost=3000;
			    break;
		case 3:
			    stabilitycost=5000;
			    break;
		case 4:
			    stabilitycost=10000;
			    break;
			
		}
		if(PlayerPrefs.GetInt("Total_Coins")<stabilitycost)
		{
			
			_chekoutofcoins=true;
		}
		if(PlayerPrefs.GetInt("Total_Coins")>=stabilitycost)
		{
			toatlcoins=toatlcoins-stabilitycost;
			currentstabilty=PlayerPrefs.GetInt("stabilityactive")+1;
			PlayerPrefs.SetInt("stabilityactive",currentstabilty);
			stabilityvalue=PlayerPrefs.GetFloat("stabilityvalue")+addstabilityvalue;
			PlayerPrefs.SetFloat("stabilityvalue",stabilityvalue);
			saveTotalCoins();
		}
		
	
		
		
	}
	public void powerShop()
	{
		toatlcoins=PlayerPrefs.GetInt("Total_Coins");
		switch(PlayerPrefs.GetInt("poweractive"))
		{
		case 0:powercost=500;
			    break;
		case 1:
			   powercost=1500;
			    break;
		case 2: powercost=3000;
			    break;
		case 3:
			   powercost=5000;
			    break;
		case 4:
			   powercost=10000;
			    break;
			
		}
		if(PlayerPrefs.GetInt("Total_Coins")<powercost)
		{
			_chekoutofcoins=true;
		}
		if(PlayerPrefs.GetInt("Total_Coins")>=powercost)
		{
			toatlcoins=toatlcoins-powercost;
			currentpowerability=PlayerPrefs.GetInt("poweractive")+1;
			PlayerPrefs.SetInt("poweractive",currentpowerability);
			powervalue=PlayerPrefs.GetFloat("powervalue")+addpowervalue;
			PlayerPrefs.SetFloat("powervalue",powervalue);
			saveTotalCoins();
		}
		
		
		
	}
	
	public void arrowpurchase(int arrownumber)
	{
		toatlcoins=PlayerPrefs.GetInt("Total_Coins");
		if(arrownumber==1&&PlayerPrefs.GetInt("Total_Coins")<arrow1cost)
		{
			_chekoutofcoins=true;
		}
		if(arrownumber==1&&PlayerPrefs.GetInt("Total_Coins")>=arrow1cost)
		{
			toatlcoins=toatlcoins-arrow1cost;
			firstnuberarrow=PlayerPrefs.GetInt("Firstnumberofarrow")+1;
			PlayerPrefs.SetInt("Firstnumberofarrow",firstnuberarrow);
			saveTotalCoins();
		}
		if(arrownumber==2&&PlayerPrefs.GetInt("Total_Coins")<arrow2cost)
		{
			_chekoutofcoins=true;
		}
		if(arrownumber==2&&PlayerPrefs.GetInt("Total_Coins")>=arrow2cost)
		{
			toatlcoins=toatlcoins-arrow2cost;
			secondnumberarrow=PlayerPrefs.GetInt("Secondnumberofarrow")+1;
			PlayerPrefs.SetInt("Secondnumberofarrow",secondnumberarrow);
			saveTotalCoins();
		}
		if(arrownumber==3&&PlayerPrefs.GetInt("Total_Coins")<arrow3cost)
		{
			_chekoutofcoins=true;
		}
		if(arrownumber==3&&PlayerPrefs.GetInt("Total_Coins")>=arrow3cost)
		{
			toatlcoins=toatlcoins-arrow3cost;
			thirdnumberarrow=PlayerPrefs.GetInt("Thirdnumberofarrow")+1;
			PlayerPrefs.SetInt("Thirdnumberofarrow",thirdnumberarrow);
			saveTotalCoins();
		}
		
		
		
	}
	
	public void realsearrow()
	{
		Realasearrow=true;
		
		
		
	}
	
}
