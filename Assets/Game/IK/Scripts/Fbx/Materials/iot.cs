using UnityEngine;
using System.Collections;

public class iot : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
		sum o1=new sum();
		mul o2=new mul();
		nj o3=new nj();
		o1.num();
		o2.num();
		o3.num();
		print ("f");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}

class sum
{
	public void num()
	{
		 // print("sum");
    Debug.Log("sum");
	}
}
class mul
{
	public void num()
	{
		   Debug.Log("mul");
	}
}
class nj
{
	public void num()
	{
		  Debug.Log("nj");
	}
}