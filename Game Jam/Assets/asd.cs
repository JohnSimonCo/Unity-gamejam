using UnityEngine;
using System.Collections;

public class DrawRamp : MonoBehaviour {

	public Vector2 Scale = new Vector2(1, 1);

	private Vector2[] Positions;

	// Use this for initialization
	void Start () {
		LineRenderer line = GetComponent<LineRenderer>();
		line.SetVertexCount(20);

		for (int i = 0; i < 20; i++) {
			float x = i / 20f, y = 1 - Mathf.Sin(x * 2.2f) * 2;
			x *= Scale.x;
			y *= Scale.y;

         	Positions[i] = new Vector2(x, y);

			line.SetPosition (i, new Vector3(x, y, 0));
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
