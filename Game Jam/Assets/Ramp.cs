using UnityEngine;
using System.Collections;

public class Ramp : MonoBehaviour {

	public int Resolution = 20;

	public Vector2 Scale = new Vector2(1, 1);
	
	private Vector3[] Positions;
	private float[] Angles;
	
	// Use this for initialization
	void Start () {
		Positions = new Vector3[Resolution];
		Angles = new float[Resolution];

		LineRenderer line = GetComponent<LineRenderer>();
		line.SetVertexCount(Resolution);

		float fRes = Resolution / 2f;

		for (int i = 0; i < Resolution; i++) {
			float x = i / fRes - 1;
			float y = 1 - Mathf.Sin(1.1f * (x + 1)) * 2;
			
			float derivative = -1.1f * Mathf.Cos(1.1f * (x + 1)) * 2;
			
			x *= Scale.x;
			y *= Scale.y;

			Positions[i] = transform.TransformPoint(new Vector3(x, y, 0));
			Angles[i] = Mathf.Atan(derivative) * 180 / Mathf.PI;

			line.SetPosition (i, new Vector3(x, y, 0));
		}
	}

	public Vector3 GetPosition(int x) {
		return Positions[x];
	}

	public float GetAngle(int x) {
		return Angles[x];
	}
}
