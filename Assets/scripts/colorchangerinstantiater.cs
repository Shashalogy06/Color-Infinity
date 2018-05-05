using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchangerinstantiater : MonoBehaviour {

	// Use this for initialization
	public GameObject c;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void changer()
	{
		Instantiate(c,new Vector3(c.transform.position.x,transform.position.y+3f,c.transform.position.z),Quaternion.identity);
	}
}
