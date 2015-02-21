using UnityEngine;
using System.Collections;

public class DrawRamp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LineRenderer line = gameObject.AddComponent<LineRenderer>();
		line.SetVertexCount(2);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
