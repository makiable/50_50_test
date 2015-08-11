using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	

	public class UIScripts : MonoBehaviour {
		
		// Use this for initialization
		void OnButtonDown(string type){
			if (type == "Start") {
				Application.LoadLevel("Test_Game");
			}
		}
	}


}
