using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rintangan2 : MonoBehaviour {

	public float delta = 2.0f;
	public float speed = 2.0f;
	public Vector3 startpos;

	// Use this for initialization
	void Start () {
		startpos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 v = startpos;
		v.x += delta * Mathf.Sin (Time.time * speed);
		transform.position = v;
	}
}
