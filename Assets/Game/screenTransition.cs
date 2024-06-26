using UnityEngine;
using System.Collections;

public class screenTransition : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		RenderSettings.ambientLight = new Color(1,1,1,1);
		
		CDelayTime delay = gameObject.AddComponent<CDelayTime>();
		delay.actionWithDuration(1.0f);
		
		CScreenChangeColor change = gameObject.AddComponent<CScreenChangeColor>();
		change.actionWith(new Color(0,0,0,1),1.0f);
		
//		CScreenChangeColor change2 = gameObject.AddComponent<CScreenChangeColor>();
//		change2.actionWith(new Color(0,0,0,1),2.0f);
		
		CSequence seq = gameObject.AddComponent<CSequence>();
		seq.actionWithActions(delay,change);
		seq.runAction();
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
