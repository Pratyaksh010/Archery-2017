using UnityEngine;
using System.Collections;

public class ro : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public float scrollSpeed = 0.5f;
void Update() {
    float offset = Time.time * scrollSpeed;
    
    GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (0f,offset);
    GetComponent<Renderer>().material.mainTexture.wrapMode = TextureWrapMode.Repeat;
}
}