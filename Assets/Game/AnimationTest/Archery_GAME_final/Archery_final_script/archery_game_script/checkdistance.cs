using UnityEngine;
using System.Collections;

public class checkdistance : MonoBehaviour {
	public Transform[] objec;
	public float[] rad;
	// Use this for initialization
	void Start () 
	{
	   rad[0]=Vector2.Distance(new Vector2(objec[0].position.x,objec[0].position.y),new Vector2(objec[1].position.x,objec[1].position.y));
		rad[1]=Vector2.Distance(new Vector2(objec[0].position.x,objec[0].position.y),new Vector2(objec[2].position.x,objec[2].position.y));
		rad[2]=Vector2.Distance(new Vector2(objec[0].position.x,objec[0].position.y),new Vector2(objec[3].position.x,objec[3].position.y));
		rad[3]=Vector2.Distance(new Vector2(objec[0].position.x,objec[0].position.y),new Vector2(objec[4].position.x,objec[4].position.y));
		rad[4]=Vector2.Distance(new Vector2(objec[0].position.x,objec[0].position.y),new Vector2(objec[5].position.x,objec[5].position.y));
		rad[5]=Vector2.Distance(new Vector2(objec[0].position.x,objec[0].position.y),new Vector2(objec[6].position.x,objec[6].position.y));
		rad[6]=Vector2.Distance(new Vector2(objec[0].position.x,objec[0].position.y),new Vector2(objec[7].position.x,objec[7].position.y));
		rad[7]=Vector2.Distance(new Vector2(objec[0].position.x,objec[0].position.y),new Vector2(objec[8].position.x,objec[8].position.y));
		rad[8]=Vector2.Distance(new Vector2(objec[0].position.x,objec[0].position.y),new Vector2(objec[9].position.x,objec[9].position.y));
		rad[9]=Vector2.Distance(new Vector2(objec[0].position.x,objec[0].position.y),new Vector2(objec[10].position.x,objec[10].position.y));
		rad[10]=Vector2.Distance(new Vector2(objec[0].position.x,objec[0].position.y),new Vector2(objec[11].position.x,objec[11].position.y));
	
		//rad[13]=Vector2.Distance(new Vector2(objec[0].position.x,objec[0].position.y),new Vector2(objec[14].position.x,objec[14].position.y));
		
		
		
		for(int i=0;i<11;i++)
		{
			print (i+"=="+rad[i]+" rad ");
		}
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
