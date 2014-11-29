using UnityEngine;
using System.Collections;

public class MainApplication : MonoBehaviour {

	static private int count=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	static public void countInc() {
		count++;
	}

	void OnGUI() {
		Rect rect = new Rect (10,10,150,100);
		GUI.Label(rect, "Count: " + count);
	}
}
