using UnityEngine;
using System.Collections;
using Ovr;

public class MirrorController : MonoBehaviour {

	public bool mirrorMode;

	// Use this for initialization
	void Start () {
		int mirror = PlayerPrefs.GetInt("mirrorMode", -1);
		if (mirror == -1) {
			mirror = (mirrorMode == true) ? 1 : 0;
			PlayerPrefs.SetInt("mirrorMode", mirror);
			PlayerPrefs.Save();
		} else {
			mirrorMode = (mirror == 1) ? true : false;
		}
		OVRManager.display.mirrorMode = mirrorMode;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.M)) {
			mirrorMode = !mirrorMode;
			int mirror = (mirrorMode == true) ? 1 : 0;
			PlayerPrefs.SetInt("mirrorMode", mirror);
			PlayerPrefs.Save();
		}
	}
}
