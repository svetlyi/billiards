using UnityEngine;
using System.Collections;

public class keyHandler : MonoBehaviour {
	public int speedForce = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("right")) {
			this.gameObject.rigidbody.AddForce(0, 0, speedForce);
		}
		if (Input.GetKey ("left")) {
			this.gameObject.rigidbody.AddForce(0, 0, -speedForce);
		}
		if (Input.GetKey ("up")) {	
			this.gameObject.rigidbody.AddForce(-speedForce, 0, 0);
		}
		if (Input.GetKey ("down")) {
			this.gameObject.rigidbody.AddForce(speedForce, 0, 0);
		}
		if (Input.GetKey ("space")) {
			this.gameObject.rigidbody.AddForce(0, 0, speedForce);
		}
	}
}
