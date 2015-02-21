using UnityEngine;
using System.Collections;

public class RideRamp : MonoBehaviour {

	public GameObject RampHolder;
	private Ramp Ramp;

	// Use this for initialization
	void Start () {
		Ramp = RampHolder.GetComponent<Ramp>();
	}

	float x = 0;
	// Update is called once per frame
	void Update () {
		x += Time.deltaTime;
		int index = (int) (x * 10f);

		index %= Ramp.Resolution;

		Vector3 pos = Ramp.GetPosition (index);
		transform.position = new Vector3(pos.x, pos.y, transform.position.z);

		float angle = Ramp.GetAngle (index);
		transform.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
	}
}
