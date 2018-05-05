using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

	// Use this for initialization
	public Text scoretext;
	public int scoretill=0;
	int final=0;
	void Start () {
		//scoretext = GetComponent<Text>();
	}
	
	// Update is called once per frame
	public void ScoreUpdate () {
		scoretill += 1;
		scoretext.text = " "+scoretill;
		final = scoretill;
	}
}
