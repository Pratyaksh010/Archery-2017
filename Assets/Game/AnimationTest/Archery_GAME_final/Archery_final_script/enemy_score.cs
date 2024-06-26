using UnityEngine;
using System.Collections;

public class enemy_score : MonoBehaviour
{

	// Use this for initialization
	public int enemySc;// show the enemy current Score;
	
	public int enemyScoreSum;// show sum of score;
	
	public bool onetimecall;
	
	public int minrange;
	
	public int maxrange;
	
	public static enemy_score instances;
	
	public int firstsetscore;
	
	public int secondsetscore;
	
	public int thirdsetscore;
	
	public int foursetscore;
	
	public int i=0;
	
	public int _bulltarget;
	
	public int _eneMyScoremultiplier ;
	void Awake()
	{
		instances=this;
		_eneMyScoremultiplier = 1;
	}
	
	void Start () 
	{
	    enemySc=Random.Range(minrange,maxrange);
		enemyScoreSum= enemySc;
		
		
		i=1;
		controll.instance.enemyScoresum=enemyScoreSum;	
		
		challenge_Controll.instances.enemyScoresum=enemyScoreSum;
	}
	
	public void enemY_sco(int playercurrentsc)
	{
		
		
		switch (playercurrentsc)
       {
        case 0:
            enemySc=Random.Range(0,5);
			
			enemyScoreSum=enemyScoreSum+(enemySc*_eneMyScoremultiplier);
        break;
        case 1:
            enemySc=Random.Range(0,5);
			
			enemyScoreSum=enemyScoreSum+(enemySc*_eneMyScoremultiplier);
        break;
		case 2:
			enemySc=Random.Range(1,6);
			
			enemyScoreSum=enemyScoreSum+(enemySc*_eneMyScoremultiplier);
       
        break;
        case 3:
            enemySc=Random.Range(2,7);
		
			enemyScoreSum=enemyScoreSum+(enemySc*_eneMyScoremultiplier);
        break;
		case 4:
            enemySc=Random.Range(3,8);
			//enemySc =  enemySc*_eneMyScoremultiplier ;
			enemyScoreSum=enemyScoreSum+(enemySc*_eneMyScoremultiplier);
        break;
        case 5:
            enemySc=Random.Range(6,9);
			
			enemyScoreSum=enemyScoreSum+(enemySc*_eneMyScoremultiplier);
        break;
		case 6:
            enemySc=Random.Range(5,9);
			
			enemyScoreSum=enemyScoreSum+(enemySc*_eneMyScoremultiplier);
        break;
        case 7:
            enemySc=Random.Range(4,11);
		
			enemyScoreSum=enemyScoreSum+(enemySc*_eneMyScoremultiplier);
        break;
		case 8:
            enemySc=Random.Range(7,11);
	
			enemyScoreSum=enemyScoreSum+(enemySc*_eneMyScoremultiplier);
        break;
        case 9:
            enemySc=Random.Range(8,11);
			//enemySc =  
			enemyScoreSum=enemyScoreSum+(enemySc*_eneMyScoremultiplier);
			if(enemySc==11)
		{
			_bulltarget=_bulltarget+1;
		}
        break;
		case 10:
            enemySc=Random.Range(8,11);
			
			enemyScoreSum=enemyScoreSum+(enemySc*_eneMyScoremultiplier);
			if(enemySc==11)
		{
			_bulltarget=_bulltarget+1;
		}
         break;
       
		}
		
		//controll.instance.enemyScoresum=enemyScoreSum;
		
	    if(i<=2)
		{
			firstsetscore=enemyScoreSum;
		}
		
		if(i>2&&i<=5)
		{
			
			secondsetscore=(enemyScoreSum-firstsetscore);
		}
		
		if(i>5&&i<=8)
		{
			thirdsetscore=(enemyScoreSum-(secondsetscore+firstsetscore));
		}
		
		if(i>8&&i<=11)
		{
			foursetscore=(enemyScoreSum-(thirdsetscore+secondsetscore+firstsetscore));
		}
		
		
		
		controll.instance.enemyScoresum=enemyScoreSum;
		
		if(challenge_Controll.instances.currentChallenge==challenge_Controll.ArcheryChallenge.challenge7)
		{
			challenge_Controll.instances.enemyScoresum=enemyScoreSum;
		}
		i=i+1;
		enemy_score.instances._eneMyScoremultiplier = 1;
	}
	//void OnGUI()
	//{
	    //
		//controll.instance.enemyScoresum=enemyScoreSum;	
		//challenge_Controll.instances.enemyScoresum=enemyScoreSum;
	///}
}
