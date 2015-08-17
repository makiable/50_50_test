using UnityEngine;
using System.Collections;

public class Success_Scripts : MonoBehaviour {

	public TextMesh mTextMesh;
	
	// Use this for initialization
	void Start () {
		LiveDays.LiveDaysint += 1;
		mTextMesh.text = LiveDays.LiveDaysint.ToString ();
	}
}
