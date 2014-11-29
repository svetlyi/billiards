using UnityEngine;
using System.Collections;

public class gameLogic : MonoBehaviour {
	private int count = 0;
	public GameObject prefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "CubeGoal") {
			Vector3 newPos = new Vector3(Random.Range(-4.0F, 2.0F), 4, Random.Range(-8.0F, 0F));
			MainApplication.countInc();
			Instantiate(this.prefab, newPos, transform.rotation);
			Destroy(this.gameObject);
		}
	}
}
