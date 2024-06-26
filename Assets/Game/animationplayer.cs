using UnityEngine;
using System.Collections;

public class animationplayer : MonoBehaviour 
{

	// Use this for initialization
	//string s2;
	//bool t1;
	//bool idle;
	
	
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	   
	
		
	}
	public void startanimaton(string s1)
	{
		//s2=s1;
		#if UNITY_ANDROID
		Debug.Log("This is Android Device");
		transform.position = new Vector3 (2.5f,transform.position.y,transform.position.z);
		#elif UNITY_IOS
		if((iPhone.generation.ToString()).IndexOf("iPad") > -1){
			Debug.Log("This is Ipad");
		}
		else
		{
			transform.position = new Vector3 (2.5f,transform.position.y,transform.position.z);
		}
		#endif
		GetComponent<Animation>().Play(s1);
		//animation.CrossFade(s1);
		
		
		//StartCoroutine(NextIdleAnimation(s1));
		
		//time=Time.time;
	}
	
	
/*	IEnumerator NextIdleAnimation(string  s2)
		
	{ 
		  yield return new WaitForSeconds(animation[s2].length);
		// animation.CrossFade(s2,.2f);
		// yield return new WaitForSeconds(1f);
		
		//animation
	}*/
}
