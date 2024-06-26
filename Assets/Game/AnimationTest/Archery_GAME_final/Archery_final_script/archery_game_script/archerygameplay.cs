
/*using UnityEngine;
using System.Collections;

public class archerygameplay : MonoBehaviour {
	public int numberofset;
	public int numberofArrow;
	public int setsize;
	public int maxArrow;
	public int completesetno=1;
	public bool completeSet;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	 
		
	}
	public void countset()
	{
	 
		  
	       if(completeSet==false)
	     
		  {
		     
	           numberofArrow=numberofArrow+1;
		 
		       if(numberofArrow==maxArrow)
		
			  {
			        numberofArrow=0;
			
			        numberofset=numberofset+1;
			
			        completesetno=completesetno+1;
			
			        if(numberofset>setsize)
			
			       {
				       completeSet=true;
			       }
		     
			 }
				
	      }
		else
		{
		   print ("complete");	
		}

     }
	void OnGUI()
	{
		GUI.Label(new Rect(Screen.width/2-50,100,100,100),"SET  "+completesetno);
	}
}
 */