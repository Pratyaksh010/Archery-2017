using UnityEngine;
using System.Collections;

public class loadingscript : MonoBehaviour
{
		public int i;
	
		public GUITexture[] lodingtexture;
	
		public Texture afterchangetexture;
	
		public GUITexture current;
	
		int j = 0;
	
		float randomRange;
	
		// Use this for initialization
		public float loadingtime;
	
		public bool onetime;
	
		public GameObject _loadingbar ;
	
		void Start ()
		{
		notDestroy.instances.OnShowBannerAds (true, true);
				if (_loadingbar != null) {
						Instantiate (_loadingbar, _loadingbar.transform.position, _loadingbar.transform.rotation);
				}
				i = store_currentStatus.instances.currentscene;
				randomRange = .1f;
				if (i == 1) {  // reset purpose
						notDestroy.instances.checkchallengemode = false;
				}
				loadingtime = Time.time;
				store_currentStatus.instances.joystickactive = false;
				store_currentStatus.instances.resetarrowvalue = 0;
				//Application.LoadLevel(i);
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Time.time - loadingtime > randomRange) {
						//Application.LoadLevel(i);
						if (j < 6) {
								lodingtexture [j].texture = afterchangetexture;
								loadingtime = Time.time;
								randomRange = Random.Range (.05f, .06f);
						}
						j = j + 1;

				
						//lodingtexture
				}
		
				if (j >= 6) {
						//if(i==1)//&&store_currentStatus.instances.loadingcheck==false)
						//{
						//Application.LoadLevel(4);
						//}
						//else
						//{
						//Resources.UnloadUnusedAssets();
						Application.LoadLevel (4);//i
						//}
			
			
				}
		
		}
}
