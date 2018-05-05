using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour {

	// Use this for initialization
	public float speed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0f, 0f, speed * Time.deltaTime);
	}
}
