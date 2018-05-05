using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ball : MonoBehaviour {

	// Use this for initialization
	public Rigidbody2D player;
	public string curcolor;
	public SpriteRenderer sr;//to change the color or sprite of the ball
	public Color blue,red,violet,yellow;
	public float jumpspeed;
	public Canvas gameover;
	public Text finalscore;
	bool check;
	public score ss;
	void Start () {
		gameover.enabled = false;
		setcolor ();
		check = false;
		Time.timeScale = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0) && check == false) {
			check = true;
			Time.timeScale = 1f;
		}
		if (Input.GetMouseButton (0) && check==true) {
			player.velocity = Vector2.up * jumpspeed;
		}
	}
	void setcolor()
	{
		int i=Random.Range(0,4);
		if (i == 0) {
			curcolor = "blue";
			sr.color = blue;
		}
		else if (i == 1) {
			curcolor = "red";
			sr.color = red;
		}
		else if (i == 2) {
			curcolor = "purple";
			sr.color = violet;
		}
		else if (i == 3) {
			curcolor = "yellow";
			sr.color = yellow;
		}
	}
	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.tag == "colorchanger") {
			Debug.Log ("from here");
			setcolor ();
			Destroy (c.gameObject);
			return;
		}
		if (c.gameObject.tag != curcolor) {
			Debug.Log ("Game Over");
			Destroy (player);
			gameover.enabled=true;
			finalscore.text = " " + ss.scoretill;
		}

	}
}
