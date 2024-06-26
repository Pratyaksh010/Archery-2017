using UnityEngine;
using System.Collections;

public class screenmanagercall : MonoBehaviour
{

		// Use this for initialization
		public ScreenManager _CashPlay;
		public GameObject _GameCashPromo;
		public GameObject ScreenmanagerObject;
		public ScreenManager Screenmanagerscript;
		public string[] _currentloadingpage;
		GameObject go;
		void Start ()
		{
				Screenmanagerscript = ScreenmanagerObject.GetComponent ("ScreenManager")as ScreenManager;
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
		public void showscorepanael ()
		{
				//if(_GUIItmManagerArr != null)
				//{
				if (notDestroy.instances._emPlayMode == notDestroy.ePlayMode.PlayForNormal) {
						Screenmanagerscript.LoadScreen (_currentloadingpage [0]);//_GUIItmManagerArr[0].name);// ankit 1
				} else {
						Screenmanagerscript.LoadScreen (_currentloadingpage [3]);

				}				///////	//}
		}
	
		public void showPause (string pauseloading)
		{
		
				//if(_GUIItmManagerArr != null)
				//{
				//LoadScreen(pauseloading);//_GUIItmManagerArr[3].name);
				Screenmanagerscript.LoadScreen (pauseloading);
				//}
		}
	
		public void winmatch ()
		{
				int p = notDestroy.instances.gameCount++;
				//if(_GUIItmManagerArr != null)
				//{
				Screenmanagerscript.LoadScreen (_currentloadingpage [1]);//_GUIItmManagerArr[4].name);
				//}
				if (p >= 5) {
						notDestroy.instances.gameCount = 0;
						//go = Instantiate (_GameCashPromo) as GameObject;
						_CashPlay.LoadScreen ("CashPlayPromo");
				}
		}
		public void CashPlay ()
		{
				notDestroy.instances.mAirIndex = 0;
		}
		public void losematch ()
		{
				int p = notDestroy.instances.gameCount++;

				//if(_GUIItmManagerArr != null)
				//{
				Screenmanagerscript.LoadScreen (_currentloadingpage [2]);//_GUIItmManagerArr[5].name);
				//}
				if (p >= 5) {

						notDestroy.instances.gameCount = 0;
						//go = Instantiate (_GameCashPromo) as GameObject;
						_CashPlay.LoadScreen ("CashPlayPromo");


				}
		
		}
	
		public void showIndoorscorepanael ()
		{
				//if(_GUIItmManagerArr != null)
				//{
				Screenmanagerscript.LoadScreen (_currentloadingpage [0]);//_GUIItmManagerArr[0].name);
				//}
		
		}
	
		public void showIndoorPause (string loadingpause)
		{
				//if(_GUIItmManagerArr != null)
				//{
				Screenmanagerscript.LoadScreen (loadingpause);//_GUIItmManagerArr[1].name);
				//}
		}
	
		/*public void showPausecha()
	{
		LoadScreen(_GUIItmManagerArr[6].name);
			
	}*/
	
		public void showresultcom ()
		{
				Screenmanagerscript.LoadScreen ("Challenge_complete");
		}
		public void showresultnotcom ()
		{
				Screenmanagerscript.LoadScreen ("Challenge_notcomplete");
		}
	
}
