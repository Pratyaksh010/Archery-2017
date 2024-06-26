using UnityEngine;
using System.Collections;

public class GameStates : MonoBehaviour {
	
	
	public enum States
	{
	    isGameOver,
		isGamePaused,
		Active,
		
		
		
		
	};
	
	public States gameStates;
	public static GameStates instance;
	// Use this for initialization
	void Start () {
	
	}
	
	void Awake()
	{
		instance=this;
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
