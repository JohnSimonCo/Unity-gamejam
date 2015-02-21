using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//rigidbody2D.AddForce(new Vector2 (0, 500));
	}

	bool accelerate = false;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up")) {
			accelerate = true;
		}
		if (Input.GetKey ("right")) {
			transform.Rotate(new Vector3(0, 0, -1));
		}
		if (Input.GetKey ("left")) {
			transform.Rotate(new Vector3(0, 0, 1));
		}
	}

	void FixedUpdate() {
		if (accelerate) {
			accelerate = false;
			rigidbody2D.AddForce(transform.up * Time.deltaTime * 1000);
		}
	}
}
