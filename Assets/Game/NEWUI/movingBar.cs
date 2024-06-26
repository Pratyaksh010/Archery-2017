using UnityEngine;
using System.Collections;

public class movingBar : MonoBehaviour
{
	
	public enum movingAxis
	{
		_xAxis,
		
		_yAxis,
		
		_zAxis 
	}
	
	public movingAxis _currentaxis ;
		
	public Transform _startPostion;
	
	public Transform _endPostion ;
	
	public Transform _movingObject ;
	
	public Transform _scallingObject ;
	
	public float _timeduration ;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		 if( _currentaxis==movingAxis._xAxis)
		{
	      _movingObject .position = Vector3.MoveTowards(_movingObject .position,_endPostion.position,_timeduration*Time.deltaTime);
		
	      _scallingObject.position = new Vector3( ( _movingObject .position.x +_startPostion.position.x)/2, _scallingObject.position.y, _scallingObject.position.z);
		
		   float distances = Vector3.Distance( _movingObject .position,_startPostion.position);
		
		   _scallingObject.localScale = new Vector3(distances, _scallingObject.localScale.y, _scallingObject.localScale.z);
		}
		 if( _currentaxis==movingAxis._yAxis)
		{
	      _movingObject .position = Vector3.MoveTowards(_movingObject .position,_endPostion.position,_timeduration*Time.deltaTime);
		
	      _scallingObject.position = new Vector3( _scallingObject.position.x,( _movingObject .position.y +_startPostion.position.y)/2, _scallingObject.position.z);
		
		   float distances = Vector3.Distance( _movingObject .position,_startPostion.position);
		
		   _scallingObject.localScale = new Vector3( _scallingObject.localScale.x,distances, _scallingObject.localScale.z);
		}
		 if( _currentaxis==movingAxis._zAxis)
		{
	       _movingObject .position = Vector3.MoveTowards(_movingObject .position,_endPostion.position,_timeduration*Time.deltaTime);
		 
	       _scallingObject.position = new Vector3( _scallingObject.position.x, _scallingObject.position.y ,( _movingObject .position.z +_startPostion.position.z)/2);
		
		   float distances = Vector3.Distance( _movingObject .position,_startPostion.position);
		
		   _scallingObject.localScale = new Vector3(_scallingObject.localScale.x, _scallingObject.localScale.y, distances);
		}
	}
}
