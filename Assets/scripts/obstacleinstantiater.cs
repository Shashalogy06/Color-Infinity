using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleinstantiater : MonoBehaviour {

	public GameObject[] inst;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void producer()
	{
		int i = Random.Range (0, inst.Length);
		Instantiate(inst[i],new Vector3(inst[i].transform.position.x,transform.position.y+3f,inst[i].transform.position.z),Quaternion.identity);
			}
}
