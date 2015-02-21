using UnityEngine;
using System.Collections;

public class DrawRamp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LineRenderer line = GetComponent<LineRenderer>();
		line.SetVertexCount(2);
		line.SetPosition (0, new Vector3(-1, 0, 0));
		line.SetPosition (1, new Vector3(1, 0, 0));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
