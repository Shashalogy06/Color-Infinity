using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
	public Transform player;
	public Transform last;
	public Transform current;
	public colorchangerinstantiater c;
	public obstacleinstantiater o;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance (last.position, current.position);
		if (player.position.y > transform.position.y) {
			if (dist >= 7) {
				dist = 0;
				last.position = new Vector3 (last.position.x, current.position.y, last.position.z);
				c.changer ();
				o.producer ();
			}
			transform.position = new Vector3 (0f, player.position.y, transform.position.z);
		}
	}
}
