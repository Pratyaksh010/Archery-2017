using UnityEngine;
using System.Collections;

public class taptoskip : MonoBehaviour
{

	public Transform taptoskiptexture ;
	
	void Start () 
	{
	
	
		transform.GetComponent<GUIText>().material.color=new Color(1,1,1,0);
		//taptoskiptexture.ma
	}
	
	void Update()
	{
		if(transform.GetComponent<GUIText>().material.color.a==1&&taptoskiptexture.gameObject.active==false)
		{
			taptoskiptexture.gameObject.SetActive(true) ;
		}
		if(transform.GetComponent<GUIText>().material.color.a==0&&taptoskiptexture.gameObject.active==true)
		{
			taptoskiptexture.gameObject.SetActive(false) ;
		}
	}
	
}
