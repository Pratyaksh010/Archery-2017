/*using UnityEngine;
using System.Collections;

public class RandomShake : MonoBehaviour {
	
	
	public Transform target;
	
	public float m_minTimeToChange;
	
	public float m_maxTimeToChange;
	
	private float eventTime;
	
	private float delayTime;
	
	public float m_movementSpeed;
	
	public float m_minXRotation;
	
	public float m_maxXRotation;
	
	public float m_minYRotation;
	
	public float m_maxYRotation;
	
	private float xAmount;
	
	private float yAmount;
	public bool randomshakestart;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		
		
		
		
	  if(Time.time-eventTime>=delayTime)
		{
			
			eventTime=Time.time;
			
			delayTime=Random.Range(m_minTimeToChange,m_maxTimeToChange);
			
			xAmount=Random.Range(m_minXRotation,m_maxXRotation);
			
			yAmount=Random.Range(m_minYRotation,m_maxYRotation);
		}
		if(randomshakestart==true)
		{
		 target.Rotate(xAmount*m_movementSpeed*Time.deltaTime,yAmount*m_movementSpeed*Time.deltaTime,0);
		}
		
		
	}
}
*/