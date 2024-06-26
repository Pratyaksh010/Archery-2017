using UnityEngine;
using System.Collections;

public class addcoins : MonoBehaviour 
{

	
	
	void Start () 
	{
	/////////////// transform.guiText.text=""+PlayerPrefs.GetInt("Total_Coins");
	}
	
	public void Update()
	{
		transform.GetComponent<GUIText>().text=""+PlayerPrefs.GetInt("Total_Coins");
	}
	

}
